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
    public partial class EditarRoles : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* Ruta de conexión para la BD. */
        static string conection = "server=localhost; database=Spaniac; integrated security=true";

        /* Variable que almacena el rol inicial del usuario seleccionado. */
        static string rolInicial;

        /* Variable que almacena el usuario logueado. */
        static string usuario;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public EditarRoles(string usLog)
        {
            InitializeComponent();

            usuario = usLog;

            lbError.Text = "Selecciona un usuario.";
            lbError.Visible = true;

            rellenaUsuarios();
        }

        private void EditarRoles_MouseDown(object sender, MouseEventArgs e)
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
                try
                {
                    lbError.Visible = false;

                    string sql = "SELECT * FROM Usuario WHERE usuario='" + cbUsers.Text + "'";
                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    while (lector.Read())
                    {
                        rolInicial = lector.GetString(6);

                        if (lector.GetString(6).Equals("Administrador"))
                        {
                            cAdm.Checked = true;
                            cEmp.Checked = false;
                        } else
                        {
                            cEmp.Checked = true;
                            cAdm.Checked = false;
                        }
                    }

                    cnx.Close();
                }
                catch (Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            } else
            {
                lbError.Visible = true;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                  GESTIÓN DE EVENTOS DE LOS CHECKBOX DE LOS ROLES DE USUARIO                     */
        /*-------------------------------------------------------------------------------------------------*/
        private void cAdm_CheckedChanged(object sender, EventArgs e)
        {
            if(cAdm.Checked)
            {
                cEmp.Checked = false;

                if(!rolInicial.Equals("Administrador"))
                {
                    btnModRol.Enabled = true;
                } else
                {
                    btnModRol.Enabled = false;
                }
            }
        }

        private void cEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (cEmp.Checked)
            {
                cAdm.Checked = false;

                if (!rolInicial.Equals("Empleado"))
                {
                    btnModRol.Enabled = true;
                } else
                {
                    btnModRol.Enabled = false;
                }
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           GESTIÓN DE EVENTOS DEL BOTÓN DE MODIFICAR ROLES                       */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnModRol_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnModRol_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnModRol_MouseLeave(object sender, EventArgs e)
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
        /*               Botón que hace que se confirme la modificación del rol de usuario.                */
        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
                string rol;
                if(cAdm.Checked)
                {
                    rol = cAdm.Text;
                } else
                {
                    rol = cEmp.Text;
                }

                string sql = "UPDATE Usuario SET rol='" + rol + "' WHERE usuario='" + cbUsers.Text + "'";
                SqlConnection cnx = new SqlConnection(conection);

                cnx.Open();
                SqlCommand command = new SqlCommand(sql, cnx);
                command.ExecuteNonQuery();

                FormNotificaciones form = new FormNotificaciones("Rol modificado correctamente.");
                form.Show();

                this.Close();
                cnx.Close();
            } 
            catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void btnS_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnS_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*                Botón que hace que se cancele la modificación del rol de usuario.                */
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
            } catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }
    }
}
