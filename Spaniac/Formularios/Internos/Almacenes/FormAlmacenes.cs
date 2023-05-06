using Spaniac.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        /* Determina si se ha encontrado el almacen u otro dato importante en la base de datos previamente registrado. */
        static bool encontrado = false;

        static int estadoEscogido;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormAlmacenes()
        {
            InitializeComponent();
            inicializarControles();

            rellenaTablaAlmacenes();
            rellenaCbDatosCategoria();
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
                /* 1 significa que el almacén está activo. */
                estadoEscogido = 1;

                actAlm = true;
            }

            if(cbAct1.Checked)
            {
                cbAct2.Checked = false;
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
                /* 0 significa que el almacén está inactivo. */
                estadoEscogido = 0;

                actAlm = true;
            }

            if(cbAct2.Checked)
            {
                cbAct1.Checked = false;
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
        /*                                 MÉTODOS USADOS EN EL FORMULARIO                                 */
        /*-------------------------------------------------------------------------------------------------*/
        private void inicializarControles()
        {
            lbErrorEstado.Text = "Selecciona si el almacén está activo o inactivo.";
            lbErrorEstado.Visible = true;
            panelMenuExcel.Visible = false;
            panelMenuJSON.Visible = false;
            panelMenuXml.Visible = false;
        }

        private void inicializaDatos()
        {
            txtNombre.Text = "";
            cbAct1.Checked = false;
            cbAct2.Checked = false;
        }

        private void filtroDatos()
        {
            if(cbDatosA.SelectedIndex != 0)
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

                foreach(DataGridViewColumn col in dgvAlmacenes.Columns)
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

        private void rellenaCbDatosCategoria()
        {
            cbDatosA.Items.Add("");

            foreach (DataGridViewColumn col in dgvAlmacenes.Columns)
            {
                cbDatosA.Items.Add(col.HeaderText);
            }

            cbDatosA.SelectedIndex = 0;
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
            }
        }
    }
}
