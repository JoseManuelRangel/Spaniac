using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using Spaniac.Clases;
using Spaniac.Formularios.Internos.Clientes;
using Spaniac.Modelos;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Color = System.Drawing.Color;

namespace Spaniac.Formularios.Internos.Proveedores
{
    public partial class FormProveedores : Form
    {
        /* Ruta de conexión para la BD. */
        static string conection = "server=localhost; database=Spaniac; integrated security=true";

        /* Variables booleanas estáticas que controlan si los paneles están visibles o no. */
        static bool pExcel = false, pJson = false, pXml = false;

        /* Variables boolenas que indican si los campos colocados en la inserción están bien. */
        static bool cifCorr = false, nomCorr = false, tipCorr = false, locCorr = false, dirCorr = false, telCorr = false;

        /* Variables booleanas que indican si los campos colocados en la modificación están bien. */
        static bool cifCorrMod = false, nomCorrMod = false, tipCorrMod = false, locCorrMod = false, dirCorrMod = false, telCorrMod = false;

        /* Variables booleanas sque controlan si los datos del proveedor están completos para realizar la eliminación. */
        bool idCorrBorr = false;

        /* Determina si se ha encontrado el cliente u otro dato importante en la base de datos previamente registrado. */
        static bool encontrado = false;

        /* Listas. */
        static List<string> nodosXML = new List<string>();

        /* Variable cadena que almacena el JSON cargado. */
        static string proveedoresJSON;

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormProveedores()
        {
            InitializeComponent();

            rellenaComboBoxCIFProveedor();
            rellenaTablaProveedores();
            rellenaCbDatosProveedores();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                        GESTION DE EVENTOS DEL TIMER DE LA HORA Y LA FECHA                       */
        /*-------------------------------------------------------------------------------------------------*/
        private void horafecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToLongDateString().ToUpper();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                            GESTIÓN DE EVENTOS DEL BOTÓN DEL MENÚ XML                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnMenuXml_Click(object sender, EventArgs e)
        {
            if (pXml == false)
            {
                panelMenuXml.Visible = true;
                pXml = true;
            }
            else
            {
                panelMenuXml.Visible = false;
                pXml = false;
            }
        }

        /*                      Gestión de eventos del botón generar XML del menú XML                      */
        private void btnGenXML_Click(object sender, EventArgs e)
        {
            generaXML();
        }
        private void btnGenXML_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnGenXML.ForeColor = Color.White;
        }

        private void btnGenXML_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btnGenXML.ForeColor = Color.MidnightBlue;
        }

        /*                        Gestión de eventos del botón leer XML del menú XML                       */
        private void btnListarXML_Click(object sender, EventArgs e)
        {
            compruebaXML();
        }

        private void btnListarXML_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnListarXML.ForeColor = Color.White;
        }

        private void btnListarXML_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btnListarXML.ForeColor = Color.MidnightBlue;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           GESTIÓN DE EVENTOS DEL BOTÓN DEL MENÚ JSON                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnMenuJSON_Click(object sender, EventArgs e)
        {
            if (pJson == false)
            {
                panelMenuJson.Visible = true;
                pJson = true;
            }
            else
            {
                panelMenuJson.Visible = false;
                pJson = false;
            }
        }

        /*                      Gestión de eventos del botón generar JSON del menú JSON                    */
        private void btnGenJSON_Click(object sender, EventArgs e)
        {
            generaJSON();
        }

        private void btnGenJSON_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnGenJSON.ForeColor = Color.White;
        }

        private void btnGenJSON_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btnGenJSON.ForeColor = Color.MidnightBlue;
        }

        /*                       Gestión de eventos del botón leer JSON del menú JSON                      */
        private void btnListarJSON_Click(object sender, EventArgs e)
        {
            compruebaJSON();
        }

        private void btnListarJSON_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnListarJSON.ForeColor = Color.White;
        }

        private void btnListarJSON_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btnListarJSON.ForeColor = Color.MidnightBlue;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                          GESTIÓN DE EVENTOS DEL BOTÓN DEL MENÚ EXCEL                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnMenuEXCEL_Click(object sender, EventArgs e)
        {
            if (pExcel == false)
            {
                panelMenuExcel.Visible = true;
                pExcel = true;
            }
            else
            {
                panelMenuExcel.Visible = false;
                pExcel = false;
            }
        }

        /*                      Gestión de eventos del botón generar EXCEL del menú EXCEL                      */
        private void btnGenEXCEL_Click(object sender, EventArgs e)
        {
            generaExcel();
        }

        private void btnGenEXCEL_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnGenEXCEL.ForeColor = Color.White;
        }

        private void btnGenEXCEL_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnGenEXCEL.ForeColor = Color.MidnightBlue;
        }

        /*                       Gestión de eventos del botón leer EXCEL del menú EXCEL                    */
        private void btnListarEXCEL_Click(object sender, EventArgs e)
        {
            compruebaExcel();
        }

        private void btnListarEXCEL_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnListarEXCEL.ForeColor = Color.White;
        }

        private void btnListarEXCEL_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnListarEXCEL.ForeColor = Color.MidnightBlue;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                         ELEMENTOS DEL PANEL IZQUIERDO DE LOS PROVEEDORES                        */
        /*-------------------------------------------------------------------------------------------------*/
        /*              Gestión de eventos del botón que abre el panel para añadir un proveedor.           */
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            panelAñadirPro.Visible = true;
            panelModificarPro.Visible = false;
            panelBorrarPro.Visible = false;
            panelPortada.Visible = false;
            inicializaDatos("Añadir");
            
        }

        private void btnAñadir_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAñadir_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*              Gestión de eventos del botón que abre el panel para editar un proveedor.           */
        private void btnModificar_Click(object sender, EventArgs e)
        {
            panelModificarPro.Visible = true;
            panelAñadirPro.Visible = false;
            panelBorrarPro.Visible = false;
            panelPortada.Visible = false;
            inicializaDatos("Modificar");
        }

        private void btnModificar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*            Gestión de eventos del botón que abre el panel para borrar una cliente.           */
        private void btnBorra_Click(object sender, EventArgs e)
        {
            panelBorrarPro.Visible = true;
            panelModificarPro.Visible = false;
            panelAñadirPro.Visible = false;
            panelPortada.Visible = false;
            inicializaDatos("Borrar");
        }

        private void btnBorra_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnBorra_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }



        /*-------------------------------------------------------------------------------------------------*/
        /*                          ELEMENTOS DEL SUBPANEL QUE AÑADE UN PROVEEDOR                          */
        /*-------------------------------------------------------------------------------------------------*/
        /*                   Gestión de eventos del textbox del cif de proveedor a añadir                  */
        private void txtCIF_Enter(object sender, EventArgs e)
        {
            if (txtCIF.Text.Equals("CIF"))
            {
                txtCIF.Text = "";
                txtCIF.ForeColor = Color.Black;
            }
        }

        private void txtCIF_Leave(object sender, EventArgs e)
        {
            if (txtCIF.Text.Equals(""))
            {
                txtCIF.Text = "CIF";
                txtCIF.ForeColor = Color.DarkGray;
                lbCIF.ForeColor = Color.Black;
                lbErrorCIF.Text = "";
                lbErrorCIF.Visible = false;
            }
        }

        private void txtCIF_TextChanged(object sender, EventArgs e)
        {
            compruebaCIFProveedor();
        }


        /*                  Gestión de eventos del textbox del nombre del proveedor a añadir                 */
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombreProv.Text.Equals("Nombre"))
            {
                txtNombreProv.Text = "";
                txtNombreProv.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombreProv.Text.Equals(""))
            {
                txtNombreProv.Text = "Nombre";
                txtNombreProv.ForeColor = Color.DarkGray;
                lbNombre.ForeColor = Color.Black;
                lbErrorNom.Text = "";
                lbErrorNom.Visible = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            compruebaNombreProveedor("Añadir");
        }


        /*                  Gestión de eventos del textbox de la prioridad del proveedor                 */
        private void tipoProv_ValueChanged(object sender, EventArgs e)
        {
            if(tipoProv.Value != 0 && tipoProv.Value > 0)
            {
                lbErrorTipo.Text = "";
                lbErrorTipo.Visible = false;

                tipCorr = true;
            } else
            {
                lbErrorTipo.Text = "Introduce un número válido.";
                lbErrorTipo.Visible = true;

                tipCorr = false;
            }
        }


        /*                Gestión de eventos del textbox de localidad del proveedor a añadir                 */
        private void txtLocalidad_Enter(object sender, EventArgs e)
        {
            if (txtLocalidad.Text.Equals("Localidad"))
            {
                txtLocalidad.Text = "";
                txtLocalidad.ForeColor = Color.Black;
            }
        }

        private void txtLocalidad_Leave(object sender, EventArgs e)
        {
            if (txtLocalidad.Text.Equals(""))
            {
                txtLocalidad.Text = "Localidad";
                txtLocalidad.ForeColor = Color.DarkGray;
                lbLocalidad.ForeColor = Color.Black;
                lbErrorLocalidad.Text = "";
                lbErrorLocalidad.Visible = false;
            }
        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            compruebaLocalidadProveedor("Añadir");
        }


        /*                  Gestión de eventos del textbox de la dirección del cliente a añadir                 */
        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Equals("Direccion"))
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.Black;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Equals(""))
            {
                txtDireccion.Text = "Direccion";
                txtDireccion.ForeColor = Color.DarkGray;
                lbDireccion.ForeColor = Color.Black;
                lbErrorDireccion.Text = "";
                lbErrorDireccion.Visible = false;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            compruebaDireccionProveedor("Añadir");
        }


        /*                  Gestión de eventos del textbox de teléfono del cliente a añadir                 */
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals("Telefono"))
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals(""))
            {
                txtTelefono.Text = "Telefono";
                txtTelefono.ForeColor = Color.DarkGray;
                lbTelefono.ForeColor = Color.Black;
                lbErrorTelefono.Text = "";
                lbErrorTelefono.Visible = false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            compruebaTelefonoProveedor("Añadir");
        }


        /*            Gestión de eventos del botón limpiar datos de la inserción de proveedor               */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCIF.Text = "";
            txtNombreProv.Text = "";
            tipoProv.Value = 0;
            txtLocalidad.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void btnLimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /* Gestión de eventos del botón que comprueba si todos los datos son correctos y añade un proveedor  */
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(cifCorr && nomCorr && tipCorr && locCorr && dirCorr && telCorr)
            {
                DatosProveedor datosNuevoPro = new DatosProveedor();
                datosNuevoPro.Cif = txtCIF.Text;
                datosNuevoPro.Nombre = txtNombreProv.Text;
                datosNuevoPro.TipoProveedor = int.Parse(tipoProv.Value.ToString());
                datosNuevoPro.FechaRegistro = DateTime.Parse(DateTime.UtcNow.ToString("d"));
                datosNuevoPro.Localidad = txtLocalidad.Text;
                datosNuevoPro.Direccion = txtDireccion.Text;
                datosNuevoPro.Telefono = txtTelefono.Text;
                datosNuevoPro.guardarCambios();

                FormNotificaciones form = new FormNotificaciones("Proveedor registrado correctamente.");
                form.Show();

                rellenaTablaProveedores();
                rellenaComboBoxCIFProveedor();
                inicializaDatos("Añadir");
            }
        }

        private void btnGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                          ELEMENTOS DEL SUBPANEL QUE MODIFICA UN PROVEEDOR                       */
        /*-------------------------------------------------------------------------------------------------*/
        /*                    Gestión de eventos del combobox del cif de proveedor a editar                */
        private void cbIDProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            compruebaProveedores();
        }

        /*                Gestión de eventos del textbox de nombre que modifica el proveedor               */
        private void txtNombreMod_TextChanged(object sender, EventArgs e)
        {
            compruebaNombreProveedor("Modificar");
        }

        /*              Gestión de eventos del tipo de proveedor que modifica el cliente                   */
        private void tipoProvMod_ValueChanged(object sender, EventArgs e)
        {
            if (tipoProvMod.Value != 0 && tipoProvMod.Value > 0)
            {
                lbErrorTipoProvMod.Text = "";
                lbErrorTipoProvMod.Visible = false;

                tipCorrMod = true;
            }
            else
            {
                lbErrorTipoProvMod.Text = "Introduce un número válido.";
                lbErrorTipoProvMod.Visible = true;

                tipCorrMod = false;
            }
        }

        /*              Gestión de eventos del textbox de localidad que modifica el proveedor              */
        private void txtLocalidadMod_TextChanged(object sender, EventArgs e)
        {
            compruebaLocalidadProveedor("Modificar");
        }

        /*             Gestión de eventos del textbox de direccion que modifica el proveedor               */
        private void txtDireccionMod_TextChanged(object sender, EventArgs e)
        {
            compruebaDireccionProveedor("Modificar");
        }

        /*              Gestión de eventos del textbox del teléfono que modifica el proveedor               */
        private void txtTelefonoMod_TextChanged(object sender, EventArgs e)
        {
            compruebaTelefonoProveedor("Modificar");
        }

        /*         Gestión de eventos del botón que limpia los controles de edición de proveedor.          */
        private void btnLimpiarMod_Click(object sender, EventArgs e)
        {
            inicializaDatos("Modificar");
        }

        private void btnLimpiarMod_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnLimpiarMod_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        /*              Gestión de eventos del botón que realiza la modificación del cliente.             */
        private void botonModificar_Click(object sender, EventArgs e)
        {
            if(cifCorrMod && nomCorrMod && locCorrMod && dirCorrMod && tipCorrMod && telCorrMod)
            {
                try
                {
                    string nombreMod = txtNombreMod.Text;
                    int tipoMod = int.Parse(tipoProvMod.Value.ToString());
                    string localidadMod = txtLocalidadMod.Text;
                    string direccionMod = txtDireccionMod.Text;
                    string telefonoMod = txtTelefonoMod.Text;

                    string sql = "UPDATE Proveedor SET nombre='" + nombreMod + "', tipoProveedor=" + tipoMod + ", localidad='" + localidadMod + "', direccion='" + direccionMod + "', telefono='" + telefonoMod + "' WHERE cif='" + cbIDProveedor.Text + "'";
                    SqlConnection cnx = new SqlConnection(conection);

                    cnx.Open();
                    SqlCommand command = new SqlCommand(sql, cnx);
                    command.ExecuteNonQuery();

                    FormNotificaciones form = new FormNotificaciones("Proveedor modificado correctamente.");
                    form.Show();

                    rellenaTablaProveedores();
                    inicializaDatos("Modificar");
                } 
                catch(Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
        }

        private void botonModificar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void botonModificar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           ELEMENTOS DEL SUBPANEL QUE BORRA UN PROVEEDOR                         */
        /*-------------------------------------------------------------------------------------------------*/
        /*                   Gestión de eventos del combobox del cif de proveedor a borrar                 */
        private void cbIDProvBorr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIDProvBorr.SelectedIndex != 0)
            {
                lbErrorIDProv.Text = "";
                lbErrorIDProv.Visible = false;

                idCorrBorr = true;
            }
            else
            {
                lbErrorIDProv.Text = "Selecciona un proveedor.";
                lbErrorIDProv.Visible = true;

                idCorrBorr = false;
            }
        }


        /*     Gestión de eventos del botón que abre el panel de confirmación de borrado de proveedor      */
        private void btnAceptarBorrar_Click(object sender, EventArgs e)
        {
            if (idCorrBorr)
            {
                panelConfBorrProv.Visible = true;
            }
        }

        private void btnAceptarBorrar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAceptarBorrar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*              Gestión de eventos del botón sí del panel de confirmación de borrado               */
        private void btnSiBorr_Click(object sender, EventArgs e)
        {
            try
            {
                string proveedor = cbIDProvBorr.Text;

                string sql = "DELETE FROM Proveedor WHERE cif='" + proveedor + "'";
                SqlConnection cnx = new SqlConnection(conection);

                cnx.Open();
                SqlCommand command = new SqlCommand(sql, cnx);
                command.ExecuteNonQuery();

                FormNotificaciones form = new FormNotificaciones("Proveedor borrado correctamente.");
                form.Show();

                panelConfBorrProv.Visible = false;

                rellenaComboBoxCIFProveedor();
                inicializaDatos("Borrar");
                rellenaTablaProveedores();
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void btnSiBorr_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnSiBorr_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*              Gestión de eventos del botón no del panel de confirmación de borrado               */
        private void btnNoBorr_Click(object sender, EventArgs e)
        {
            panelConfBorrProv.Visible = false;
        }

        private void btnNoBorr_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnNoBorr_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           ELEMENTOS DEL PANEL DERECHO DE LOS PROVEEDORES                        */
        /*-------------------------------------------------------------------------------------------------*/
        /*           Gestión de eventos del textbox que filtra el datagridview de los proveedores          */
        private void txtFiltroPro_TextChanged(object sender, EventArgs e)
        {
            filtroDatos();
        }

        /*          Gestión de eventos del picturebox que limpia el textbox del filtro de la tabla         */
        private void imgLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroPro.Text = "";
            cbDatosPro.SelectedIndex = 0;
        }

        private void imgLimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void imgLimpiar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                                   MÉTODOS USADOS EN EL FORMULARIO                               */
        /*-------------------------------------------------------------------------------------------------*/
        private void generaXML()
        {
            try
            {
                string sql = "SELECT * FROM Proveedor";
                SqlConnection cnx = new SqlConnection(conection);

                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                if (!System.IO.File.Exists("Proveedores.xml"))
                {
                    XmlWriter listProv = XmlWriter.Create("Proveedores.xml");
                    listProv.WriteStartDocument();
                    listProv.WriteStartElement("Proveedores");

                    while (lector.Read())
                    {
                        listProv.WriteStartElement("Proveedor");

                        listProv.WriteStartElement("CIF");
                        listProv.WriteValue((lector.GetString(0)));
                        listProv.WriteEndElement();

                        listProv.WriteStartElement("Nombre");
                        listProv.WriteValue((lector.GetString(1)));
                        listProv.WriteEndElement();

                        listProv.WriteStartElement("TipoProveedor");
                        listProv.WriteValue(lector.GetInt32(2));
                        listProv.WriteEndElement();

                        listProv.WriteStartElement("FechaRegistro");
                        listProv.WriteValue((lector.GetDateTime(3)));
                        listProv.WriteEndElement();

                        listProv.WriteStartElement("Localidad");
                        listProv.WriteValue((lector.GetString(4)));
                        listProv.WriteEndElement();

                        listProv.WriteStartElement("Direccion");
                        listProv.WriteString((lector.GetString(5)));
                        listProv.WriteEndElement();

                        listProv.WriteStartElement("Telefono");
                        listProv.WriteValue((lector.GetString(6)));
                        listProv.WriteEndElement();

                        listProv.WriteEndElement();
                    }

                    listProv.WriteEndElement();
                    listProv.WriteEndDocument();
                    listProv.Close();

                    FormNotificaciones form = new FormNotificaciones("XML generado correctamente.");
                    form.Show();

                    cnx.Close();
                }
                else
                {
                    FormNotificaciones form2 = new FormNotificaciones("Ya hay un documento XML de Proveedores. Muévelo o cambialo de nombre para poder generar otro.");
                    form2.Show();
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void compruebaXML()
        {
            nodosXML.Clear();

            try
            {
                OpenFileDialog buscador = new OpenFileDialog();
                buscador.Filter = "Archivos XML | *.xml";
                buscador.FileName = "";
                buscador.Title = "Cargar archivo xml";
                buscador.InitialDirectory = "C:\\";

                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    string nombre = buscador.FileName;

                    XmlDocument doc = new XmlDocument();
                    doc.Load(nombre);

                    foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
                    {
                        if (n1.HasChildNodes)
                        {
                            foreach (XmlNode n2 in n1.ChildNodes)
                            {
                                if (n2.Name.Equals("ID") || n2.Name.Equals("Nombre") || n2.Name.Equals("TipoProveedor") || n2.Name.Equals("FechaRegistro")
                                    || n2.Name.Equals("Localidad") || n2.Name.Equals("Direccion") || n2.Name.Equals("Telefono"))
                                {
                                    if (!nodosXML.Contains(n2.Name))
                                    {
                                        nodosXML.Add(n2.Name);
                                    }
                                }
                            }
                        }
                    }

                    if (nodosXML.Count == 7)
                    {
                        /* Redirige al formulario de lectura XML. */
                        FormListarProveedores form = new FormListarProveedores(nombre);
                        form.Show();
                    }
                    else
                    {
                        FormNotificaciones form = new FormNotificaciones("Error, XML incorrecto.");
                        form.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void generaJSON()
        {
            try
            {
                List<Proveedor> listaProveedores = new List<Proveedor>();
                string sql = "SELECT * FROM Proveedor";
                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    Proveedor p = new Proveedor(lector.GetString(0), lector.GetString(1), lector.GetInt32(2), lector.GetDateTime(3),
                        lector.GetString(4), lector.GetString(5), lector.GetString(6));
                    listaProveedores.Add(p);
                }

                if (!File.Exists("Proveedores.json"))
                {
                    string jsonProv = JsonConvert.SerializeObject(listaProveedores.ToArray(), Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText("Proveedores.json", jsonProv);

                    FormNotificaciones form = new FormNotificaciones("JSON generado correctamente.");
                    form.Show();
                }
                else
                {
                    FormNotificaciones form2 = new FormNotificaciones("Ya hay un documento JSON de Proveedores. Muévelo o cambialo de nombre para poder generar otro.");
                    form2.Show();
                }

                cnx.Close();
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void compruebaJSON()
        {
            try
            {
                OpenFileDialog buscador = new OpenFileDialog();
                buscador.Filter = "Archivos JSON | *.json";
                buscador.FileName = "";
                buscador.Title = "Cargar archivo json";
                buscador.InitialDirectory = "C:\\";

                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    string ruta = buscador.FileName;

                    JsonSerializer serializer = new JsonSerializer();
                    List<Proveedor> listaProv = new List<Proveedor>();

                    using (var streamReader = new StreamReader(ruta))
                    using (var textReader = new JsonTextReader(streamReader))
                    {
                        listaProv = serializer.Deserialize<List<Proveedor>>(textReader);
                    }

                    FormListarProveedores form = new FormListarProveedores(proveedoresJSON, listaProv);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void generaExcel()
        {
            try
            {
                List<Proveedor> listaProveedores = new List<Proveedor>();
                string sql = "SELECT * FROM Proveedor";
                string ruta = AppDomain.CurrentDomain.BaseDirectory + "Proveedores.xlsx";
                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    Proveedor p = new Proveedor(lector.GetString(0), lector.GetString(1), lector.GetInt32(2), lector.GetDateTime(3),
                        lector.GetString(4), lector.GetString(5), lector.GetString(6));
                    listaProveedores.Add(p);
                }

                if (!File.Exists(ruta))
                {
                    SLDocument excel = new SLDocument();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID", typeof(string));
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Columns.Add("Tipo Proveedor", typeof(int));
                    dt.Columns.Add("Fecha Registro", typeof(string));
                    dt.Columns.Add("Localidad", typeof(string));
                    dt.Columns.Add("Direccion", typeof(string));
                    dt.Columns.Add("Telefono", typeof(string));

                    foreach (Proveedor proveedor in listaProveedores)
                    {
                        dt.Rows.Add(proveedor.ID, proveedor.Nombre, proveedor.TipoProveedor, proveedor.FechaRegistro, proveedor.Localidad, proveedor.Direccion, proveedor.Telefono);
                    }

                    excel.ImportDataTable(1, 1, dt, true);
                    excel.SaveAs(ruta);

                    FormNotificaciones form = new FormNotificaciones("Excel generado correctamente.");
                    form.Show();
                }
                else
                {
                    FormNotificaciones form = new FormNotificaciones("Ya existe un excel de Proveedores con ese nombre.");
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void compruebaExcel()
        {
            try
            {
                OpenFileDialog buscador = new OpenFileDialog();
                buscador.Filter = "Archivos EXCEL | *.xlsx";
                buscador.FileName = "";
                buscador.Title = "Cargar archivo excel";
                buscador.InitialDirectory = "C:\\";

                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    List<Proveedor> proveedoresExcel = new List<Proveedor>();
                    string ruta = buscador.FileName;

                    SLDocument sl = new SLDocument(ruta);
                    int numFila = 1;

                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(numFila, 1)))
                    {
                        if (numFila != 1)
                        {
                            string id = sl.GetCellValueAsString(numFila, 1);
                            string nombre = sl.GetCellValueAsString(numFila, 2);
                            int tipoProveedor = sl.GetCellValueAsInt32(numFila, 3);
                            DateTime fecha = sl.GetCellValueAsDateTime(numFila, 4);
                            string localidad = sl.GetCellValueAsString(numFila, 5);
                            string direccion = sl.GetCellValueAsString(numFila, 6);
                            string telefono = sl.GetCellValueAsString(numFila, 7);

                            Proveedor p = new Proveedor(id, nombre, tipoProveedor, fecha, localidad, direccion, telefono);
                            proveedoresExcel.Add(p);
                        }
                        numFila++;
                    }

                    FormListarProveedores form = new FormListarProveedores(proveedoresExcel);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void inicializaDatos(string opcion)
        {
            switch (opcion)
            {
                case "Añadir":
                    txtCIF.Text = "";
                    txtNombreProv.Text = "";
                    tipoProv.Value = 0;
                    txtLocalidad.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    break;
                case "Modificar":
                    cbIDProveedor.Text = "";
                    txtNombreMod.Text = "";
                    tipoProvMod.Value = 0;
                    txtLocalidadMod.Text = "";
                    txtDireccionMod.Text = "";
                    txtTelefonoMod.Text = "";
                    break;
                case "Borrar":
                    cbIDProvBorr.SelectedIndex = 0;
                    break;
            }
        }

        private void compruebaCIFProveedor()
        {
            string cif = txtCIF.Text.ToString();

            if (cif.Length != 9)
            {
                lbCIF.ForeColor = Color.Red;

                lbErrorCIF.Text = "CIF Inválido.";
                lbErrorCIF.Visible = true;

                cifCorr = false;
            }
            else if (cif.Length == 9 && !cif.Equals("CIF"))
            {
                if (Char.IsLetter(cif, 0))
                {
                    string sql = "SELECT * FROM Proveedor";

                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    while (lector.Read())
                    {
                        if (lector.GetString(0).Equals(cif))
                        {
                            encontrado = true;
                            lbErrorCIF.Text = "El CIF ya se ha usado.";
                            lbErrorCIF.Visible = true;
                            lbCIF.ForeColor = Color.Red;

                            cifCorr = false;
                        }
                        else
                        {
                            encontrado = false;
                            lbErrorCIF.Text = "";
                            lbErrorCIF.Visible = false;

                            lbCIF.ForeColor = Color.Green;

                            cifCorr = true;
                        }
                    }
                }
                else
                {
                    lbCIF.ForeColor = Color.Red;

                    lbErrorCIF.Text = "CIF Inválido.";
                    lbErrorCIF.Visible = true;

                    cifCorr = false;
                }
            }
        }

        private void compruebaNombreProveedor(string opcion)
        {
            switch (opcion)
            {
                case "Añadir":
                    string nombre = txtNombreProv.Text.ToString();

                    if (nombre.Length == 0 || nombre.Length > 50)
                    {
                        lbErrorNom.Visible = true;
                        lbNombre.ForeColor = Color.Red;

                        if (nombre.Length == 0)
                        {
                            lbErrorNom.Text = "El nombre no puede estar vacío.";
                        }
                        else if (nombre.Length > 50)
                        {
                            lbErrorNom.Text = "El nombre es demasiado largo.";
                        }

                        nomCorr = false;
                    }
                    else if (nombre.Length > 0 && !nombre.Equals("Nombre"))
                    {
                        string sql = "SELECT * FROM Proveedor";

                        SqlConnection cnx = new SqlConnection(conection);
                        cnx.Open();

                        SqlCommand command = new SqlCommand(sql, cnx);
                        SqlDataReader lector = command.ExecuteReader();

                        while (lector.Read())
                        {
                            if (lector.GetString(1).Equals(nombre))
                            {
                                encontrado = true;
                                lbErrorNom.Text = "El nombre ya se ha usado.";
                                lbErrorNom.Visible = true;

                                lbNombre.ForeColor = Color.Red;

                                nomCorr = false;
                            }
                            else
                            {
                                encontrado = false;
                                lbErrorNom.Text = "";
                                lbErrorNom.Visible = false;

                                lbNombre.ForeColor = Color.Green;

                                nomCorr = true;
                            }
                        }
                    }
                    else if (nombre.Equals("Nombre"))
                    {
                        lbErrorNom.Text = "";
                        lbErrorNom.Visible = false;
                        lbNombre.ForeColor = Color.Black;
                        nomCorr = false;
                    }
                    break;
                case "Modificar":
                    string nombreMod = txtNombreMod.Text.ToString();

                    if (nombreMod.Length == 0 || nombreMod.Length > 50)
                    {
                        lbErrorNombreMod.Visible = true;
                        lbNombreMod.ForeColor = Color.Red;

                        if (nombreMod.Length == 0)
                        {
                            lbErrorNombreMod.Text = "El nombre no puede estar vacío.";
                        }
                        else if (nombreMod.Length > 50)
                        {
                            lbErrorNombreMod.Text = "El nombre es demasiado largo.";
                        }

                        nomCorrMod = false;
                    }
                    else if (nombreMod.Length > 0 && !nombreMod.Equals("Nombre"))
                    {
                        lbErrorNombreMod.Text = "";
                        lbErrorNombreMod.Visible = false;
                        lbNombreMod.ForeColor = Color.Green;
                        nomCorrMod = true;
                    }
                    break;
            }
        }

        private void compruebaLocalidadProveedor(string opcion)
        {
            switch (opcion)
            {
                case "Añadir":
                    string localidad = txtLocalidad.Text.ToString();

                    if (localidad.Length == 0 || localidad.Length > 100)
                    {
                        lbErrorLocalidad.Visible = true;
                        lbLocalidad.ForeColor = Color.Red;

                        if (localidad.Length == 0)
                        {
                            lbErrorLocalidad.Text = "Introduce una localidad.";
                        }
                        else if (localidad.Length > 100)
                        {
                            lbErrorLocalidad.Text = "Localidad demasiado larga.";
                        }

                        locCorr = false;
                    }
                    else if (localidad.Length > 0 && !localidad.Equals("Localidad"))
                    {
                        lbErrorLocalidad.Text = "";
                        lbErrorLocalidad.Visible = false;

                        lbLocalidad.ForeColor = Color.Green;

                        locCorr = true;
                    }
                    else if (localidad.Equals("Localidad"))
                    {
                        lbErrorLocalidad.Text = "";
                        lbErrorLocalidad.Visible = false;
                        lbLocalidad.ForeColor = Color.Black;
                        locCorr = false;
                    }
                    break;
                case "Modificar":
                    string localidadMod = txtLocalidadMod.Text.ToString();

                    if (localidadMod.Length == 0 || localidadMod.Length > 100)
                    {
                        lbErrorLocalidadMod.Visible = true;
                        lbLocalidadMod.ForeColor = Color.Red;

                        if (localidadMod.Length == 0)
                        {
                            lbErrorLocalidadMod.Text = "Introduce una localidad.";
                        }
                        else if (localidadMod.Length > 100)
                        {
                            lbErrorLocalidadMod.Text = "Localidad demasiado larga.";
                        }

                        locCorrMod = false;
                    }
                    else if (localidadMod.Length > 0 && !localidadMod.Equals("Localidad"))
                    {
                        lbErrorLocalidadMod.Text = "";
                        lbErrorLocalidadMod.Visible = false;
                        lbLocalidadMod.ForeColor = Color.Green;
                        locCorrMod = true;
                    }
                    break;
            }
        }

        private void compruebaDireccionProveedor(string opcion)
        {
            switch (opcion)
            {
                case "Añadir":
                    string direccion = txtDireccion.Text.ToString();

                    if (direccion.Length == 0 || direccion.Length > 200)
                    {
                        lbErrorDireccion.Visible = true;
                        lbDireccion.ForeColor = Color.Red;

                        if (direccion.Length == 0)
                        {
                            lbErrorDireccion.Text = "Introduce una dirección.";
                        }
                        else if (direccion.Length > 200)
                        {
                            lbErrorDireccion.Text = "Dirección demasiado larga.";
                        }

                        dirCorr = false;
                    }
                    else if (direccion.Length > 0 && !direccion.Equals("Direccion"))
                    {
                        lbErrorDireccion.Text = "";
                        lbErrorDireccion.Visible = false;

                        lbDireccion.ForeColor = Color.Green;

                        dirCorr = true;
                    }
                    else if (direccion.Equals("Direccion"))
                    {
                        lbErrorDireccion.Text = "";
                        lbErrorDireccion.Visible = false;
                        lbDireccion.ForeColor = Color.Black;
                        dirCorr = false;
                    }
                    break;
                case "Modificar":
                    string direccionMod = txtDireccionMod.Text.ToString();

                    if (direccionMod.Length == 0 || direccionMod.Length > 200)
                    {
                        lbErrorDireccionMod.Visible = true;
                        lbDireccionMod.ForeColor = Color.Red;

                        if (direccionMod.Length == 0)
                        {
                            lbErrorDireccionMod.Text = "Introduce una dirección.";
                        }
                        else if (direccionMod.Length > 200)
                        {
                            lbErrorDireccionMod.Text = "Dirección demasiado larga.";
                        }

                        dirCorrMod = false;
                    }
                    else if (direccionMod.Length > 0 && !direccionMod.Equals("Direccion"))
                    {
                        lbErrorDireccionMod.Text = "";
                        lbErrorDireccionMod.Visible = false;
                        lbDireccionMod.ForeColor = Color.Green;
                        dirCorrMod = true;
                    }
                    break;
            }
        }

        private void compruebaTelefonoProveedor(string opcion)
        {
            switch (opcion)
            {
                case "Añadir":
                    string t = txtTelefono.Text.ToString();
                    int contador = 0;

                    for (int i = 0; i < t.Length; i++)
                    {
                        if (Char.IsNumber(t, i))
                        {
                            contador++;
                        }
                    }

                    if (t.Length != 9)
                    {
                        if (contador != 9)
                        {
                            lbTelefono.ForeColor = Color.Red;
                            lbErrorTelefono.Visible = true;

                            lbErrorTelefono.Text = "Teléfono Inválido.";

                            telCorr = false;
                        }
                    }
                    else if (t.Length == 9 && contador == 9 && !t.Equals("Telefono"))
                    {
                        lbTelefono.ForeColor = Color.Green;

                        lbErrorTelefono.Visible = false;
                        lbErrorTelefono.Text = "";

                        telCorr = true;
                    }
                    else if (txtTelefono.Text.Equals("Telefono"))
                    {
                        lbTelefono.ForeColor = Color.Black;

                        lbErrorTelefono.Visible = false;
                        lbErrorTelefono.Text = "";

                        telCorr = false;
                    }
                    break;
                case "Modificar":
                    string tMod = txtTelefonoMod.Text.ToString();
                    int contadorMod = 0;

                    for (int i = 0; i < tMod.Length; i++)
                    {
                        if (Char.IsNumber(tMod, i))
                        {
                            contadorMod++;
                        }
                    }

                    if (tMod.Length != 9)
                    {
                        if (contadorMod != 9)
                        {
                            lbTelefonoMod.ForeColor = Color.Red;
                            lbErrorTelefonoMod.Visible = true;

                            lbErrorTelefonoMod.Text = "Teléfono Inválido.";

                            telCorrMod = false;
                        }
                    }
                    else if (tMod.Length == 9 && contadorMod == 9 && !tMod.Equals("Telefono"))
                    {
                        lbTelefonoMod.ForeColor = Color.Green;

                        lbErrorTelefonoMod.Visible = false;
                        lbErrorTelefonoMod.Text = "";

                        telCorrMod = true;
                    }
                    else if (tMod.Equals("Telefono"))
                    {
                        lbTelefonoMod.ForeColor = Color.Black;

                        lbErrorTelefonoMod.Visible = false;
                        lbErrorTelefonoMod.Text = "";

                        telCorrMod = false;
                    }
                    break;
            }
        }

        private void compruebaProveedores()
        {
            if (cbIDProveedor.SelectedIndex != 0)
            {
                try
                {
                    string sql = "SELECT * FROM Proveedor WHERE cif='" + cbIDProveedor.Text + "'";
                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    while (lector.Read())
                    {
                        txtNombreMod.Text = lector.GetString(1);
                        tipoProvMod.Value = lector.GetInt32(2);
                        txtLocalidadMod.Text = lector.GetString(4);
                        txtDireccionMod.Text = lector.GetString(5);
                        txtTelefonoMod.Text = lector.GetString(6);
                    }

                    txtNombreMod.Enabled = true;
                    tipoProvMod.Enabled = true;
                    txtLocalidadMod.Enabled = true;
                    txtDireccionMod.Enabled = true;
                    txtTelefonoMod.Enabled = true;

                    cifCorrMod = true;

                    command.Dispose();
                    cnx.Close();

                }
                catch (Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
            else
            {
                txtNombreMod.Enabled = false;
                txtNombreMod.Text = "";

                txtLocalidadMod.Enabled = false;
                txtLocalidadMod.Text = "";

                txtDireccionMod.Enabled = false;
                txtDireccionMod.Text = "";

                txtTelefonoMod.Enabled = false;
                txtTelefonoMod.Text = "";

                cifCorrMod = false;
            }
        }

        private void rellenaTablaProveedores()
        {
            string sql = "SELECT * FROM Proveedor";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(lector);
                dgvProveedores.DataSource = dt;

                foreach (DataGridViewColumn col in dgvProveedores.Columns)
                {
                    col.HeaderText = col.HeaderText.ToUpper();
                }

                command.Dispose();
                cnx.Close();
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void rellenaComboBoxCIFProveedor()
        {
            cbIDProveedor.Items.Clear();
            cbIDProveedor.Items.Add(" ");

            cbIDProvBorr.Items.Clear();
            cbIDProvBorr.Items.Add(" ");

            string sql = "SELECT * FROM Proveedor";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    cbIDProveedor.Items.Add(lector.GetString(0));
                    cbIDProvBorr.Items.Add(lector.GetString(0));
                }

                cnx.Close();
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }


        private void rellenaCbDatosProveedores()
        {
            cbDatosPro.Items.Add("");

            foreach (DataGridViewColumn col in dgvProveedores.Columns)
            {
                cbDatosPro.Items.Add(col.HeaderText);
            }

            cbDatosPro.SelectedIndex = 0;
        }

        private void filtroDatos()
        {
            if (cbDatosPro.SelectedIndex != 0)
            {
                try
                {
                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    string sql = "SELECT * FROM Proveedor WHERE " + cbDatosPro.Text + " LIKE '%' + @filtro + '%'";
                    SqlCommand command = new SqlCommand(sql, cnx);
                    command.Parameters.AddWithValue("@filtro", txtFiltroPro.Text);

                    SqlDataReader lector = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(lector);
                    dgvProveedores.DataSource = dt;

                    command.Dispose();
                    cnx.Close();
                }
                catch (Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
        }
    }
}
