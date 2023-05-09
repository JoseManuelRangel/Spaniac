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

        /* Variables booleanas que controlan si los datos de la categoría están rellenos para realizar la modificación. */
        bool idCatMod = false, nomCatMod = false, almCatMod = false;

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormProductos()
        {
            InitializeComponent();

            rellenaTablaCategorias();
            rellenaComboBoxAlmacenes();
            rellenaCbDatosCategoria();
            rellenaComboBoxIDCat();

            /* Elementos del panel derecho de la sección de categorías. */
            imgLimpiar.Image = Image.FromFile("Goma.png");

            /* Elementos del subpanel de adición de categorías. */
            lbErrorAlmC.Text = "Selecciona un almacén.";
            lbErrorAlmC.Visible = true;


            /* Elementos del subpanel de modificación de categorías. */
            lbErrorIdCMod.Text = "Selecciona un ID para buscar categoría.";
            lbErrorIdCMod.Visible = true;

            txtNombreCMod.Enabled = false;
            txtProdCMod.Enabled = false;
            cbAlmacenCMod.Enabled = false;
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
        /*                          GESTION DE EVENTOS DEL BOTÓN DE CATEGORÍAS                             */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            panelCategorias.Visible = true;
        }

        /*-------------------------------------------------------------------------------------------------*/
        /*                           ELEMENTOS DEL PANEL IZQUIERDO DE CATEGORÍAS                           */
        /*-------------------------------------------------------------------------------------------------*/
        /*             Gestión de eventos del botón que abre el panel para añadir una categoría.           */
        private void btnAñadirC_Click(object sender, EventArgs e)
        {
            panelAñadirC.Visible = true;
        }

        private void btnAñadirC_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAñadirC_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*           Gestión de eventos del botón que abre el panel para modificar una categoría.          */
        private void btnModificarC_Click(object sender, EventArgs e)
        {
            panelModificarC.Visible = true;
        }

        private void btnModificarC_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnModificarC_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                         ELEMENTOS DEL SUBPANEL QUE AÑADE UNA CATEGORÍA                          */
        /*-------------------------------------------------------------------------------------------------*/
        /*               Gestión de eventos del textbox del nombre de la categoría a añadir                */
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
            compruebaNombreCategoria("Añadir");
        }


        /*               Gestión de eventos del textbox del nombre de la categoría a añadir                */
        private void cbAlmacenC_SelectedIndexChanged(object sender, EventArgs e)
        {
            compruebaAlmacenCategoria("Añadir");
        }


        /*             Gestión de eventos del botón que limpia los datos de la categoría a añadir.         */
        private void btnLimpiarC_Click(object sender, EventArgs e)
        {
            txtNombreC.Text = "";
            cbAlmacenC.SelectedIndex = 0;
        }

        private void btnLimpiarC_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnLimpiarC_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*           Gestión de eventos del botón que registra una categoría en la base de datos.          */
        private void btnAñadeC_Click(object sender, EventArgs e)
        {
            if(nomCat && almCat)
            {
                DatosCategoria datosNuevaCat = new DatosCategoria();
                datosNuevaCat.Nombre = txtNombreC.Text.ToString();
                datosNuevaCat.Productos = 0;
                datosNuevaCat.IdAlmacen = cbAlmacenC.SelectedIndex;
                datosNuevaCat.guardarCambios();

                txtNombreC.Text = "";
                cbAlmacenC.SelectedIndex = 0;

                FormNotificaciones form = new FormNotificaciones("Categoría registrada correctamente.");
                form.Show();

                rellenaTablaCategorias();
            }
        }

        private void btnAñadeC_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAñadeC_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                      ELEMENTOS DEL SUBPANEL QUE MODIFICA UNA CATEGORÍA                          */
        /*-------------------------------------------------------------------------------------------------*/
        /*         Gestión de eventos del combobox que selecciona el ID de la categoría a modificar.       */
        private void cbIdCMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIdCMod.SelectedIndex != 0)
            {
                string sql = "SELECT * FROM Categoria WHERE id=" + cbIdCMod.SelectedIndex;
                SqlConnection cnx = new SqlConnection(conection);

                try
                {
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    txtNombreCMod.Text = lector.GetString(1);
                    txtProdCMod.Text = lector.GetString(2);
                    cbAlmacenCMod.SelectedIndex = lector.GetInt32(3);

                    txtNombreCMod.Enabled = true;
                    txtProdCMod.Enabled = true;
                    cbAlmacenCMod.Enabled = true;

                    lbErrorIdCMod.Text = "";
                    lbErrorIdCMod.Visible = false;

                    idCatMod = true;

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
                txtNombreCMod.Enabled = true;
                txtNombreCMod.Text = "";
                
                txtProdCMod.Enabled = true;
                txtProdCMod.Text = "";

                cbAlmacenCMod.Enabled = true;
                cbAlmacenCMod.SelectedIndex = 0;

                lbErrorIdCMod.Text = "Selecciona un ID para buscar categoría.";
                lbErrorIdCMod.Visible = true;

                idCatMod = false;
            }
        }


        /*              Gestión de eventos del textbox de nombre que modifica la categoría                 */
        private void txtNombreCMod_TextChanged(object sender, EventArgs e)
        {
            compruebaNombreCategoria("Modificar");
        }


        /*              Gestión de eventos del textbox de nombre que modifica la categoría                 */
        private void cbAlmacenCMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            compruebaAlmacenCategoria("Modificar");
        }


        /*           Gestión de eventos del botón que acepta la modificación de la categoría               */
        private void btnAceptarCMod_Click(object sender, EventArgs e)
        {
            if(idCatMod && nomCatMod && almCatMod)
            {
                try 
                {
                    string nombre = txtNombreCMod.Text;
                    int almacen = cbAlmacenCMod.SelectedIndex;

                    string sql = "UPDATE Categoria SET nombre='" + nombre + "', almacen=" + almacen + " WHERE id=" + cbIdCMod.SelectedIndex;
                    SqlConnection cnx = new SqlConnection(conection);

                    cnx.Open();
                    SqlCommand command = new SqlCommand(sql, cnx);
                    command.ExecuteNonQuery();

                    FormNotificaciones form = new FormNotificaciones("Categoría modificada correctamente.");
                    form.Show();

                    rellenaTablaCategorias();
                } catch(Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           ELEMENTOS DEL PANEL DERECHO DE LAS CATEGORÍAS                         */
        /*-------------------------------------------------------------------------------------------------*/
        /*           Gestión de eventos del textbox que filtra el datagridview de las categorías           */
        private void txtFiltroC_TextChanged(object sender, EventArgs e)
        {
            filtroDatos();
        }


        /*          Gestión de eventos del picturebox que limpia el textbox del filtro de la tabla         */
        private void imgLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroC.Text = "";
            cbDatosC.SelectedIndex = 0;
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
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void rellenaComboBoxAlmacenes()
        {
            cbAlmacenC.Items.Add(" ");
            cbAlmacenCMod.Items.Add(" ");

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
                    cbAlmacenCMod.Items.Add(lector.GetInt32(0));                   
                }
            } catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void rellenaComboBoxIDCat()
        {
            cbIdCMod.Items.Add(" ");

            string sql = "SELECT * FROM Categoria";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while(lector.Read()) 
                {
                    cbIdCMod.Items.Add(lector.GetInt32(0));
                }
            } catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void rellenaCbDatosCategoria()
        {
            cbDatosC.Items.Add("");

            foreach (DataGridViewColumn col in dgvCategorias.Columns)
            {
                cbDatosC.Items.Add(col.HeaderText);
            }

            cbDatosC.SelectedIndex = 0;
        }

        private void compruebaNombreCategoria(string opcion)
        {
            switch(opcion)
            {
                case "Añadir":
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
                    break;
                case "Modificar":
                    string nombreMod = txtNombreCMod.Text.ToString();

                    if (nombreMod.Length == 0 || nombreMod.Length > 50)
                    {
                        lbErrorNomCMod.Visible = true;
                        lbNombreCMod.ForeColor = Color.Red;

                        if (nombreMod.Length == 0)
                        {
                            lbErrorNomCMod.Text = "El nombre no puede estar vacío.";
                        }
                        else if (nombreMod.Length > 50)
                        {
                            lbErrorNomCMod.Text = "El nombre es demasiado largo.";
                        }

                        nomCatMod = false;
                    }
                    else if (nombreMod.Length > 0 && !nombreMod.Equals("Nombre"))
                    {
                        lbErrorNomCMod.Text = "";
                        lbErrorNomCMod.Visible = false;
                        lbNombreCMod.ForeColor = Color.Green;
                        nomCatMod = true;
                    }
                    break;
            }
            
        }

        private void compruebaAlmacenCategoria(string opcion)
        {
            switch(opcion)
            {
                case "Añadir":
                    int almacen = cbAlmacenC.SelectedIndex;

                    if (almacen == 0)
                    {
                        lbErrorAlmC.Text = "Selecciona un almacén.";
                        lbErrorAlmC.Visible = true;
                        almCat = false;
                    }
                    else
                    {
                        lbErrorAlmC.Text = "";
                        lbErrorAlmC.Visible = false;
                        almCat = true;
                    }
                    break;
                case "Modificar":
                    int almacenMod = cbAlmacenCMod.SelectedIndex;

                    if (almacenMod == 0)
                    {
                        lbErrorAlmCMod.Text = "Selecciona un almacén.";
                        lbErrorAlmCMod.Visible = true;
                        almCatMod = false;
                    } else
                    {
                        lbErrorAlmCMod.Text = "";
                        lbErrorAlmCMod.Visible = false;
                        almCatMod = true;
                    }
                    break;
            }
            
        }


        private void filtroDatos()
        {
            if(cbDatosC.SelectedIndex != 0)
            {
                try
                {
                    string sql = "SELECT * FROM Categoria WHERE " + cbDatosC.Text + " LIKE '%' + @filtro + '%'";
                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    command.Parameters.AddWithValue("@filtro", txtFiltroC.Text);

                    SqlDataReader lector = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(lector);
                    dgvCategorias.DataSource = dt;

                    command.Dispose();
                    cnx.Close();
                } catch(Exception ex) 
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
        }
    }
}
