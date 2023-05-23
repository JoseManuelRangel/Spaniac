using Spaniac.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaniac.Formularios.Internos.Configuración
{
    public partial class FormConfiguracion : Form
    {
        /* Variable que rescata el nombre de usuario que está conectado. */
        string usuario;

        /* Variable de conexión a la base de datos. */
        string conexion = "server=localhost; database=Spaniac; integrated security = true";

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormConfiguracion(string user)
        {
            InitializeComponent();
            usuario = user;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                        GESTION DE EVENTOS DEL TIMER DE LA HORA Y LA FECHA                       */
        /*-------------------------------------------------------------------------------------------------*/
        private void horafecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToLongDateString().ToUpper();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                              GESTION DE EVENTOS DEL BOTÓN VER PERFIL                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void verPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM Usuario WHERE usuario='" + usuario + "'";

                SqlConnection cnx = new SqlConnection(conexion);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while(lector.Read())
                {
                    string dni, nombre, ap1, ap2, user, clave, rol, email;
                    byte[] imagen;

                    dni = lector.GetString(0);
                    nombre = lector.GetString(1);
                    ap1 = lector.GetString(2);
                    ap2 = lector.GetString(3);
                    user = lector.GetString(4);
                    clave = lector.GetString(5);
                    rol = lector.GetString(6);
                    email = lector.GetString(7);
                    imagen = (byte[])lector.GetValue(8);

                    Usuario u = new Usuario(dni, nombre, ap1, ap2, user, clave, rol, email, imagen);

                    VerPerfil form = new VerPerfil(u);
                    form.Show();
                }
            } catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void verPerfil_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void verPerfil_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                            GESTION DE EVENTOS DEL BOTÓN EDITAR ROLES                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void editarRoles_Click(object sender, EventArgs e)
        {
            EditarRoles form = new EditarRoles(usuario);
            form.Show();
        }

        private void editarRoles_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void editarRoles_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                            GESTION DE EVENTOS DEL BOTÓN BORRAR ROLES                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void borrarUsuario_Click(object sender, EventArgs e)
        {
            BorrarUsers form = new BorrarUsers(usuario);
            form.Show();
        }

        private void borrarUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void borrarUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                            GESTION DE EVENTOS DEL BOTÓN CRÉDITOS                                */
        /*-------------------------------------------------------------------------------------------------*/
        private void creditos_Click(object sender, EventArgs e)
        {
            Creditos form = new Creditos();
            form.Show();
        }

        private void creditos_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void creditos_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

    }
}
