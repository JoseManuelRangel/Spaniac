using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaniac.Formularios
{
    public partial class InicioSesion : Form
    {
        /* Variable que almacena la conexión con la BD. */
        string conection = "server=localhost; database=Spaniac; integrated security = true";

        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* Variable que controla el formulario anterior para no generar nuevos formularios en caso de querer cancelar el inicio de sesión. */
        MenuPrincipal principal;

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public InicioSesion(MenuPrincipal form)
        {
            InitializeComponent();
            principal = form;
        }

        private void InicioSesion_MouseDown(object sender, MouseEventArgs e)
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
        /*                    GESTIÓN DE EVENTOS DEL PICTUREBOX DE INICIO DE SESIÓN                        */
        /*-------------------------------------------------------------------------------------------------*/
        private void lbInicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           GESTIÓN DE EVENTOS DEL TEXTBOX DE USUARIO                             */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Equals("Usuario"))
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Equals(""))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DarkGray;
            }
        }




        /*-------------------------------------------------------------------------------------------------*/
        /*                         GESTIÓN DE EVENTOS DEL TEXTBOX DE LA CLAVE                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtClave_Enter(object sender, EventArgs e)
        {
            if(txtClave.Text.Equals("Contraseña"))
            {
                if(imgMuestra.Image == Image.FromFile("ojoAbierto.png"))
                {
                    txtClave.UseSystemPasswordChar = false;
                } else
                {
                    txtClave.UseSystemPasswordChar = true;
                }

                txtClave.Text = "";
                txtClave.ForeColor = Color.Black;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if(txtClave.Text.Equals(""))
            {
                txtClave.UseSystemPasswordChar = false;
                txtClave.Text = "Contraseña";
                txtClave.ForeColor = Color.DarkGray;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                   GESTIÓN DE EVENTOS DEL PICTUREBOX DE MOSTRAR CONTRASEÑA                       */
        /*-------------------------------------------------------------------------------------------------*/
        private void imgMuestra_Click(object sender, EventArgs e)
        {
            if(!txtClave.Text.Equals("Contraseña"))
            {
                if(txtClave.UseSystemPasswordChar == false)
                {
                    txtClave.UseSystemPasswordChar = true;
                    imgMuestra.Image = Image.FromFile("ojoAbierto.png");
                } else if(txtClave.UseSystemPasswordChar == true)
                {
                    txtClave.UseSystemPasswordChar = false;
                    imgMuestra.Image = Image.FromFile("ojoCerrado.png");
                }
            }
        }

        private void imgMuestra_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void imgMuestra_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                             GESTIÓN DE EVENTOS DEL BOTÓN CANCELAR                               */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            principal.Visible = true;
        }
    }
}
