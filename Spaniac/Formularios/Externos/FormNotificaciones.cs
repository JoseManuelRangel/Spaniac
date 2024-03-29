﻿using System;
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
    public partial class FormNotificaciones : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        static string mess;

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormNotificaciones(string mensaje)
        {
            InitializeComponent();
            mess = mensaje;

            /* Carga de imágenes en tiempo de ejecución. */
            logoEmpresa.Image = Image.FromFile("LogoSpaniac.png");

            lbDescAviso.Text = mensaje;
        }

        private void FormNotificaciones_MouseDown(object sender, MouseEventArgs e)
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
        /*                                 GESTIÓN DE EVENTOS DEL BOTÓN ACEPTAR                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (mess.Equals("Usuario registrado correctamente."))
            {
                FormInicio form = new FormInicio();
                form.Show();
            }
            else if (mess.Equals("Modificación de usuario completada correctamente. Se reiniciará el programa."))
            {
                FormInicio form = new FormInicio();
                form.Show();
            }
        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }  
    }
}
