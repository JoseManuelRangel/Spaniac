using Spaniac.Clases;
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

namespace Spaniac.Formularios.Internos.Configuración
{
    public partial class VerPerfil : Form
    {
        /* Variable de tipo "Usuario" que recoge los datos del usuario actual. */
        Usuario usuario;

        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public VerPerfil(Usuario user)
        {
            InitializeComponent();
            this.usuario = user;

            colocaControles();
        }

        private void ModificarPerfil_MouseDown(object sender, MouseEventArgs e)
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
        /*                                GESTIÓN DE EVENTOS DEL BOTÓN SALIR                               */
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


        /*-------------------------------------------------------------------------------------------------*/
        /*                                    MÉTODOS PRIVADOS DEL FORMULARIO                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void colocaControles()
        {
            dniUser.Text = usuario.Dni;
            nombreUser.Text = usuario.Nombre;
            ap1User.Text = usuario.Ap1;
            ap2User.Text = usuario.Ap2;
            userUser.Text = usuario.User;
            claveUser.Text = usuario.Clave;
            if (usuario.Rol.Equals("Administrador"))
            {
                cbRol.SelectedIndex = 1;
            }
            else
            {
                cbRol.SelectedIndex = 2;
            }

            emailUser.Text = usuario.Email;

            byte[] img = usuario.Imagen;
            MemoryStream ms = new MemoryStream(img);
            imgUser.Image = Image.FromStream(ms);
        }
    }
}
