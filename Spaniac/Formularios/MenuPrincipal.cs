using Spaniac.Formularios;
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

namespace Spaniac
{
    public partial class MenuPrincipal : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* Color original de los botones */
        Color c_botones = Color.FromArgb(11, 11, 11);

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                          EVENTOS DEL LOGO PRINCIPAL DEL PROGRAMA                                */
        /*-------------------------------------------------------------------------------------------------*/
        private void logoEmpresa_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                          EVENTOS DEL PICTURE BOX PARA CERRAR PESTAÑA                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void imgCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgCerrar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void imgCerrar_MouseLeave(object sender, EventArgs e)
        {
            if (this.Cursor == Cursors.Hand)
            {
                this.Cursor = Cursors.Default;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                       EVENTOS DEL PICTURE BOX PARA MINIMIZAR PESTAÑA                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgMinimizar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void imgMinimizar_MouseLeave(object sender, EventArgs e)
        {
            if (this.Cursor == Cursors.Hand)
            {
                this.Cursor = Cursors.Default;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                              EVENTOS DEL BOTÓN DE INICIAR SESIÓN                                */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnIniciar.BackColor = Color.Black;
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            if (this.Cursor == Cursors.Hand)
            {
                this.Cursor = Cursors.Default;
            }
            btnIniciar.BackColor = c_botones;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            InicioSesion form = new InicioSesion();
            form.Show();
            this.Visible = false;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                                EVENTOS DEL BOTÓN DE REGISTRARSE                                 */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnRegistrarse_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnRegistrarse.BackColor = Color.Black;
        }

        private void btnRegistrarse_MouseLeave(object sender, EventArgs e)
        {
            if (this.Cursor == Cursors.Hand)
            {
                this.Cursor = Cursors.Default;
            }
            btnRegistrarse.BackColor = c_botones;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                                   EVENTOS DEL BOTÓN DE SALIR                                    */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnSalir.BackColor = Color.Black;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            if (this.Cursor == Cursors.Hand)
            {
                this.Cursor = Cursors.Default;
            }
            btnSalir.BackColor = c_botones;
        }


        
    }
}
