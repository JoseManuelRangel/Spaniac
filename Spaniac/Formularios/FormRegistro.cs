using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaniac.Formularios
{
    public partial class FormRegistro : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* Variable que controla el formulario anterior para no generar nuevos formularios en caso de querer cancelar el inicio de sesión. */
        FormPrincipal principal;

        static bool dniCorrect = false, nombreCorrect = false, ap1Correct = false, ap2Correct = false, usuarioCorrect = false, 
            claveCorrect = false, confCorrect = false, rolCorrect = false, emailCorrect = false, imgCorrect = false;

        bool encontrado;

        static string codigo;
        static int num1, num2, num3, num4, num5;

        string conection = "server=localhost; database=Spaniac; integrated security = true";

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormRegistro(FormPrincipal form)
        {
            InitializeComponent();
            principal = form;

            /* Carga de imágenes en tiempo de ejecución. */
            panelIzquierdo.BackgroundImage = Image.FromFile("Fondo.png");
            logoEmpresa.Image = Image.FromFile("LogoSpaniac.png");
            imgMuestra1.Image = Image.FromFile("ojoAbierto.png");
            imgMuestra2.Image = Image.FromFile("ojoAbierto.png");

            /* Inicializando errores de registro. */
            lbErrorRol.Text = "Selecciona un rol.";
            lbErrorRol.Visible = true;

            lbErrorEmail.Text = "Selecciona una extensión.";
            lbErrorEmail.Visible = true;

            lbErrorImg.Text = "Selecciona una imagen de perfil.";
            lbErrorImg.Visible = true;
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
                lbDNI.ForeColor = Color.Black;
                lbErrorDNI.Text = "";
                lbErrorDNI.Visible = false;
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            compruebaDNI();
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
                lbNombre.ForeColor = Color.Black;
                lbErrorNombre.Text = "";
                lbErrorNombre.Visible = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            compruebaNombre();
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
                lbAp1.ForeColor = Color.Black;
                lbErrorAp1.Text = "";
                lbErrorAp1.Visible = false;
            }
        }

        private void txtAp1_TextChanged(object sender, EventArgs e)
        {
            string apellido = txtAp1.Text.ToString();
            compruebaApellidos(apellido, 1);
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
                lbAp2.ForeColor = Color.Black;
                lbErrorAp2.Text = "";
                lbErrorAp2.Visible = false;
            }
        }

        private void txtAp2_TextChanged(object sender, EventArgs e)
        {
            string apellido = txtAp2.Text.ToString();
            compruebaApellidos(apellido, 2);
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
                lbUsuario.ForeColor = Color.Black;
                lbErrorUsuario.Text = "";
                lbErrorUsuario.Visible = false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            compruebaUsuario();
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
            if(txtConfirma.Text.Equals(""))
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
        /*                          GESTIÓN DE EVENTOS DEL COMBOBOX DE ROLES                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbRol.SelectedIndex != 0)
            {
                lbErrorRol.Text = "";
                lbErrorRol.Visible = false;
                rolCorrect = true;
            } else
            {
                lbErrorRol.Text = "Selecciona un rol.";
                lbErrorRol.Visible = true;
                rolCorrect = false;
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            compruebaEmail();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                   GESTIÓN DE EVENTOS DE LOS BOTONES CARGAR Y QUITAR IMAGEN                      */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnCargaImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "*.jpg | *.png";
            buscador.FileName = "";
            buscador.Title = "Cargar imagen de perfil";
            buscador.InitialDirectory = "C:\\";

            if(buscador.ShowDialog() == DialogResult.OK)
            {
                String direccion = buscador.FileName;

                imgPerfil.ImageLocation = direccion;
                imgPerfil.SizeMode = PictureBoxSizeMode.StretchImage;

                lbErrorImg.Text = "";
                lbErrorImg.Visible = false;

                imgCorrect = true;
            }
        }

        private void btnQuitaImg_Click(object sender, EventArgs e)
        {
            if (imgPerfil.Image != null)
            {
                imgPerfil.Image = null;

                lbErrorImg.Text = "Selecciona una imagen de perfil.";
                lbErrorImg.Visible = true;

                imgCorrect = false;
            }
        }

        /*-------------------------------------------------------------------------------------------------*/
        /*                                  EVENTO CLICK DEL BOTÓN REGISTRAR                               */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (dniCorrect == true && nombreCorrect == true && ap1Correct == true && ap2Correct == true && usuarioCorrect == true
                && claveCorrect == true && confCorrect == true && rolCorrect == true && emailCorrect == true && imgCorrect == true)
            {
                try
                {
                    using (MailMessage correo = new MailMessage())
                    {
                        Random r = new Random();
                        string emailCompleto = txtEmail.Text.ToString() + cbEmail.Text.ToString();
                        int num1, num2, num3, num4, num5;

                        num1 = r.Next(0, 10);
                        num2 = r.Next(0, 10);
                        num3 = r.Next(0, 10);
                        num4 = r.Next(0, 10);
                        num5 = r.Next(0, 10);

                        codigo = (num1 + "" + num2 + "" + num3 + "" + num4 + "" + num5);

                        /* Destinatario del mensaje. */
                        correo.To.Add(emailCompleto);

                        /* Asunto del mensaje. */
                        correo.Subject = "Confirmación para completar el registro de usuario en Spaniac™.";

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
                    }

                    string dni, nombre, ap1, ap2, usuario, clave, rol, email;
                    byte[] imagen;

                    dni = txtDNI.Text.ToString();
                    nombre = txtNombre.Text.ToString();
                    ap1 = txtAp1.Text.ToString();
                    ap2 = txtAp2.Text.ToString();
                    usuario = txtUsuario.Text.ToString();
                    clave = txtClave.Text.ToString();
                    rol = cbRol.Text.ToString();
                    email = txtEmail.Text.ToString();
                    imagen = convertirImagen();

                    FormCodigo form = new FormCodigo(num1, num2, num3, num4, num5,
                        dni, nombre, ap1, ap2, usuario, clave, rol, email, imagen, this);
                    form.Show();
                    this.Visible = false;
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }      
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


        /*-------------------------------------------------------------------------------------------------*/
        /*                                    MÉTODOS PRIVADOS DEL FORMULARIO                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void compruebaDNI()
        {
            string dni = txtDNI.Text.ToString();

            if(dni.Length != 9 || (dni.Length == 9 && !Char.IsLetter(dni, (dni.Length - 1))))
            {
                lbErrorDNI.Text = "DNI Inválido.";
                lbErrorDNI.Visible = true;
                lbDNI.ForeColor = Color.Red;
                dniCorrect = false;
            } else if(dni.Length == 9 && Char.IsLetter(dni, (dni.Length - 1)) && !dni.Equals("DNI"))
            {
                lbErrorDNI.Text = "";
                lbErrorDNI.Visible = false;
                lbDNI.ForeColor = Color.Green;
                dniCorrect = true;
            } else if(dni.Equals("DNI"))
            {
                lbErrorDNI.Text = "";
                lbErrorDNI.Visible = false;
                lbDNI.ForeColor = Color.Black;
                dniCorrect = false;
            }
        }

        private void compruebaNombre()
        {
            string nombre = txtNombre.Text.ToString();

            if(nombre.Length == 0 || nombre.Length > 30)
            {
                lbErrorNombre.Visible = true;
                lbNombre.ForeColor = Color.Red;

                if(nombre.Length == 0)
                {
                    lbErrorNombre.Text = "El nombre no puede estar vacío.";
                } else if(nombre.Length > 30)
                {
                    lbErrorNombre.Text = "El nombre es demasiado largo.";
                }

                nombreCorrect = false;
            } else if(nombre.Length > 0 && !nombre.Equals("Nombre"))
            {
                lbErrorNombre.Text = "";
                lbErrorNombre.Visible = false;
                lbNombre.ForeColor = Color.Green;
                nombreCorrect = true;
            } else if(nombre.Equals("Nombre"))
            {
                lbErrorNombre.Text = "";
                lbErrorNombre.Visible = false;
                lbNombre.ForeColor = Color.Black;
                nombreCorrect = false;
            }
        }

        private void compruebaApellidos(string apellido, int numAp)
        {
            switch(numAp)
            {
                case 1:
                    if (apellido.Length == 0 || apellido.Length > 20)
                    {
                        lbErrorAp1.Visible = true;
                        lbAp1.ForeColor = Color.Red;

                        if (apellido.Length == 0)
                        {
                            lbErrorAp1.Text = "El apellido no puede estar vacío.";
                        }
                        else if (apellido.Length > 20)
                        {
                            lbErrorAp1.Text = "El apellido es demasiado largo.";
                        }

                        ap1Correct = false;
                    }
                    else if (apellido.Length > 0 && !apellido.Equals("Apellido 1"))
                    {
                        lbErrorAp1.Text = "";
                        lbErrorAp1.Visible = false;
                        lbAp1.ForeColor = Color.Green;
                        ap1Correct = true;
                    }
                    else if(apellido.Equals("Apellido 1"))
                    {
                        lbErrorAp1.Text = "";
                        lbErrorAp1.Visible = false;
                        lbAp1.ForeColor = Color.Black;
                        ap1Correct = false;
                    }
                    break;
                case 2:
                    if (apellido.Length == 0 || apellido.Length > 20)
                    {
                        lbErrorAp2.Visible = true;
                        lbAp2.ForeColor = Color.Red;

                        if (apellido.Length == 0)
                        {
                            lbErrorAp2.Text = "El apellido no puede estar vacío.";
                        }
                        else if (apellido.Length > 20)
                        {
                            lbErrorAp2.Text = "El apellido es demasiado largo.";
                        }

                        ap2Correct = false;
                    }
                    else if (apellido.Length > 0 && !apellido.Equals("Apellido 2"))
                    {
                        lbErrorAp2.Text = "";
                        lbErrorAp2.Visible = false;
                        lbAp2.ForeColor = Color.Green;
                        ap2Correct = true;
                    }
                    else if (apellido.Equals("Apellido 2"))
                    {
                        lbErrorAp2.Text = "";
                        lbErrorAp2.Visible = false;
                        lbAp2.ForeColor = Color.Black;
                        ap2Correct = false;
                    }
                    break;
            }
        }

        private void compruebaUsuario()
        {
            string usuario = txtUsuario.Text.ToString();

            try
            {
                if (usuario.Length == 0 || usuario.Length > 20)
                {
                    lbErrorUsuario.Visible = true;
                    lbUsuario.ForeColor = Color.Red;

                    if (usuario.Length == 0)
                    {
                        lbErrorUsuario.Text = "El usuario no puede estar vacío.";
                    }
                    else if (usuario.Length > 20)
                    {
                        lbErrorUsuario.Text = "El usuario es demasiado largo.";
                    }

                    usuarioCorrect = false;
                }
                else if (usuario.Length > 0 && !usuario.Equals("Usuario"))
                {
                    string sql = "SELECT * FROM Usuario";

                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    while(lector.Read())
                    {
                        if(lector.GetString(4).Equals(usuario))
                        {
                            encontrado = true;
                        } else
                        {
                            encontrado = false;
                        }
                    }

                    if(encontrado == true)
                    {
                        lbErrorUsuario.Text = "El usuario ya existe.";
                        lbErrorUsuario.Visible = true;

                        lbUsuario.ForeColor = Color.Red;

                        usuarioCorrect = false;
                    } else
                    {
                        lbErrorUsuario.Text = "";
                        lbErrorUsuario.Visible = false;

                        lbUsuario.ForeColor = Color.Green;

                        usuarioCorrect = true;
                    }
                }
                else if(usuario.Equals("Usuario"))
                {
                    lbErrorUsuario.Text = "";
                    lbErrorUsuario.Visible = false;
                    lbUsuario.ForeColor = Color.Black;
                    usuarioCorrect = false;
                }
            } catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void compruebaContraseña()
        {
            string contraseña = txtClave.Text.ToString();

            if(algoritmoContraseña(contraseña))
            {
                lbErrorClave.Text = "";
                lbErrorClave.Visible = false;

                lbClave.ForeColor = Color.Green;

                claveCorrect = true;
            } else if(!algoritmoContraseña(contraseña) && contraseña.Equals("Contraseña"))
            {
                lbErrorClave.Text = "";
                lbErrorClave.Visible = false;

                lbClave.ForeColor = Color.Black;

                claveCorrect = false;
            } else
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

            if(!conf.Equals(contraseña) || (conf.Equals(contraseña) && contraseña.Equals("Contraseña")))
            {
                if(!conf.Equals(contraseña))
                {
                    lbErrorConfirma.Text = "Las contraseñas deben ser iguales.";
                } else if(conf.Equals(contraseña) && contraseña.Equals("Contraseña"))
                {
                    lbErrorConfirma.Text = "Escribe una contraseña antes.";
                }
                
                lbErrorConfirma.Visible = true;

                lbConfirma.ForeColor = Color.Red;

                confCorrect = false;
            } else if(conf.Equals(contraseña))
            {
                lbErrorConfirma.Text = "";
                lbErrorConfirma.Visible = false;

                lbConfirma.ForeColor = Color.Green;

                confCorrect = true;
            } else if(!conf.Equals(contraseña) && conf.Equals("Confirmar contraseña"))
            {
                lbErrorConfirma.Text = "";
                lbErrorConfirma.Visible = false;

                lbErrorConfirma.ForeColor = Color.Black;

                confCorrect = false;
            }
        }

        private void compruebaEmail()
        {
            int extension = cbEmail.SelectedIndex;
            if(extension == 0)
            {
                lbErrorEmail.Text = "Selecciona una extensión.";
                lbErrorEmail.Visible = true;
            } else
            {
                string email = txtEmail.Text.ToString();
                if(email.Length == 0 || email.Equals("ejemplo123"))
                {
                    if(email.Length == 0)
                    {
                        lbErrorEmail.Text = "Email vacío.";
                        lbErrorEmail.Visible = true;
                        lbEmail.ForeColor = Color.Red;
                    } else if(email.Equals("ejemplo123"))
                    {
                        lbErrorEmail.Text = "";
                        lbErrorEmail.Visible = false;
                        lbEmail.ForeColor = Color.Black;
                    }

                    emailCorrect = false;
                } else
                {
                    email += cbEmail.Text.ToString();

                    if(email.Length > 100)
                    {
                        lbErrorEmail.Text = "Error, email demasiado largo.";
                        lbErrorEmail.Visible = true;
                        lbEmail.ForeColor = Color.Red;
                    } else
                    {
                        lbErrorEmail.Text = "";
                        lbErrorEmail.Visible = false;
                        lbEmail.ForeColor = Color.Green;
                        emailCorrect = true;
                    }
                }
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

        private byte[] convertirImagen()
        {
            MemoryStream ms = new MemoryStream();

            imgPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.GetBuffer();
        }
    }
}
