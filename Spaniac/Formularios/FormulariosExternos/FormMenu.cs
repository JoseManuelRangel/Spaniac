﻿using System;
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}