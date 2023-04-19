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
    public partial class Registro : Form
    {
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
        public Registro(MenuPrincipal form)
        {
            InitializeComponent();
            principal = form;
        }

        private void Registro_MouseDown(object sender, MouseEventArgs e)
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
        /*                             GESTIÓN DE EVENTOS DEL BOTÓN CANCELAR                               */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            principal.Visible = true;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                             GESTIÓN DE EVENTOS DEL TEXTBOX DE DNI                               */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtDNI_Enter(object sender, EventArgs e)
        {
            if(txtDNI.Text.Equals("DNI"))
            {
                txtDNI.Text = "";
                txtDNI.ForeColor = Color.Black;
            }
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if(txtDNI.Text.Equals(""))
            {
                txtDNI.Text = "DNI";
                txtDNI.ForeColor = Color.DarkGray;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           GESTIÓN DE EVENTOS DEL TEXTBOX DE NOMBRE                              */
        /*-------------------------------------------------------------------------------------------------*/
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
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                        GESTIÓN DE EVENTOS DEL TEXTBOX DE APELLIDO 1                             */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtAp1_Enter(object sender, EventArgs e)
        {
            if(txtAp1.Text.Equals("Apellido 1"))
            {
                txtAp1.Text = "";
                txtAp1.ForeColor = Color.Black;
            }
        }

        private void txtAp1_Leave(object sender, EventArgs e)
        {
            if(txtAp1.Text.Equals(""))
            {
                txtAp1.Text = "Apellido 1";
                txtAp1.ForeColor = Color.DarkGray;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                        GESTIÓN DE EVENTOS DEL TEXTBOX DE APELLIDO 2                             */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtAp2_Enter(object sender, EventArgs e)
        {
            if (txtAp2.Text.Equals("Apellido 2"))
            {
                txtAp2.Text = "";
                txtAp2.ForeColor = Color.Black;
            }
        }

        private void txtAp2_Leave(object sender, EventArgs e)
        {
            if (txtAp2.Text.Equals(""))
            {
                txtAp2.Text = "Apellido 2";
                txtAp2.ForeColor = Color.DarkGray;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                          GESTIÓN DE EVENTOS DEL TEXTBOX DE USUARIO                              */
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
        /*                        GESTIÓN DE EVENTOS DEL TEXTBOX DE CONTRASEÑA                             */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text.Equals("Contraseña"))
            {
                if (imgMuestra1.Image == Image.FromFile("ojoAbierto.png"))
                {
                    txtClave.UseSystemPasswordChar = false;
                }
                else
                {
                    txtClave.UseSystemPasswordChar = true;
                }

                txtClave.Text = "";
                txtClave.ForeColor = Color.Black;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text.Equals(""))
            {
                txtClave.UseSystemPasswordChar = false;
                txtClave.Text = "Contraseña";
                txtClave.ForeColor = Color.DarkGray;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                    GESTIÓN DE EVENTOS DEL TEXTBOX DE CONFIRMAR CONTRASEÑA                       */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtConfirma_Enter(object sender, EventArgs e)
        {
            if (txtConfirma.Text.Equals("Confirmar contraseña"))
            {
                if (imgMuestra2.Image == Image.FromFile("ojoAbierto.png"))
                {
                    txtConfirma.UseSystemPasswordChar = false;
                }
                else
                {
                    txtConfirma.UseSystemPasswordChar = true;
                }

                txtConfirma.Text = "";
                txtConfirma.ForeColor = Color.Black;
            }
        }

        private void txtConfirma_Leave(object sender, EventArgs e)
        {
            if(txtConfirma.Text.Equals(""))
            {
                txtConfirma.Text = "Confirmar contraseña";
                txtConfirma.ForeColor = Color.DarkGray;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           GESTIÓN DE EVENTOS DEL TEXTBOX DE EMAIL                               */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text.Equals("ejemplo123"))
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text.Equals(""))
            {
                txtEmail.Text = "ejemplo123";
                txtEmail.ForeColor = Color.DarkGray;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                   GESTIÓN DE EVENTOS DEL PICTUREBOX DE MOSTRAR CONTRASEÑA 1                     */
        /*-------------------------------------------------------------------------------------------------*/
        private void imgMuestra1_Click(object sender, EventArgs e)
        {
            if (!txtClave.Text.Equals("Contraseña"))
            {
                if (txtClave.UseSystemPasswordChar == false)
                {
                    txtClave.UseSystemPasswordChar = true;
                    imgMuestra1.Image = Image.FromFile("ojoAbierto.png");
                }
                else if (txtClave.UseSystemPasswordChar == true)
                {
                    txtClave.UseSystemPasswordChar = false;
                    imgMuestra1.Image = Image.FromFile("ojoCerrado.png");
                }
            }
        }

        private void imgMuestra1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void imgMuestra1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                   GESTIÓN DE EVENTOS DEL PICTUREBOX DE MOSTRAR CONTRASEÑA 2                     */
        /*-------------------------------------------------------------------------------------------------*/
        private void imgMuestra2_Click(object sender, EventArgs e)
        {
            if (!txtConfirma.Text.Equals("Confirma contraseña"))
            {
                if (txtConfirma.UseSystemPasswordChar == false)
                {
                    txtConfirma.UseSystemPasswordChar = true;
                    imgMuestra2.Image = Image.FromFile("ojoAbierto.png");
                }
                else if (txtConfirma.UseSystemPasswordChar == true)
                {
                    txtConfirma.UseSystemPasswordChar = false;
                    imgMuestra2.Image = Image.FromFile("ojoCerrado.png");
                }
            }
        }

        private void imgMuestra2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void imgMuestra2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
