using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaniac.Formularios.Internos.Configuración
{
    public partial class FormConfiguracion : Form
    { 

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormConfiguracion()
        {
            InitializeComponent();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                        GESTION DE EVENTOS DEL TIMER DE LA HORA Y LA FECHA                       */
        /*-------------------------------------------------------------------------------------------------*/
        private void horafecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToLongDateString().ToUpper();
        }
    }
}
