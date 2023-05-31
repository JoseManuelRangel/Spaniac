using DocumentFormat.OpenXml.Drawing;
using Newtonsoft.Json;
using Spaniac.Clases;
using Spaniac.Formularios.Internos.Almacenes;
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

namespace Spaniac.Formularios.Internos.Clientes
{
    public partial class FormClientes : Form
    {
        /* Ruta de conexión para la BD. */
        static string conection = "server=localhost; database=Spaniac; integrated security=true";

        /* Variables booleanas estáticas que controlan si los paneles están visibles o no. */
        static bool pExcel = false, pJson = false, pXml = false;

        /* Variables boolenas que indican si los campos colocados en la inserción están bien. */
        static bool idCorr = false, nomCorr = false, locCorr = false, dirCorr = false, telCorr = false;

        /* Variables booleanas que indican si los campos colocados en la modificación están bien. */
        static bool idCorrMod = false, nomCorrMod = false, locCorrMod = false, dirCorrMod = false, telCorrMod = false;

        /* Variables booleanas sque controlan si los datos del cliente están completos para realizar la eliminación. */
        bool idCorrBorr = false;

        /* Determina si se ha encontrado el cliente u otro dato importante en la base de datos previamente registrado. */
        static bool encontrado = false;

        /* Listas. */
        static List<string> nodosXML = new List<string>();

        /* Variable cadena que almacena el JSON cargado. */
        static string clientesJSON;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormClientes()
        {
            InitializeComponent();
            inicializarControles();

            rellenaTablaClientes();
            rellenaCbDatosCliente();
            rellenaComboBoxIDCliente();

            EstilosTabla estilos = new EstilosTabla(this.dgvClientes);
            estilos.estiloCabecera(8);
            estilos.estiloFila();
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

        private void btnMenuXml_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnMenuXml_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
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
            if(pJson == false)
            {
                panelMenuJson.Visible = true;
                pJson = true;
            } else
            {
                panelMenuJson.Visible = false;
                pJson = false;
            }
        }

        private void btnMenuJSON_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnMenuJSON_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*                      Gestión de eventos del botón generar JSON del menú JSON                      */
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

        private void btnMenuEXCEL_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnMenuEXCEL_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
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

        /*                       Gestión de eventos del botón leer EXCEL del menú EXCEL                      */
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
        /*                           ELEMENTOS DEL PANEL IZQUIERDO DE CLIENTES                             */
        /*-------------------------------------------------------------------------------------------------*/
        /*               Gestión de eventos del botón que abre el panel para añadir un cliente.            */
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            panelAñadirCli.Visible = true;
            panelModCli.Visible = false;
            panelBorrCli.Visible = false;
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


        /*               Gestión de eventos del botón que abre el panel para modificar un cliente.            */
        private void btnModificar_Click(object sender, EventArgs e)
        {
            panelModCli.Visible = true;
            panelAñadirCli.Visible = false;
            panelBorrCli.Visible = false;
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
            panelModCli.Visible = false;
            panelAñadirCli.Visible = false;
            panelBorrCli.Visible = true;
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
        /*                           ELEMENTOS DEL SUBPANEL QUE AÑADE UN CLIENTE                           */
        /*-------------------------------------------------------------------------------------------------*/
        /*                     Gestión de eventos del textbox del id de cliente a añadir                   */
        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("ID"))
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                txtID.Text = "ID";
                txtID.ForeColor = Color.DarkGray;
                lbID.ForeColor = Color.Black;
                lbErrorID.Text = "";
                lbErrorID.Visible = false;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            compruebaIDCliente();
        }


        /*                  Gestión de eventos del textbox del nombre del cliente a añadir                 */
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("Nombre"))
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
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
            compruebaNombreCliente("Añadir");
        }


        /*                  Gestión de eventos del textbox de localidad del cliente a añadir                 */
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
            compruebaLocalidadCliente("Añadir");
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
            compruebaDireccionCliente("Añadir");
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
            compruebaTelefonoCliente("Añadir");
        }


        /*            Gestión de eventos del botón limpiar datos de la inserción de cliente                 */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
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


        /*  Gestión de eventos del botón que comprueba si todos los datos son correctos y añade un cliente  */
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(idCorr && nomCorr && locCorr && dirCorr && telCorr)
            {
                DatosCliente datosNuevoCli = new DatosCliente();
                datosNuevoCli.ID = txtID.Text;
                datosNuevoCli.Nombre = txtNombre.Text;
                datosNuevoCli.FechaRegistro = DateTime.Parse(DateTime.UtcNow.ToString("d"));
                datosNuevoCli.Localidad = txtLocalidad.Text;
                datosNuevoCli.Direccion = txtDireccion.Text;
                datosNuevoCli.Telefono = txtTelefono.Text;
                datosNuevoCli.guardarCambios();

                FormNotificaciones form = new FormNotificaciones("Cliente registrado correctamente.");
                form.Show();

                rellenaTablaClientes();
                rellenaComboBoxIDCliente();
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
        /*                         ELEMENTOS DEL SUBPANEL QUE MODIFICA UN CLIENTE                          */
        /*-------------------------------------------------------------------------------------------------*/
        /*                     Gestión de eventos del combobox del id de cliente a editar                  */
        private void cbIDCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            compruebaClientes();
        }

        /*                Gestión de eventos del textbox de nombre que modifica el cliente               */
        private void txtNombreMod_TextChanged(object sender, EventArgs e)
        {
            compruebaNombreCliente("Modificar");
        }

        /*               Gestión de eventos del textbox de localidad que modifica el cliente             */
        private void txtLocalidadMod_TextChanged(object sender, EventArgs e)
        {
            compruebaLocalidadCliente("Modificar");
        }

        /*              Gestión de eventos del textbox de direccion que modifica el cliente               */
        private void txtDireccionMod_TextChanged(object sender, EventArgs e)
        {
            compruebaDireccionCliente("Modificar");
        }

        /*              Gestión de eventos del textbox del teléfono que modifica el cliente               */
        private void txtTelefonoMod_TextChanged(object sender, EventArgs e)
        {
            compruebaTelefonoCliente("Modificar");
        }

        /*              Gestión de eventos del botón que realiza la modificación del cliente.             */
        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (idCorrMod && nomCorrMod && locCorrMod && dirCorrMod && telCorrMod)
            {
                try
                {
                    string nombreMod = txtNombreMod.Text;
                    string localidadMod = txtLocalidadMod.Text;
                    string direccionMod = txtDireccionMod.Text;
                    string telefonoMod = txtTelefonoMod.Text;

                    string sql = "UPDATE Cliente SET nombre='" + nombreMod + "', localidad='" + localidadMod + "', direccion='" + direccionMod + "', telefono='" + telefonoMod + "' WHERE id='" + cbIDCliente.Text + "'";
                    SqlConnection cnx = new SqlConnection(conection);

                    cnx.Open();
                    SqlCommand command = new SqlCommand(sql, cnx);
                    command.ExecuteNonQuery();

                    FormNotificaciones form = new FormNotificaciones("Cliente modificado correctamente.");
                    form.Show();

                    rellenaTablaClientes();
                    inicializaDatos("Modificar");
                    cnx.Close();
                }
                catch (Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
        }

        private void btnModifica_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnModifica_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*          Gestión de eventos del botón que limpia los controles de edición de cliente.           */
        private void btnLimpiaMod_Click(object sender, EventArgs e)
        {
            inicializaDatos("Modificar");
        }

        private void btnLimpiaMod_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnLimpiaMod_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                            ELEMENTOS DEL SUBPANEL QUE BORRA UN CLIENTE                          */
        /*-------------------------------------------------------------------------------------------------*/
        /*                     Gestión de eventos del combobox del id de cliente a borrar                  */
        private void cbIDClienteBorr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIDClienteBorr.SelectedIndex != 0)
            {
                lbErrorIDBorr.Text = "";
                lbErrorIDBorr.Visible = false;

                idCorrBorr = true;
            }
            else
            {
                lbErrorIDBorr.Text = "Selecciona un cliente.";
                lbErrorIDBorr.Visible = true;

                idCorrBorr = false;
            }
        }

        /*       Gestión de eventos del botón que abre el panel de confirmación de borrado de cliente      */
        private void btnAceptarBorrar_Click(object sender, EventArgs e)
        {
            if(idCorrBorr)
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
                string cliente = cbIDClienteBorr.Text;

                string sql = "DELETE FROM Cliente WHERE id='" + cliente + "'";
                SqlConnection cnx = new SqlConnection(conection);

                cnx.Open();
                SqlCommand command = new SqlCommand(sql, cnx);
                command.ExecuteNonQuery();

                FormNotificaciones form = new FormNotificaciones("Cliente borrado correctamente.");
                form.Show();

                panelConfBorr.Visible = false;

                rellenaComboBoxIDCliente();
                rellenaTablaClientes();
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
        /*                            ELEMENTOS DEL PANEL DERECHO DE LOS CLIENTES                          */
        /*-------------------------------------------------------------------------------------------------*/
        /*             Gestión de eventos del textbox que filtra el datagridview de los clientes           */
        private void txtFiltroCli_TextChanged(object sender, EventArgs e)
        {
            filtroDatos();
        }

        /*          Gestión de eventos del picturebox que limpia el textbox del filtro de la tabla         */
        private void imgLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroCli.Text = "";
            cbDatosCli.SelectedIndex = 0;
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
        private void inicializarControles()
        {
            panelPortada.Visible = true;

            panelAñadirCli.Visible = false;

            panelModCli.Visible = false;
            lbErrorIDMod.Text = "Selecciona un cliente a modificar.";
            lbErrorIDMod.Visible = true;

            panelBorrCli.Visible = false;
            lbErrorIDBorr.Text = "Selecciona un cliente a borrar.";
            lbErrorIDBorr.Visible = true;

            panelMenuExcel.Visible = false;
            panelMenuJson.Visible = false;
            panelMenuXml.Visible = false;

            try
            {
                int contador = 0;
                string sql = "SELECT * FROM Cliente";
                SqlConnection cnx = new SqlConnection(conection);

                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    contador++;
                }

                if (contador == 0)
                {
                    DatosCliente datosCliente = new DatosCliente();
                    datosCliente.ID = "00000000Z";
                    datosCliente.Nombre = "Prueba";
                    datosCliente.FechaRegistro = DateTime.Parse(DateTime.UtcNow.ToString());
                    datosCliente.Localidad = "Prueba";
                    datosCliente.Direccion = "Prueba";
                    datosCliente.Telefono = "000000000";
                    datosCliente.guardarCambios();
                    rellenaTablaClientes();
                }

                cnx.Close();
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void inicializaDatos(string opcion)
        {
            switch(opcion)
            {
                case "Añadir":
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtLocalidad.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    break;
                case "Modificar":
                    cbIDCliente.Text = "";
                    txtNombreMod.Text = "";
                    txtLocalidadMod.Text = "";
                    txtDireccionMod.Text = "";
                    txtTelefonoMod.Text = "";
                    break;
                case "Borrar":
                    cbIDClienteBorr.SelectedIndex = 0;
                    break;
            }
        }
        private void rellenaTablaClientes()
        {
            string sql = "SELECT * FROM Cliente";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                DataTable dt = new DataTable(); 
                dt.Load(lector);
                dgvClientes.DataSource = dt;

                foreach(DataGridViewColumn col in dgvClientes.Columns)
                {
                    col.HeaderText = col.HeaderText.ToUpper();
                }

                command.Dispose();
                cnx.Close();
            } catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void rellenaCbDatosCliente()
        {
            cbDatosCli.Items.Add("");

            foreach(DataGridViewColumn col in dgvClientes.Columns)
            {
                cbDatosCli.Items.Add(col.HeaderText);
            }
            
            cbDatosCli.SelectedIndex = 0;
        }

        private void filtroDatos()
        {
            if(cbDatosCli.SelectedIndex != 0)
            {
                try
                {
                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    string sql = "SELECT * FROM Cliente WHERE " + cbDatosCli.Text + " LIKE '%' + @filtro + '%'";
                    SqlCommand command = new SqlCommand(sql, cnx);
                    command.Parameters.AddWithValue("@filtro", txtFiltroCli.Text);

                    SqlDataReader lector = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(lector);
                    dgvClientes.DataSource = dt;

                    command.Dispose();
                    cnx.Close();
                } catch(Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
        }

        private void compruebaIDCliente()
        {
            string id = txtID.Text.ToString();

            if(id.Length != 9)
            {
                lbID.ForeColor = Color.Red;

                lbErrorID.Text = "ID Inválido.";
                lbErrorID.Visible = true;

                idCorr = false;
            } else if(id.Length == 9 && !id.Equals("ID"))
            {
                if(Char.IsLetter(id, (id.Length - 1)) || Char.IsLetter(id, 0))
                {
                    string sql = "SELECT * FROM Cliente";

                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    while (lector.Read())
                    {
                        if (lector.GetString(0).Equals(id))
                        {
                            encontrado = true;
                            lbErrorID.Text = "El id ya se ha usado.";
                            lbErrorID.Visible = true;
                            lbID.ForeColor = Color.Red;

                            idCorr = false;
                        }
                        else
                        {
                            encontrado = false;
                            lbErrorID.Text = "";
                            lbErrorID.Visible = false;

                            lbID.ForeColor = Color.Green;

                            idCorr = true;
                        }
                    }
                } else
                {
                    lbID.ForeColor = Color.Red;

                    lbErrorID.Text = "ID Inválido.";
                    lbErrorID.Visible = true;

                    idCorr = false;
                }
            }
        }

        private void rellenaComboBoxIDCliente()
        {
            cbIDCliente.Items.Clear();
            cbIDCliente.Items.Add(" ");

            cbIDClienteBorr.Items.Clear();
            cbIDClienteBorr.Items.Add(" ");

            try
            {
                string sql = "SELECT * FROM Cliente";
                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    cbIDCliente.Items.Add(lector.GetString(0));
                    cbIDClienteBorr.Items.Add(lector.GetString(0));
                }

                cnx.Close();
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void compruebaNombreCliente(string opcion)
        {
            switch (opcion)
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

                        nomCorr = false;
                    }
                    else if (nombre.Length > 0 && !nombre.Equals("Nombre"))
                    {
                        string sql = "SELECT * FROM Cliente";

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

        private void compruebaLocalidadCliente(string opcion)
        {
            switch(opcion)
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

        private void compruebaDireccionCliente(string opcion)
        {
            switch(opcion)
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

        private void compruebaTelefonoCliente(string opcion)
        {
            switch(opcion)
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

        private void compruebaClientes()
        {
            if (cbIDCliente.SelectedIndex != 0)
            {
                try
                {
                    string sql = "SELECT * FROM Cliente WHERE id='" + cbIDCliente.Text + "'";
                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    while (lector.Read())
                    {
                        txtNombreMod.Text = lector.GetString(1);
                        txtLocalidadMod.Text = lector.GetString(3);
                        txtDireccionMod.Text = lector.GetString(4);
                        txtTelefonoMod.Text = lector.GetString(5);
                    }

                    txtNombreMod.Enabled = true;
                    txtLocalidadMod.Enabled = true;
                    txtDireccionMod.Enabled = true;
                    txtTelefonoMod.Enabled = true;

                    idCorrMod = true;

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

                idCorrMod = false;
            }
        }

        private void generaXML()
        {
            try
            {
                string sql = "SELECT * FROM Cliente";
                SqlConnection cnx = new SqlConnection(conection);

                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                if (!System.IO.File.Exists("Clientes.xml"))
                {
                    XmlWriter listCli = XmlWriter.Create("Clientes.xml");
                    listCli.WriteStartDocument();
                    listCli.WriteStartElement("Clientes");

                    while (lector.Read())
                    {
                        listCli.WriteStartElement("Cliente");

                        listCli.WriteStartElement("ID");
                        listCli.WriteValue((lector.GetString(0)));
                        listCli.WriteEndElement();

                        listCli.WriteStartElement("Nombre");
                        listCli.WriteValue((lector.GetString(1)));
                        listCli.WriteEndElement();

                        listCli.WriteStartElement("FechaRegistro");
                        listCli.WriteValue((lector.GetDateTime(2)));
                        listCli.WriteEndElement();

                        listCli.WriteStartElement("Localidad");
                        listCli.WriteValue((lector.GetString(3)));
                        listCli.WriteEndElement();

                        listCli.WriteStartElement("Direccion");
                        listCli.WriteString((lector.GetString(4)));
                        listCli.WriteEndElement();

                        listCli.WriteStartElement("Telefono");
                        listCli.WriteValue((lector.GetString(5)));
                        listCli.WriteEndElement();

                        listCli.WriteEndElement();
                    }

                    listCli.WriteEndElement();
                    listCli.WriteEndDocument();
                    listCli.Close();

                    FormNotificaciones form = new FormNotificaciones("XML generado correctamente.");
                    form.Show();

                    cnx.Close();
                }
                else
                {
                    FormNotificaciones form2 = new FormNotificaciones("Ya hay un documento XML de Clientes. Muévelo o cambialo de nombre para poder generar otro.");
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
                                if (n2.Name.Equals("ID") || n2.Name.Equals("Nombre") || n2.Name.Equals("FechaRegistro")
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

                    if (nodosXML.Count == 6)
                    {
                        /* Redirige al formulario de lectura XML. */
                        FormListarClientes form = new FormListarClientes(nombre);
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
                List<Cliente> listaClientes = new List<Cliente>();
                string sql = "SELECT * FROM Cliente";
                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    Cliente c = new Cliente(lector.GetString(0), lector.GetString(1), lector.GetDateTime(2), 
                        lector.GetString(3), lector.GetString(4), lector.GetString(5));
                    listaClientes.Add(c);
                }

                if (!File.Exists("Clientes.json"))
                {
                    string jsonAlm = JsonConvert.SerializeObject(listaClientes.ToArray(), Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText("Clientes.json", jsonAlm);

                    FormNotificaciones form = new FormNotificaciones("JSON generado correctamente.");
                    form.Show();
                }
                else
                {
                    FormNotificaciones form2 = new FormNotificaciones("Ya hay un documento JSON de Clientes. Muévelo o cambialo de nombre para poder generar otro.");
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
                    List<Cliente> listaCli = new List<Cliente>();

                    using (var streamReader = new StreamReader(ruta))
                    using (var textReader = new JsonTextReader(streamReader))
                    {
                        listaCli = serializer.Deserialize<List<Cliente>>(textReader);
                    }

                    FormListarClientes form = new FormListarClientes(clientesJSON, listaCli);
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
                List<Cliente> listaClientes = new List<Cliente>();
                string sql = "SELECT * FROM Cliente";
                string ruta = AppDomain.CurrentDomain.BaseDirectory + "Clientes.xlsx";
                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    Cliente c = new Cliente(lector.GetString(0), lector.GetString(1), lector.GetDateTime(2),
                        lector.GetString(3), lector.GetString(4), lector.GetString(5));
                    listaClientes.Add(c);
                }

                if (!File.Exists(ruta))
                {
                    SLDocument excel = new SLDocument();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID", typeof(string));
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Columns.Add("Fecha Registro", typeof(string));
                    dt.Columns.Add("Localidad", typeof(string));
                    dt.Columns.Add("Direccion", typeof(string));
                    dt.Columns.Add("Telefono", typeof(string));

                    foreach (Cliente cliente in listaClientes)
                    {
                        dt.Rows.Add(cliente.ID, cliente.Nombre, cliente.FechaRegistro, cliente.Localidad, cliente.Direccion, cliente.Telefono);
                    }

                    excel.ImportDataTable(1, 1, dt, true);
                    excel.SaveAs(ruta);

                    FormNotificaciones form = new FormNotificaciones("Excel generado correctamente.");
                    form.Show();
                }
                else
                {
                    FormNotificaciones form = new FormNotificaciones("Ya existe un excel con ese nombre.");
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
                    List<Cliente> clientesExcel = new List<Cliente>();
                    string ruta = buscador.FileName;

                    SLDocument sl = new SLDocument(ruta);
                    int numFila = 1;

                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(numFila, 1)))
                    {
                        if (numFila != 1)
                        {
                            string id = sl.GetCellValueAsString(numFila, 1);
                            string nombre = sl.GetCellValueAsString(numFila, 2);
                            DateTime fecha = sl.GetCellValueAsDateTime(numFila, 3);
                            string localidad = sl.GetCellValueAsString(numFila, 4);
                            string direccion = sl.GetCellValueAsString(numFila, 5);
                            string telefono = sl.GetCellValueAsString(numFila, 6);

                            Cliente c = new Cliente(id, nombre, fecha, localidad, direccion, telefono);
                            clientesExcel.Add(c);
                        }
                        numFila++;
                    }

                    FormListarClientes form = new FormListarClientes(clientesExcel);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }
    }
}
