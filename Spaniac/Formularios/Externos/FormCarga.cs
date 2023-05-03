using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaniac.Formularios
{
    public partial class FormCarga : Form
    {
        /* Cadena que representa el usuario que se ha logueado. */
        string user;

        /* Formulario que representa el formulario anterior. */
        FormInicio login;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormCarga(FormInicio formInicio, string usuario)
        {
            InitializeComponent();

            logoEmpresa.Image = Image.FromFile("LogoSpaniac.png");

            login = formInicio;
            user = usuario;

            aparece.Start();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                  GESTIÓN DE EVENTOS DEL TIMER QUE HACE APARECER EL FORMULARIO                   */
        /*-------------------------------------------------------------------------------------------------*/
        private void aparece_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1)
            {
                this.Opacity += 0.02;
            }

            barra.Value += 1;
            
            if(barra.Value == 100)
            {
                aparece.Stop();
                this.Visible = false;

                FormMenu form = new FormMenu(this, user);
                form.Show();
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                 GESTIÓN DE EVENTOS DEL TIMER QUE HACE DESAPARECER EL FORMULARIO                 */
        /*-------------------------------------------------------------------------------------------------*/
        private void desaparece_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                desaparece.Stop();
                this.Close();
            }
        }
    }
}
