using Newtonsoft.Json;
using Spaniac.Clases;
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
using System.Xml.Linq;

namespace Spaniac.Formularios.Internos.Almacenes
{
    public partial class FormAlmacenes : Form
    {
        /* Ruta de conexión para la BD. */
        static string conection = "server=localhost; database=Spaniac; integrated security=true";

        /* Variables booleanas estáticas que controlan si los paneles están visibles o no. */
        static bool pExcel = false, pJson = false, pXml = false;

        /* Variables booleanas que controlan si los datos del almacén están rellenos para realizar la inserción. */
        bool nomAlm = false, actAlm = false;

        /* Variables booleanas sque controlan si los datos del almacén están completos para realizar la modificación. */
        bool idAlmMod = false, nomAlmMod = false, actAlmMod = false;

        /* Variables booleanas sque controlan si los datos del almacén están completos para realizar la eliminación. */
        bool idAlmBorr = false;

        /* Determina si se ha encontrado el almacen u otro dato importante en la base de datos previamente registrado. */
        static bool encontrado = false;

        /* Listas. */
        static List<string> nodosXML = new List<string>();

        /* Listas que proporcionan los datos XML de todos los IDS, activos y nombres de los almacenes del archivo XML cargado. */
        static List<string> idsXML = new List<string>();
        static List<string> activosXML = new List<string>();
        static List<string> nombresXML = new List<string>();

        /* Variable cadena que almacena el JSON cargado. */
        static string almacenesJSON;


        /* Variables enteras que controlan el estado del almacen en la opción de añadir almacén y modificar almacén. */
        static int estadoEscogido;
        static int estadoEscogidoMod;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormAlmacenes()
        {
            InitializeComponent();
            inicializarControles();

            rellenaTablaAlmacenes();
            rellenaCbDatosAlmacen();
            rellenaComboBoxIDAlm();
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
            if(pXml == false)
            {
                panelMenuXml.Visible = true;
                pXml = true;
            } else
            {
                panelMenuXml.Visible = false;
                pXml = false;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           GESTIÓN DE EVENTOS DEL BOTÓN DEL MENÚ JSON                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnMenuJSON_Click(object sender, EventArgs e)
        {
            if(pJson == false)
            {
                panelMenuJSON.Visible = true;
                pJson = true;
            } else
            {
                panelMenuJSON.Visible = false;
                pJson = false;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           ELEMENTOS DEL PANEL IZQUIERDO DE AlMACENES                            */
        /*-------------------------------------------------------------------------------------------------*/
        /*              Gestión de eventos del botón que abre el panel para añadir una almacén.            */
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            panelAñadirAlmacen.Visible = true;
            panelModificarAlmacen.Visible = false;
            panelBorrarAlmacen.Visible = false;
            panelPortada.Visible = false;
            inicializaDatos();
        }

        private void btnAñadir_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAñadir_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*            Gestión de eventos del botón que abre el panel para modificar una almacén.           */
        private void btnModificar_Click(object sender, EventArgs e)
        {
            panelModificarAlmacen.Visible = true;
            panelAñadirAlmacen.Visible = false;
            panelBorrarAlmacen.Visible = false;
            panelPortada.Visible = false;
            inicializaDatos();
        }

        private void btnModificar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*            Gestión de eventos del botón que abre el panel para borrar una almacén.           */
        private void btnBorra_Click(object sender, EventArgs e)
        {
            panelBorrarAlmacen.Visible = true;
            panelModificarAlmacen.Visible = false;
            panelAñadirAlmacen.Visible = false;
            panelPortada.Visible = false;
            inicializaDatos();
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
        /*                            ELEMENTOS DEL SUBPANEL QUE AÑADE UN ALMACEN                          */
        /*-------------------------------------------------------------------------------------------------*/
        /*                  Gestión de eventos del textbox del nombre del almacen a añadir                 */
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text.Equals("Nombre"))
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text.Equals(""))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DarkGray;
                lbNombre.ForeColor = Color.Black;
                lbErrorNom.Text = "";
                lbErrorNom.Visible = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            compruebaNombreAlmacen("Añadir");
        }


        /*               Gestión de eventos de los checkbox del estado del almacén a añadir                */
        private void cbAct1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAct1.Checked || cbAct2.Checked)
            {
                lbErrorEstado.Text = "";
                lbErrorEstado.Visible = false;

                actAlm = true;
            }

            if(cbAct1.Checked)
            {
                cbAct2.Checked = false;
                /* 1 significa que el almacén está activo. */
                estadoEscogido = 1;
            }

            if (!cbAct1.Checked && !cbAct2.Checked)
            {
                lbErrorEstado.Text = "Selecciona si el almacén está activo o inactivo.";
                lbErrorEstado.Visible = true;

                actAlm = false;
            }
        }

        private void cbAct2_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAct1.Checked || cbAct2.Checked)
            {
                lbErrorEstado.Text = "";
                lbErrorEstado.Visible = false;

                actAlm = true;
            }

            if(cbAct2.Checked)
            {
                cbAct1.Checked = false;
                /* 0 significa que el almacén está inactivo. */
                estadoEscogido = 0;
            }

            if(!cbAct1.Checked && !cbAct2.Checked)
            {
                lbErrorEstado.Text = "Selecciona si el almacén está activo o inactivo.";
                lbErrorEstado.Visible = true;

                actAlm = false;
            }
        }


        /*  Gestión de eventos del botón que comprueba si todos los datos son correctos y añade un almacén  */
        private void btnAceptarAAdd_Click(object sender, EventArgs e)
        {
            if(nomAlm && actAlm)
            {
                DatosAlmacen datosNuevoAlm = new DatosAlmacen();
                datosNuevoAlm.Nombre = txtNombre.Text.ToString();
                datosNuevoAlm.Activo = estadoEscogido;
                datosNuevoAlm.guardarCambios();

                txtNombre.Text = "";
                cbAct1.Checked = false;
                cbAct2.Checked = false;
                lbErrorEstado.Text = "Selecciona si el almacén está activo o inactivo.";

                FormNotificaciones form = new FormNotificaciones("Almacen registrado correctamente.");
                form.Show();

                rellenaTablaAlmacenes();
                rellenaComboBoxIDAlm();
                inicializaDatos();
            }
        }

        private void btnAceptarAAdd_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAceptarAAdd_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                       ELEMENTOS DEL SUBPANEL QUE MODIFICA UN ALMACÉN                            */
        /*-------------------------------------------------------------------------------------------------*/
        /*         Gestión de eventos del combobox que selecciona el ID del almacén a modificar.           */
        private void cbIDAMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIDAMod.SelectedIndex != 0)
            {
                try
                {
                    string sql = "SELECT * FROM Almacen WHERE id=" + int.Parse(cbIDAMod.Text);
                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    while(lector.Read())
                    {
                        txtNombreAMod.Text = lector.GetString(2);
                        bool est = lector.GetBoolean(1);

                        if (est == false)
                        {
                            cbAct2Mod.Checked = true;
                        }
                        else
                        {
                            cbAct1Mod.Checked = true;
                        }
                    }

                    txtNombreAMod.Enabled = true;
                    cbAct1Mod.Enabled = true;
                    cbAct2Mod.Enabled = true;

                    lbErrorIDAMod.Text = "";
                    lbErrorIDAMod.Visible = false;

                    idAlmMod = true;

                    command.Dispose();
                    cnx.Close();

                }
                catch (Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            } else
            {
                txtNombreAMod.Enabled = true;
                txtNombreAMod.Text = "";

                cbAct1Mod.Enabled = false;
                cbAct2Mod.Enabled = false;

                lbErrorIDAMod.Text = "Selecciona un almacén a modificar.";
                lbErrorIDAMod.Visible = true;

                idAlmMod = false;
            }
        }

        /*                   Gestión de eventos del textbox de nombre que modifica el almacén            */
        private void txtNombreAMod_TextChanged(object sender, EventArgs e)
        {
            compruebaNombreAlmacen("Modificar");
        }

        /*               Gestión de eventos de los checkbox del estado del almacén a modificar.          */
        private void cbAct1Mod_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAct1Mod.Checked || cbAct2Mod.Checked)
            {
                lbErrorEstadoMod.Text = "";
                lbErrorEstadoMod.Visible = false;

                actAlmMod = true;
            }

            if (cbAct1Mod.Checked)
            {
                cbAct2Mod.Checked = false;
                /* 1 significa que el almacén está activo. */
                estadoEscogidoMod = 1;
            }

            if (!cbAct1Mod.Checked && !cbAct2Mod.Checked)
            {
                lbErrorEstadoMod.Text = "Selecciona si el almacén está activo o inactivo.";
                lbErrorEstadoMod.Visible = true;

                actAlm = false;
            }
        }

        private void cbAct2Mod_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAct1Mod.Checked || cbAct2Mod.Checked)
            {
                lbErrorEstadoMod.Text = "";
                lbErrorEstadoMod.Visible = false;

                actAlmMod = true;
            }

            if (cbAct2Mod.Checked)
            {
                cbAct1Mod.Checked = false;
                /* 0 significa que el almacén está inactivo. */
                estadoEscogidoMod = 0;
            }

            if (!cbAct1Mod.Checked && !cbAct2Mod.Checked)
            {
                lbErrorEstadoMod.Text = "Selecciona si el almacén está activo o inactivo.";
                lbErrorEstadoMod.Visible = true;

                actAlmMod = false;
            }
        }


        /*             Gestión de eventos del botón limpiar datos de la modificación del almacén.          */
        private void btnLimpiarMod_Click(object sender, EventArgs e)
        {
            cbIDAMod.SelectedIndex = 0;
            txtNombreAMod.Text = "";
            cbAct1Mod.Checked = false;
            cbAct2Mod.Checked = false;
        }

        private void btnLimpiarMod_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnLimpiarMod_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*           Gestión de eventos del botón que acepta la modificación de la categoría               */
        private void btnGuardarMod_Click(object sender, EventArgs e)
        {
            if(idAlmMod && nomAlmMod && actAlmMod)
            {
                try
                {
                    string nombreMod = txtNombreAMod.Text;
                    int estadoMod = estadoEscogidoMod;

                    string sql = "UPDATE Almacen SET nombre='" + nombreMod + "', activo=" + estadoMod + "WHERE id=" + cbIDAMod.SelectedIndex;
                    SqlConnection cnx = new SqlConnection(conection);

                    cnx.Open();
                    SqlCommand command = new SqlCommand(sql, cnx);
                    command.ExecuteNonQuery();

                    FormNotificaciones form = new FormNotificaciones("Almacen modificado correctamente.");
                    form.Show();

                    rellenaTablaAlmacenes();
                } catch(Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
        }

        private void btnGuardarMod_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnGuardarMod_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                        ELEMENTOS DEL SUBPANEL QUE ELIMINA UN ALMACÉN                            */
        /*-------------------------------------------------------------------------------------------------*/
        /*          Gestión de eventos del combobox que selecciona el ID del almacén a eliminar.           */
        private void cbIDABorr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIDABorr.SelectedIndex != 0)
            {
                try
                {
                    int contProductos = 0;
                    string sql = "SELECT * FROM Producto WHERE idAlmacen=" + cbIDABorr.SelectedIndex;
                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    while(lector.Read())
                    {
                        contProductos++;
                    }

                    if(contProductos == 0)
                    {
                        lbErrorIDABorr.Text = "";
                        lbErrorIDABorr.Visible = false;

                        idAlmBorr = true;
                    } else
                    {
                        lbErrorIDABorr.Text = "Este almacén tiene productos asociados.";
                        lbErrorIDABorr.Visible = true;

                        idAlmBorr = false;
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
            else
            { 
                lbErrorIDABorr.Text = "Selecciona un ID para buscar almacén.";
                lbErrorIDABorr.Visible = true;

                idAlmBorr = false;
            }
        }


        /*       Gestión de eventos del botón que abre el panel de confirmación de borrado de almacén      */
        private void btnAceptarBorrar_Click(object sender, EventArgs e)
        {
            if(idAlmBorr)
            {
                panelConfBorr.Visible = true;
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
                int almacen = cbIDABorr.SelectedIndex;

                string sql = "DELETE FROM Almacen WHERE id=" + almacen;
                SqlConnection cnx = new SqlConnection(conection);

                cnx.Open();
                SqlCommand command = new SqlCommand(sql, cnx);
                command.ExecuteNonQuery();

                FormNotificaciones form = new FormNotificaciones("Almacén borrado correctamente.");
                form.Show();

                panelConfBorr.Visible = false;

                rellenaTablaAlmacenes();
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
            panelConfBorr.Visible = false;
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
        /*                           ELEMENTOS DEL PANEL DERECHO DE LOS ALMACENES                          */
        /*-------------------------------------------------------------------------------------------------*/
        /*            Gestión de eventos del textbox que filtra el datagridview de las almacenes           */
        private void txtFiltroA_TextChanged(object sender, EventArgs e)
        {
            filtroDatos();
        }

        /*          Gestión de eventos del picturebox que limpia el textbox del filtro de la tabla         */
        private void imgLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroA.Text = "";
            cbDatosA.SelectedIndex = 0;
        }

        private void imgLimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void imgLimpiar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        /*                         Gestión de eventos del datagridview de almacenes                        */
        private void dgvAlmacenes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvAlmacenes.Columns[e.ColumnIndex].Name == "activo")
            {
                if(e.Value != null)
                {
                    bool estado = (bool) e.Value;
                    if(estado == false)
                    {
                        e.CellStyle.BackColor = Color.Crimson;
                    } else
                    {
                        e.CellStyle.BackColor = Color.SpringGreen;
                    }
                }
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           GESTIÓN DE EVENTOS DEL BOTÓN DEL MENÚ EXCEL                           */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnMenuExcel_Click(object sender, EventArgs e)
        {
            if(pExcel == false)
            {
                panelMenuExcel.Visible = true;
                pExcel = true;
            } else
            {
                panelMenuExcel.Visible = false;
                pExcel = false;
            }
        }



        /*-------------------------------------------------------------------------------------------------*/
        /*                       ELEMENTOS DEL PANEL CENTRAL DE MENÚS DE ALMACENES                         */
        /*-------------------------------------------------------------------------------------------------*/
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


        /*                    Gestión de eventos del botón generar EXCEL del menú EXCEL                    */
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
            this.Cursor = Cursors.Default;
            btnGenEXCEL.ForeColor = Color.MidnightBlue;
        }


        /*                       Gestión de eventos del botón leer JSON del menú JSON                      */
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
            this.Cursor = Cursors.Default;
            btnListarEXCEL.ForeColor = Color.MidnightBlue;
        }



        /*-------------------------------------------------------------------------------------------------*/
        /*                                 MÉTODOS USADOS EN EL FORMULARIO                                 */
        /*-------------------------------------------------------------------------------------------------*/
        private void inicializarControles()
        {
            panelPortada.Visible = true;
            panelAñadirAlmacen.Visible = false;
            lbErrorEstado.Text = "Selecciona si el almacén está activo o inactivo.";
            lbErrorEstado.Visible = true;

            panelModificarAlmacen.Visible = false;
            lbErrorIDAMod.Text = "Selecciona un almacén a modificar.";
            lbErrorIDAMod.Visible = true;
            txtNombreAMod.Enabled = false;
            cbAct1Mod.Enabled = false;
            cbAct2Mod.Enabled = false;
            lbErrorEstadoMod.Text = "Selecciona si el almacén está activo o inactivo.";
            lbErrorEstadoMod.Visible = true;

            panelBorrarAlmacen.Visible = false;
            lbErrorIDABorr.Text = "Selecciona un almacén a eliminar.";
            lbErrorIDABorr.Visible = true;
            panelConfBorr.Visible = false;
            descBorr.Enabled = false;

            panelMenuExcel.Visible = true;
            panelMenuJSON.Visible = true;
            panelMenuXml.Visible = true;
        }

        private void inicializaDatos()
        {
            txtNombre.Text = "";
            cbAct1.Checked = false;
            cbAct2.Checked = false;

            cbDatosA.SelectedIndex = 0;
            cbIDAMod.SelectedIndex = 0;

            txtNombreAMod.Text = "";
            txtNombreAMod.Enabled = false;
            cbAct1Mod.Checked = false;
            cbAct2Mod.Checked = false;
        }

        private void generaXML()
        {
            try
            {
                string sql = "SELECT * FROM Almacen";
                SqlConnection cnx = new SqlConnection(conection);

                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                string hora = DateTime.Now.ToShortTimeString().ToUpper().Trim();
                string fecha = DateTime.Now.ToShortDateString().ToUpper().Trim() + hora;

                if(!System.IO.File.Exists("Almacenes.xml"))
                {
                    XmlWriter listAlm = XmlWriter.Create("Almacenes.xml");
                    listAlm.WriteStartDocument();
                    listAlm.WriteStartElement("Almacenes");

                    while (lector.Read())
                    {
                        listAlm.WriteStartElement("Almacen");

                        listAlm.WriteStartElement("ID");
                        listAlm.WriteValue((lector.GetInt32(0)));
                        listAlm.WriteEndElement();

                        listAlm.WriteStartElement("Activo");
                        listAlm.WriteValue((lector.GetBoolean(1)));
                        listAlm.WriteEndElement();

                        listAlm.WriteStartElement("Nombre");
                        listAlm.WriteString((lector.GetString(2)));
                        listAlm.WriteEndElement();

                        listAlm.WriteEndElement();
                    }

                    listAlm.WriteEndElement();
                    listAlm.WriteEndDocument();
                    listAlm.Close();

                    FormNotificaciones form = new FormNotificaciones("XML generado correctamente.");
                    form.Show();

                    cnx.Close();
                } else
                {
                    FormNotificaciones form2 = new FormNotificaciones("Ya hay un documento XML. Muévelo o cambialo de nombre para poder generar otro.");
                    form2.Show();
                }    
            } catch(Exception ex) 
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
                                if (n2.Name.Equals("ID") || n2.Name.Equals("Activo") || n2.Name.Equals("Nombre"))
                                {
                                    if (!nodosXML.Contains(n2.Name))
                                    {
                                        nodosXML.Add(n2.Name);
                                    }
                                }
                            }
                        }
                    }

                    if (nodosXML.Count == 3)
                    {
                        /* Redirige al formulario de lectura XML. */
                        FormListarAlmacenes form = new FormListarAlmacenes(nombre);
                        form.Show();
                    }
                    else
                    {
                        FormNotificaciones form = new FormNotificaciones("Error, XML incorrecto.");
                        form.Show();
                    }
                }
            } catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void generaJSON()
        {
            try
            {
                List<Almacen> listaAlmacenes = new List<Almacen>();
                string sql = "SELECT * FROM Almacen";
                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    Almacen a = new Almacen(lector.GetInt32(0), lector.GetBoolean(1), lector.GetString(2));
                    listaAlmacenes.Add(a);
                }

                if (!File.Exists("Almacenes.json"))
                {
                    string jsonAlm = JsonConvert.SerializeObject(listaAlmacenes.ToArray(), Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText("Almacenes.json", jsonAlm);

                    FormNotificaciones form = new FormNotificaciones("JSON generado correctamente.");
                    form.Show();
                }
                else
                {
                    FormNotificaciones form2 = new FormNotificaciones("Ya hay un documento XML. Muévelo o cambialo de nombre para poder generar otro.");
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
                    List<Almacen> listaAlm = new List<Almacen>();

                    using(var streamReader = new StreamReader(ruta)) 
                    using(var textReader = new JsonTextReader(streamReader))
                    {
                        listaAlm = serializer.Deserialize<List<Almacen>>(textReader);
                    }

                    FormListarAlmacenes form = new FormListarAlmacenes(almacenesJSON, listaAlm);
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
                List<Almacen> listaAlmacenes = new List<Almacen>();
                string sql = "SELECT * FROM Almacen";
                string ruta = AppDomain.CurrentDomain.BaseDirectory + "Almacenes.xlsx";
                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    Almacen a = new Almacen(lector.GetInt32(0), lector.GetBoolean(1), lector.GetString(2));
                    listaAlmacenes.Add(a);
                }

                if(!File.Exists(ruta))
                {
                    SLDocument excel = new SLDocument();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Activo", typeof(string));
                    dt.Columns.Add("Nombre", typeof(string));

                    foreach (Almacen almacen in  listaAlmacenes)
                    {
                        dt.Rows.Add(almacen.ID, almacen.Activo.ToString(), almacen.Nombre);
                    }

                    excel.ImportDataTable(1, 1, dt, true);
                    excel.SaveAs(ruta);

                    FormNotificaciones form = new FormNotificaciones("Excel generado correctamente.");
                    form.Show();
                } else
                {
                    FormNotificaciones form = new FormNotificaciones("Ya existe un excel con ese nombre.");
                    form.Show();
                }
            } catch(Exception ex)
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
                    List<Almacen> almacenesExcel = new List<Almacen>();
                    string ruta = buscador.FileName;

                    SLDocument sl = new SLDocument(ruta);
                    int numFila = 1;

                    while(!string.IsNullOrEmpty(sl.GetCellValueAsString(numFila, 1)))
                    {
                        if(numFila != 1)
                        {
                            int id = sl.GetCellValueAsInt32(numFila, 1);
                            string activo = sl.GetCellValueAsString(numFila, 2);
                            string nombre = sl.GetCellValueAsString(numFila, 3);

                            Almacen a = new Almacen(id, bool.Parse(activo), nombre);
                            almacenesExcel.Add(a);
                        }
                        numFila++;
                    }

                    FormListarAlmacenes form = new FormListarAlmacenes(almacenesExcel);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void compruebaNombreAlmacen(string opcion)
        {
            switch(opcion)
            {
                case "Añadir":
                    string nombre = txtNombre.Text.ToString();

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

                        nomAlm = false;
                     }
                     else if (nombre.Length > 0 && !nombre.Equals("Nombre"))
                     {
                        string sql = "SELECT * FROM Almacen";

                        SqlConnection cnx = new SqlConnection(conection);
                        cnx.Open();

                        SqlCommand command = new SqlCommand(sql, cnx);
                        SqlDataReader lector = command.ExecuteReader();

                        while (lector.Read())
                        {
                            if (lector.GetString(2).Equals(nombre))
                            {
                                encontrado = true;
                                lbErrorNom.Text = "El nombre ya se ha usado.";
                                lbErrorNom.Visible = true;

                                lbNombre.ForeColor = Color.Red;

                                nomAlm = false;
                            }
                            else
                            {
                                encontrado = false;
                                lbErrorNom.Text = "";
                                lbErrorNom.Visible = false;

                                lbNombre.ForeColor = Color.Green;

                                nomAlm = true;
                            }
                        }
                     }
                     else if (nombre.Equals("Nombre"))
                     {
                        lbErrorNom.Text = "";
                        lbErrorNom.Visible = false;
                        lbNombre.ForeColor = Color.Black;
                        nomAlm = false;
                     }
                     break;
                case "Modificar":
                    string nombreMod = txtNombreAMod.Text.ToString();

                    if(nombreMod.Length == 0 || nombreMod.Length > 50)
                    {
                        lbErrorNombreAMod.Visible = true;
                        lbNombreAMod.ForeColor = Color.Red;

                        if(nombreMod.Length == 0)
                        {
                            lbErrorNombreAMod.Text = "El nombre no puede estar vacío.";
                        } else if(nombreMod.Length > 50) 
                        {
                            lbErrorNombreAMod.Text = "El nombre es demasiado largo.";
                        }

                        nomAlmMod = false;
                    } else if(nombreMod.Length > 0 && !nombreMod.Equals("Nombre"))
                    {
                        lbErrorNombreAMod.Text = "";
                        lbErrorNombreAMod.Visible = false;
                        lbNombreAMod.ForeColor = Color.Green;
                        nomAlmMod = true;
                    }

                    break;
            }
        }

        private void filtroDatos()
        {
            if (cbDatosA.SelectedIndex != 0)
            {
                try
                {
                    string sql = "SELECT * FROM Almacen WHERE " + cbDatosA.Text + " LIKE '%' + @filtro + '%'";
                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    command.Parameters.AddWithValue("@filtro", txtFiltroA.Text);

                    SqlDataReader lector = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(lector);
                    dgvAlmacenes.DataSource = dt;

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

        private void rellenaTablaAlmacenes()
        {
            string sql = "SELECT * FROM Almacen";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(lector);
                dgvAlmacenes.DataSource = dt;

                foreach (DataGridViewColumn col in dgvAlmacenes.Columns)
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

        private void rellenaComboBoxIDAlm()
        {
            cbIDAMod.Items.Clear();
            cbIDAMod.Items.Add(" ");

            cbIDABorr.Items.Clear();
            cbIDABorr.Items.Add(" ");

            string sql = "SELECT * FROM Almacen";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    cbIDAMod.Items.Add(lector.GetInt32(0));
                    cbIDABorr.Items.Add(lector.GetInt32(0));
                }

                cnx.Close();
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void rellenaCbDatosAlmacen()
        {
            cbDatosA.Items.Add("");

            foreach (DataGridViewColumn col in dgvAlmacenes.Columns)
            {
                cbDatosA.Items.Add(col.HeaderText);
            }

            cbDatosA.SelectedIndex = 0;
        }
    }
}
