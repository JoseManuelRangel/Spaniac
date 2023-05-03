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

namespace Spaniac.Formularios.Externos
{
    public partial class FormRecuperar : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* Ruta de conexión para la BD. */
        static string conection = "server=localhost; database=Spaniac; integrated security=true";

        /* Formulario anterior. */
        FormCodigo confirma;

        static string correoUser;

        /* Variables booleanas que comprueban que las contraseñas en los dos campos están correctamente. */
        static bool claveCorrect = false, confCorrect = false;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormRecuperar(FormCodigo form, string correo)
        {
            InitializeComponent();

            confirma = form;

            logoEmpresa.Image = Image.FromFile("LogoSpaniac.png");
            imgMuestra1.Image = Image.FromFile("ojoAbierto.png");
            imgMuestra2.Image = Image.FromFile("ojoAbierto.png");

            correoUser = correo;
        }

        private void FormRecuperar_MouseDown(object sender, MouseEventArgs e)
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
                lbClave.ForeColor = Color.Black;
                lbErrorClave.Text = "";
                lbErrorClave.Visible = false;
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            compruebaContraseña();
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
            if (txtConfirma.Text.Equals(""))
            {
                txtConfirma.UseSystemPasswordChar = false;
                txtConfirma.Text = "Confirmar contraseña";
                txtConfirma.ForeColor = Color.DarkGray;
                lbConfirma.ForeColor = Color.Black;
                lbErrorConfirma.Text = "";
                lbErrorConfirma.Visible = false;
            }
        }

        private void txtConfirma_TextChanged(object sender, EventArgs e)
        {
            compruebaConfirmacion();
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
            if (!txtConfirma.Text.Equals("Confirmar contraseña"))
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


        /*-------------------------------------------------------------------------------------------------*/
        /*                              GESTIÓN DE EVENTOS DEL BOTÓN CAMBIAR                               */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if(claveCorrect == true && confCorrect == true)
            {
                try
                {
                    string clave = txtClave.Text.ToString();

                    string sql = "UPDATE Usuario SET clave='" + clave + "' WHERE email='" + correoUser + "'";
                    SqlConnection cnx = new SqlConnection(conection);

                    cnx.Open();
                    SqlCommand command = new SqlCommand(sql, cnx);
                    command.ExecuteNonQuery();
                } catch(Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();

                } finally
                {
                    this.Close();

                    FormInicio form = new FormInicio();
                    form.Show();
                }
            }
        }

        private void btnCambiar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnCambiar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                             GESTIÓN DE EVENTOS DEL BOTÓN CANCELAR                               */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            FormInicio form = new FormInicio();
            form.Show();
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                                    MÉTODOS PRIVADOS DEL FORMULARIO                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void compruebaContraseña()
        {
            string contraseña = txtClave.Text.ToString();

            if (algoritmoContraseña(contraseña))
            {
                lbErrorClave.Text = "";
                lbErrorClave.Visible = false;

                lbClave.ForeColor = Color.Green;

                claveCorrect = true;
            }
            else if (!algoritmoContraseña(contraseña) && contraseña.Equals("Contraseña"))
            {
                lbErrorClave.Text = "";
                lbErrorClave.Visible = false;

                lbClave.ForeColor = Color.Black;

                claveCorrect = false;
            }
            else
            {
                lbErrorClave.Text = "Debe incluir mayusculas, minúsculas, signos y números siendo superior de 8 caracteres.";
                lbErrorClave.Visible = true;

                lbClave.ForeColor = Color.Red;

                claveCorrect = false;
            }
        }

        private void compruebaConfirmacion()
        {
            string conf = txtConfirma.Text.ToString();
            string contraseña = txtClave.Text.ToString();

            if (!conf.Equals(contraseña) || (conf.Equals(contraseña) && contraseña.Equals("Contraseña")))
            {
                if (!conf.Equals(contraseña))
                {
                    lbErrorConfirma.Text = "Las contraseñas deben ser iguales.";
                }
                else if (conf.Equals(contraseña) && contraseña.Equals("Contraseña"))
                {
                    lbErrorConfirma.Text = "Escribe una contraseña antes.";
                }

                lbErrorConfirma.Visible = true;

                lbConfirma.ForeColor = Color.Red;

                confCorrect = false;
            }
            else if (conf.Equals(contraseña))
            {
                lbErrorConfirma.Text = "";
                lbErrorConfirma.Visible = false;

                lbConfirma.ForeColor = Color.Green;

                confCorrect = true;
            }
            else if (!conf.Equals(contraseña) && conf.Equals("Confirmar contraseña"))
            {
                lbErrorConfirma.Text = "";
                lbErrorConfirma.Visible = false;

                lbErrorConfirma.ForeColor = Color.Black;

                confCorrect = false;
            }
        }


        private bool algoritmoContraseña(string contraseña)
        {
            bool mayus = false, minus = false, num = false, caraesp = false;
            for (int i = 0; i < contraseña.Length; i++)
            {
                if (Char.IsUpper(contraseña, i))
                {
                    mayus = true;
                }
                else if (Char.IsLower(contraseña, i))
                {
                    minus = true;
                }
                else if (Char.IsDigit(contraseña, i))
                {
                    num = true;
                }
                else
                {
                    caraesp = true;
                }
            }

            if (mayus && minus && num && caraesp && contraseña.Length >= 8 && !contraseña.Equals("Contraseña"))
            {
                return true;
            }

            return false;
        }
    }
}
