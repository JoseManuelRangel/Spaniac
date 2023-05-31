using Spaniac.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaniac.Formularios.Internos.Productos
{
    public partial class FormCategoriaXProducto : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        /* Ruta de conexión para la BD. */
        static string conection = "server=localhost; database=Spaniac; integrated security=true";



        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormCategoriaXProducto()
        {
            InitializeComponent();
            rellenaComboBox();

            EstilosTabla estilos = new EstilosTabla(dgvCatXProd);
            estilos.estiloFila();
            estilos.estiloCabecera(10);
        }

        private void FormCategoriaXProducto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                    GESTIÓN DE EVENTOS DEL PANEL IZQUIERDO DEL FORMULARIO                        */
        /*-------------------------------------------------------------------------------------------------*/
        private void panelIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           GESTIÓN DE EVENTOS DEL PANEL DE CATEGORÍAS                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void panelCat_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                        GESTIÓN DE EVENTOS DEL COMBOBOX DE ID DE CATEGORÍA                       */
        /*-------------------------------------------------------------------------------------------------*/
        private void cbIDCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIDCategoria.SelectedIndex != 0)
            {
                try
                {
                    string sql = "SELECT * FROM Categoria WHERE id=" + cbIDCategoria.Text;
                    SqlConnection cnx = new SqlConnection(conection);

                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    while(lector.Read())
                    {
                        txtNombre.Text = lector.GetString(1);
                        txtProductos.Text = lector.GetInt32(2).ToString();
                        txtIDAlmacen.Text = lector.GetInt32(3).ToString();
                    }

                    command.Dispose();
                    lector.Close();

                    sql = "SELECT id, nombre, cifProveedor FROM Producto WHERE idCategoria=" + cbIDCategoria.Text;

                    SqlCommand command2 = new SqlCommand(sql, cnx);
                    lector = command2.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(lector);
                    dgvCatXProd.DataSource = dt;

                    foreach(DataGridViewColumn col in dgvCatXProd.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }

                    command2.Dispose();
                    cnx.Close();
                } catch(Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                        GESTIÓN DE EVENTOS DEL COMBOBOX DE ID DE CATEGORÍA                       */
        /*-------------------------------------------------------------------------------------------------*/
        private void rellenaComboBox()
        {
            cbIDCategoria.Items.Add(" ");

            string sql = "SELECT * FROM Categoria";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while(lector.Read())
                {
                    cbIDCategoria.Items.Add(lector.GetInt32(0));
                }
            } catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                                 GESTIÓN DE EVENTOS DEL BOTÓN SALIR                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
