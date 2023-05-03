using Spaniac.Formularios.Externos;
using Spaniac.Modelos;
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
    public partial class FormCodigo : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        string orden;
        static string correoUser;

        /* Formulario anterior. */
        FormRegistro registro;

        /* Formulario anterior 2. */
        FormOlvidoClave recuperar;

        /* Variables booleanas que controlan si se han rellenado los tramos de código del formulario. */
        static bool c1 = false, c2 = false, c3 = false, c4 = false, c5 = false;

        /* Números del código generado. */
        static int numero1, numero2, numero3, numero4, numero5;

        /* Datos de inserción del usuario que entra en la verificación de registro. */
        string dni, nombre, ap1, ap2, usuario, clave, rol, email;
        byte[] imagen;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormCodigo(int num1, int num2, int num3, int num4, int num5,
            string campo1, string campo2, string campo3, string campo4, string campo5, string campo6,
            string campo7, string campo8, byte[] campo9, FormRegistro form)
        {
            InitializeComponent();
            registro = form;

            logoEmpresa.Image = Image.FromFile("LogoSpaniac.png");
            bloqueoCodigo.Image = Image.FromFile("Candado.png");

            numero1 = num1;
            numero2 = num2;
            numero3 = num3;
            numero4 = num4;
            numero5 = num5;

            dni = campo1;
            nombre = campo2;
            ap1 = campo3;
            ap2 = campo4;
            usuario = campo5;
            clave = campo6;
            rol = campo7;
            email = campo8;
            imagen = campo9;

            lbTitulo.Text = "CONFIRMACIÓN";
            descripcion.Text = "Antes de completar el registro de la cuenta, tenemos que mandar al correo electrónico proporcionado" +
                "un código de verificación para completar el registro. Desbloquea el candado pinchando sobre él e introduce los 5 " +
                "números del código generado.";

            orden = "Registro";
        }

        public FormCodigo(int num1, int num2, int num3, int num4, int num5, string correo, FormOlvidoClave form)
        {
            InitializeComponent();
            recuperar = form;

            logoEmpresa.Image = Image.FromFile("LogoSpaniac.png");
            bloqueoCodigo.Image = Image.FromFile("Candado.png");

            numero1 = num1;
            numero2 = num2;
            numero3 = num3;
            numero4 = num4;
            numero5 = num5;

            correoUser = correo;

            lbTitulo.Text = "RECUPERACIÓN";
            descripcion.Text = "Antes de recuperar tu contraseña, tenemos que mandar al correo electrónico un código de verificación " +
                "para completar la recuperación. Desbloquea el candado pinchando sobre él e introduce los números " +
                "del código generado.";

            orden = "Recuperar";
        }

        private void FormCodigo_MouseDown(object sender, MouseEventArgs e)
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
        /*                      GESTIÓN DE EVENTOS DEL PANEL DE BLOQUEO DE CÓDIGO                          */
        /*-------------------------------------------------------------------------------------------------*/
        private void panelBloqueo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*             GESTIÓN DE EVENTOS DEL PICTUREBOX DEL CANDADO QUE DESBLOQUEA EL CÓDIGO              */
        /*-------------------------------------------------------------------------------------------------*/
        private void bloqueoCodigo_Click(object sender, EventArgs e)
        {
            panelBloqueo.Visible = false;
        }

        private void bloqueoCodigo_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bloqueoCodigo_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                 GESTIÓN DE EVENTOS DE LOS MASKTEXTBOX DE LOS NÚMEROS DEL CÓDIGO                 */
        /*-------------------------------------------------------------------------------------------------*/
        private void codigo1_TextChanged(object sender, EventArgs e)
        {
            if (codigo1.Text.Length == 1)
            {
                c1 = true;
            }

            habilitaAceptar();
        }

        private void codigo2_TextChanged(object sender, EventArgs e)
        {
            if (codigo2.Text.Length == 1)
            {
                c2 = true;
            }

            habilitaAceptar();
        }

        private void codigo3_TextChanged(object sender, EventArgs e)
        {
            if (codigo3.Text.Length == 1)
            {
                c3 = true;
            }

            habilitaAceptar();
        }

        private void codigo4_TextChanged(object sender, EventArgs e)
        {
            if (codigo4.Text.Length == 1)
            {
                c4 = true;
            }

            habilitaAceptar();
        }

        private void codigo5_TextChanged(object sender, EventArgs e)
        {
            if (codigo5.Text.Length == 1)
            {
                c5 = true;
            }

            habilitaAceptar();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                        GESTIÓN DE EVENTOS DEL BOTÓN ACEPTAR REGISTRO                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            funcionBotonAceptar(orden);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                               GESTIÓN DE EVENTOS DEL BOTÓN CANCELAR                             */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {     
            this.Close();

            if(registro != null)
            {
                registro.Visible = true;
            } else
            {
                FormInicio form = new FormInicio();
                form.Show();
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                                         MÉTODOS VARIOS USADOS                                   */
        /*-------------------------------------------------------------------------------------------------*/
        private void habilitaAceptar()
        {
            if(c1 == true && c2 == true && c3 == true && c4 == true && c5 == true)
            {
                btnAceptar.Enabled = true;
            }
        }

        private bool compruebaCodigo()
        {
            int n1, n2, n3, n4, n5;

            n1 = int.Parse(codigo1.Text.ToString());
            n2 = int.Parse(codigo2.Text.ToString());
            n3 = int.Parse(codigo3.Text.ToString());
            n4 = int.Parse(codigo4.Text.ToString());
            n5 = int.Parse(codigo5.Text.ToString());

            if (n1.Equals(numero1) && n2.Equals(numero2) && n3.Equals(numero3) && n4.Equals(numero4) && n5.Equals(numero5))
            {
                return true;
            } else {
                return false;
            }
        }

        private void funcionBotonAceptar(string orden)
        {
            switch(orden)
            {
                case "Registro":
                    int cod1, cod2, cod3, cod4, cod5;

                    cod1 = int.Parse(codigo1.Text.ToString());
                    cod2 = int.Parse(codigo2.Text.ToString());
                    cod3 = int.Parse(codigo3.Text.ToString());
                    cod4 = int.Parse(codigo4.Text.ToString());
                    cod5 = int.Parse(codigo5.Text.ToString());

                    if (cod1 == numero1 && cod2 == numero2 && cod3 == numero3 && cod4 == numero4 && cod5 == numero5)
                    {
                        DatosUsuario datosNuevoUser = new DatosUsuario();
                        datosNuevoUser.Dni = dni;
                        datosNuevoUser.Nombre = nombre;
                        datosNuevoUser.Ap1 = ap1;
                        datosNuevoUser.Ap2 = ap2;
                        datosNuevoUser.Usuario = usuario;
                        datosNuevoUser.Clave = clave;
                        datosNuevoUser.Rol = rol;
                        datosNuevoUser.Email = email;
                        datosNuevoUser.Imagen = imagen;
                        datosNuevoUser.guardarCambios();

                        FormNotificaciones form = new FormNotificaciones("Usuario registrado correctamente.");
                        form.Show();
                        this.Close();
                    }

                    break;
                case "Recuperar":
                    int rec1, rec2, rec3, rec4, rec5;

                    rec1 = int.Parse(codigo1.Text.ToString());
                    rec2 = int.Parse(codigo2.Text.ToString());
                    rec3 = int.Parse(codigo3.Text.ToString());
                    rec4 = int.Parse(codigo4.Text.ToString());
                    rec5 = int.Parse(codigo5.Text.ToString());

                    if(rec1 == numero1 && rec2 == numero2 && rec3 == numero3 && rec4 == numero4 &&  rec5 == numero5)
                    {
                        FormRecuperar form = new FormRecuperar(this, correoUser);
                        form.Show();
                        this.Visible = false;
                    }

                    break;
            }
        }
    }
}
