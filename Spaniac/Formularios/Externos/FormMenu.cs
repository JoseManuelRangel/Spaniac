using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spaniac.Formularios.FormulariosInternos;
using Spaniac.Formularios.FormulariosInternos.FormulariosProductos;
using Spaniac.Formularios.Internos.Clientes;
using Spaniac.Formularios.Internos.Almacenes;
using Spaniac.Formularios.Internos.Proveedores;
using Spaniac.Formularios.Internos.Configuración;
using Spaniac.Formularios.Externos;

namespace Spaniac.Formularios
{
    public partial class FormMenu : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* Variable de conexión a la base de datos. */
        string conexion = "server=localhost; database=Spaniac; integrated security = true";
        string userLog;

        FormCarga formCarga;

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormMenu(FormCarga carga, string usuario)
        {
            InitializeComponent();

            userLog = usuario;
            formCarga = carga;

            logoEmpresa.Image = Image.FromFile("LogoSpaniac.png");

            abrirFormEnPanel(new FormPanel());

            cargarDatosUsuario(userLog);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                    GESTIÓN DE EVENTOS DEL PANEL DE CUERPO DEL FORMULARIO                        */
        /*-------------------------------------------------------------------------------------------------*/
        private void panelCuerpo_MouseDown(object sender, MouseEventArgs e)
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
        /*                    GESTIÓN DE EVENTOS DEL PANEL IZQUIERDO DEL FORMULARIO                        */
        /*-------------------------------------------------------------------------------------------------*/
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                               GESTIÓN DE EVENTOS DEL LOGO DEL MENÚ                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                       GESTIÓN DE EVENTOS DEL BOTÓN DEL PANEL DE CONTROL                         */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnPanel_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new FormPanel());
        }
        private void btnPanel_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                            GESTIÓN DE EVENTOS DEL BOTÓN DE PRODUCTOS                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new FormProductos());
        }
        private void btnProductos_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnProductos_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                            GESTIÓN DE EVENTOS DEL BOTÓN DE ALMACENES                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnAlmacenes_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new FormAlmacenes());
        }

        private void btnAlmacenes_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAlmacenes_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                             GESTIÓN DE EVENTOS DEL BOTÓN DE CLIENTES                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new FormClientes());
        }

        private void btnClientes_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                            GESTIÓN DE EVENTOS DEL BOTÓN DE PROVEEDORES                          */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new FormProveedores());
        }

        private void btnProveedores_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                            GESTIÓN DE EVENTOS DEL BOTÓN DE CONFIGURACIÓN                        */
        /*-------------------------------------------------------------------------------------------------*/
        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new FormConfiguracion(userLog));
        }

        private void btnConfiguracion_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                              METODOS USADOS EN EL CÓDIGO DEL FORMULARIO                         */
        /*-------------------------------------------------------------------------------------------------*/
        private void abrirFormEnPanel(object formHijo)
        {
            if(this.panelCuerpo.Controls.Count > 0)
            {
                this.panelCuerpo.Controls.RemoveAt(0);
            }

            Form fi = formHijo as Form;
            fi.TopLevel = false;
            fi.Dock = DockStyle.Fill;

            this.panelCuerpo.Controls.Add(fi);
            this.panelCuerpo.Tag = fi;
            fi.Show();
        }


        private void cargarDatosUsuario(string user)
        {
            try
            {
                SqlConnection cnx = new SqlConnection(conexion);
                string sql = "SELECT * FROM Usuario WHERE usuario='" + userLog + "'";

                cnx.Open();
                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    if (lector.GetString(4).Equals(userLog))
                    {
                        byte[] img = (byte[])lector.GetValue(8);
                        MemoryStream ms = new MemoryStream(img);

                        imgPerfil.Image = Image.FromStream(ms);
                        lbUser.Text = lector.GetString(4);
                        lbRol.Text = lector.GetString(6);
                    }
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
