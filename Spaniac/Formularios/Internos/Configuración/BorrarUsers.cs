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

namespace Spaniac.Formularios.Internos.Configuración
{
    public partial class BorrarUsers : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* Ruta de conexión para la BD. */
        static string conection = "server=localhost; database=Spaniac; integrated security=true";

        /* Variable que almacena el usuario logueado. */
        static string usuario;

        /* Variable que almacena el usuario a borrar. */
        static string usBorr;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public BorrarUsers(string usLog)
        {
            InitializeComponent();

            usuario = usLog;

            lbError.Text = "Selecciona un usuario.";
            lbError.Visible = true;

            rellenaUsuarios();
        }

        private void BorrarUsers_MouseDown(object sender, MouseEventArgs e)
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
        /*                              GESTIÓN DE EVENTOS DEL COMBOBOX DE USUARIOS                        */
        /*-------------------------------------------------------------------------------------------------*/
        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbUsers.SelectedIndex != 0)
            {
                lbError.Visible = false;
                usBorr = cbUsers.Text;
                btnBorrar.Enabled = true;
            } else
            {
                lbError.Visible = true;
                usBorr = "";
                btnBorrar.Enabled = false;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           GESTIÓN DE EVENTOS DEL BOTÓN DE BORRAR ROLES                          */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnBorrar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnBorrar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                              GESTIÓN DE EVENTOS DEL BOTÓN DE SALIR                              */
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
        /*                           GESTIÓN DE EVENTOS DE LOS BOTONES SI Y NO                             */
        /*-------------------------------------------------------------------------------------------------*/
        /*                     Botón que hace que se confirme la eliminación de usuario.                   */
        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM Usuario WHERE usuario='" + usBorr + "'";
                SqlConnection cnx = new SqlConnection(conection);

                cnx.Open();
                SqlCommand command = new SqlCommand(sql, cnx);
                command.ExecuteNonQuery();

                FormNotificaciones form = new FormNotificaciones("Usuario borrado correctamente.");
                form.Show();

                this.Close();
                cnx.Close();
            } catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void btnS_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnS_Leave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*                     Botón que hace que se cancele la eliminación de usuario.                   */
        private void btnN_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnN_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnN_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }



        /*-------------------------------------------------------------------------------------------------*/
        /*                                    MÉTODOS PRIVADOS DEL FORMULARIO                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void rellenaUsuarios()
        {
            cbUsers.Items.Clear();
            cbUsers.Items.Add(" ");

            try
            {
                string sql = "SELECT * FROM Usuario";
                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while(lector.Read())
                {
                    if(!lector.GetString(4).Equals(usuario))
                    {
                        cbUsers.Items.Add(lector.GetString(4));
                    }
                }

                cnx.Close();
            } catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }
    }
}
