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

namespace Spaniac.Formularios.FormulariosInternos.FormulariosProductos
{
    public partial class FormProductos : Form
    {
        /* Ruta de conexión para la BD. */
        static string conection = "server=localhost; database=Spaniac; integrated security=true";

        /* Variables booleanas que controlan si los datos de la categoría están rellenos para realizar la inserción. */
        bool nomCat = false, almCat = false;

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormProductos()
        {
            InitializeComponent();

            rellenaTablaCategorias();
            rellenaComboBoxAlmacenes();
            rellenaCbDatosCategoria();

            imgLimpiar.Image = Image.FromFile("Goma.png");

            lbErrorAlmC.Text = "Selecciona un almacén.";
            lbErrorAlmC.Visible = true;
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
        /*                        GESTION DE EVENTOS DEL BOTÓN DE CATEGORÍAS                               */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            panelCategorias.Visible = true;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                     GESTION DE EVENTOS DEL BOTÓN DE AÑADIR CATEGORÍAS                           */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnAñadirC_Click(object sender, EventArgs e)
        {
            panelAñadirC.Visible = true;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                   GESTION DE EVENTOS DEL TEXTBOX DEL NOMBRE DE LA CATEGORÍA                     */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtNombreC_Enter(object sender, EventArgs e)
        {
            if (txtNombreC.Text.Equals("Nombre"))
            {
                txtNombreC.Text = "";
                txtNombreC.ForeColor = Color.Black;
            }
        }

        private void txtNombreC_Leave(object sender, EventArgs e)
        {
            if (txtNombreC.Text.Equals(""))
            {
                txtNombreC.Text = "Nombre";
                txtNombreC.ForeColor = Color.DarkGray;
                lbNombreC.ForeColor = Color.Black;
                lbErrorNomC.Text = "";
                lbErrorNomC.Visible = false;
            }
        }

        private void txtNombreC_TextChanged(object sender, EventArgs e)
        {
            compruebaNombreCategoria();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                 GESTION DE EVENTOS DEL COMBOBOX DE ALMACENES DE LA CATEGORÍA                    */
        /*-------------------------------------------------------------------------------------------------*/
        private void cbAlmacenC_SelectedIndexChanged(object sender, EventArgs e)
        {
            compruebaAlmacenCategoria();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*              GESTION DE EVENTOS DEL BOTÓN DE LIMPIAR DEL PANEL DE AÑADIR CATEGORÍA              */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnLimpiarC_Click(object sender, EventArgs e)
        {
            txtNombreC.Text = "";
            cbAlmacenC.SelectedIndex = 0;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*              GESTION DE EVENTOS DEL BOTÓN DE AÑADIR DEL PANEL DE AÑADIR CATEGORÍA               */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnAñadeC_Click(object sender, EventArgs e)
        {
            if(nomCat == true && almCat == true)
            {
                DatosCategoria datosNuevaCat = new DatosCategoria();
                datosNuevaCat.Nombre = txtNombreC.Text.ToString();
                datosNuevaCat.Productos = 0;
                datosNuevaCat.IdAlmacen = cbAlmacenC.SelectedIndex;
                datosNuevaCat.guardarCambios();

                FormNotificaciones form = new FormNotificaciones("Categoría registrada correctamente.");
                form.Show();
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*          GESTION DE EVENTOS DEL COMBOBOX DE TIPOS DE DATOS DE CATEGORÍA PARA EL FILTRADO        */
        /*-------------------------------------------------------------------------------------------------*/
        private void cbDatosC_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroDatos();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*            GESTION DE EVENTOS DEL TEXTBOX DEL FILTRO PARA EL DATAGRIDVIEW DE CATEGORÍA          */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtFiltroC_TextChanged(object sender, EventArgs e)
        {
            filtroDatos();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                     GESTION DE EVENTOS DEL PICTUREBOX QUE LIMPIA EL FILTRO                      */
        /*-------------------------------------------------------------------------------------------------*/
        private void imgLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroC.Text = "";
            cbDatosC.SelectedIndex = 0;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                            METODOS USADOS EN EL CÓDIGO DEL FORMULARIO                           */
        /*-------------------------------------------------------------------------------------------------*/
        public void rellenaTablaCategorias()
        {
            string sql = "SELECT * FROM Categoria";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(lector);
                dgvCategorias.DataSource = dt;

                foreach(DataGridViewColumn col in dgvCategorias.Columns)
                {
                    col.HeaderText = col.HeaderText.ToUpper();
                }

                command.Dispose();
                cnx.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rellenaComboBoxAlmacenes()
        {
            cbAlmacenC.Items.Add(" ");

            string sql = "SELECT * FROM Almacen";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while(lector.Read())
                {
                    cbAlmacenC.Items.Add(lector.GetInt32(0));
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void compruebaNombreCategoria()
        {
            string nombre = txtNombreC.Text.ToString();

            if (nombre.Length == 0 || nombre.Length > 50)
            {
                lbErrorNomC.Visible = true;
                lbNombreC.ForeColor = Color.Red;

                if (nombre.Length == 0)
                {
                    lbErrorNomC.Text = "El nombre no puede estar vacío.";
                }
                else if (nombre.Length > 50)
                {
                    lbErrorNomC.Text = "El nombre es demasiado largo.";
                }

                nomCat = false;
            }
            else if (nombre.Length > 0 && !nombre.Equals("Nombre"))
            {
                lbErrorNomC.Text = "";
                lbErrorNomC.Visible = false;
                lbNombreC.ForeColor = Color.Green;
                nomCat = true;
            }
            else if (nombre.Equals("Nombre"))
            {
                lbErrorNomC.Text = "";
                lbErrorNomC.Visible = false;
                lbNombreC.ForeColor = Color.Black;
                nomCat = false;
            }
        }

        private void compruebaAlmacenCategoria()
        {
            int almacen = cbAlmacenC.SelectedIndex;

            if(almacen == 0)
            { 
                lbErrorAlmC.Text = "Selecciona un almacén.";
                lbErrorAlmC.Visible = true;
                almCat = false;
            } else
            {
                lbErrorAlmC.Text = "";
                lbErrorAlmC.Visible = false;
                almCat = true;
            }
        }

        private void rellenaCbDatosCategoria()
        {
            cbDatosC.Items.Add("");

            foreach(DataGridViewColumn col in dgvCategorias.Columns)
            {
                cbDatosC.Items.Add(col.HeaderText);
            }

            cbDatosC.SelectedIndex = 0;
        }

        

        private void filtroDatos()
        {
            
        }
    }
}
