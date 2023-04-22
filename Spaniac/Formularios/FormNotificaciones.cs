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
    public partial class FormNotificaciones : Form
    {
        public FormNotificaciones(string mensaje)
        {
            InitializeComponent();

            /* Carga de imágenes en tiempo de ejecución. */
            logoEmpresa.Image = Image.FromFile("LogoSpaniac.png");
            panelIzquierdo.BackgroundImage = Image.FromFile("Fondo.png");

            lbDescAviso.Text = mensaje;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
