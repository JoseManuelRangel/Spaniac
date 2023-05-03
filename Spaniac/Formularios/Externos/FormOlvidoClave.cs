using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaniac.Formularios.Externos
{
    public partial class FormOlvidoClave : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        static bool corCorrecto = false;
        static bool encontrado = false;

        /* Ruta de conexión para la base de datos. */
        string conection = "server=localhost; database=Spaniac; integrated security = true";

        /* Variables que registran el código y sus 5 números. */
        static string codigo;
        static int num1, num2, num3, num4, num5;

        /* Variable que controla el formulario anterior para no generar nuevos formulario*/
        FormInicio inicio;

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormOlvidoClave(FormInicio form)
        {
            InitializeComponent();

            inicio = form;

            logoEmpresa.Image = Image.FromFile("LogoSpaniac.png");
            imgCorreo.Image = Image.FromFile("persona.png");

            btnEnviar.Enabled = false;
        }

        private void FormOlvidoClave_MouseDown(object sender, MouseEventArgs e)
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
        /*                           GESTIÓN DE EVENTOS DEL TEXTBOX DE CORREO                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals("Dirección de correo electrónico"))
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals(""))
            {
                txtCorreo.Text = "Dirección de correo electrónico";
                txtCorreo.ForeColor = Color.DarkGray;
                lbCorreo.ForeColor = Color.Black;
                lbError.Text = "";
                lbError.Visible = false;
            }
        } 

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            compruebaCorreo();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                               GESTIÓN DE EVENTOS DEL BOTÓN CANCELAR                             */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(corCorrecto == true)
            {
                try
                {
                    using (MailMessage correo = new MailMessage())
                    {
                        Random r = new Random();
                        string email = txtCorreo.Text.ToString();

                        num1 = r.Next(0, 10);
                        num2 = r.Next(0, 10);
                        num3 = r.Next(0, 10);
                        num4 = r.Next(0, 10);
                        num5 = r.Next(0, 10);

                        codigo = (num1 + "" + num2 + "" + num3 + "" + num4 + "" + num5);

                        /* Destinatario del mensaje. */
                        correo.To.Add(email);

                        /* Asunto del mensaje. */
                        correo.Subject = "Confirmación para modificar la contraseña de usuario en Spaniac™.";

                        /* Cuerpo del mensaje. */
                        correo.Body = "El código que debes introducir es: " + codigo;
                        correo.IsBodyHtml = false;

                        /* Remitente del mensaje */
                        correo.From = new MailAddress("rangelmunozjosemanuel@gmail.com", "Spaniac™");

                        using (SmtpClient cliente = new SmtpClient())
                        {
                            /* Contraseñas */
                            cliente.UseDefaultCredentials = false;
                            cliente.Credentials = new NetworkCredential("rangelmunozjosemanuel@gmail.com", "lwaxtqchwjvtqwjp");
                            cliente.Port = 587;
                            cliente.EnableSsl = true;

                            /* Host */
                            cliente.Host = "smtp.gmail.com";
                            cliente.Send(correo);

                        }

                        FormCodigo form = new FormCodigo(num1, num2, num3, num4, num5, email, this);
                        form.Show();
                        this.Visible = false;
                    }
                } catch(Exception ex) 
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
        }

        private void btnEnviar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnEnviar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                               GESTIÓN DE EVENTOS DEL BOTÓN CANCELAR                             */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            if(inicio != null)
            {
                inicio.Visible = true;
            } else
            {
                FormInicio form = new FormInicio();
                form.Show();
            }  
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
        private void compruebaCorreo()
        {
            string correo = txtCorreo.Text.ToString();

            try
            {
                if (correo.Length == 0 || correo.Length > 200)
                {
                    lbError.Visible = true;

                    if (correo.Length == 0)
                    {
                        lbError.Text = "El correo no puede estar vacío.";
                    }
                    else if (correo.Length > 200)
                    {
                        lbError.Text = "El correo es demasiado largo.";
                    }

                    corCorrecto = false;
                    btnEnviar.Enabled = false;
                }
                else if (correo.Length > 0 && !correo.Equals("Dirección de correo electrónico"))
                {
                    string sql = "SELECT * FROM Usuario";

                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    while (lector.Read())
                    {
                        if (lector.GetString(7).Equals(correo))
                        {
                            encontrado = true;
                        }
                        else
                        {
                            encontrado = false;
                        }
                    }

                    if (encontrado == true)
                    {
                        lbError.Text = "";
                        lbError.Visible = false;

                        lbCorreo.ForeColor = Color.Green;

                        corCorrecto = true;
                        btnEnviar.Enabled = true;
                    }
                    else
                    {
                        lbError.Text = "El correo no existe.";
                        lbError.Visible = true;

                        lbCorreo.ForeColor = Color.Red;

                        corCorrecto = false;
                        btnEnviar.Enabled = false;
                    }
                }
                else if (correo.Equals("Dirección de correo electrónico"))
                {
                    lbError.Text = "";
                    lbError.Visible = false;
                    lbCorreo.ForeColor = Color.Black;
                    corCorrecto = false;
                    btnEnviar.Enabled = false;
                }
            } catch(Exception ex) 
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }    
        }

        
    }
}
