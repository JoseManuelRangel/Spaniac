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

namespace Spaniac.Formularios
{
    public partial class FormCodigo : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* Formulario anterior. */
        FormRegistro registro;

        /* Variables booleanas que controlan si se han rellenado los tramos de código del formulario. */
        bool c1 = false, c2 = false, c3 = false, c4 = false, c5 = false;

        /* Números del código generado. */
        int numero1, numero2, numero3, numero4, numero5;

        string dni, nombre, ap1, ap2, usuario, clave, rol, email;
        byte[] imagen;

       
        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormCodigo(int num1, int num2, int num3, int num4, int num5,
            string campo1, string campo2, string campo3, string campo4, string campo5, string campo6,
            string campo7, string campo8, byte[] campo9, FormRegistro form)
        {
            InitializeComponent();
            registro = form;

            numero1 = num1;
            numero2 = num2;
            numero3 = num3;
            numero4 = num4;
            numero5 = num5;



            lbTitulo.Text = "CONFIRMACIÓN";
            descripcion.Text = "Antes de completar el registro de la cuenta, tenemos que mandar al correo electrónico proporcionado" +
                "un código de verificación para completar el registro. Desbloquea el candado pinchando sobre él e introduce los 5 " +
                "números del código generado.";
        }

        private void FormCodigo_MouseDown(object sender, MouseEventArgs e)
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
        /*                      GESTIÓN DE EVENTOS DEL PANEL DE BLOQUEO DE CÓDIGO                          */
        /*-------------------------------------------------------------------------------------------------*/
        private void panelBloqueo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*             GESTIÓN DE EVENTOS DEL PICTUREBOX DEL CANDADO QUE DESBLOQUEA EL CÓDIGO              */
        /*-------------------------------------------------------------------------------------------------*/
        private void bloqueoCodigo_Click(object sender, EventArgs e)
        {
            panelBloqueo.Visible = false;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                 GESTIÓN DE EVENTOS DE LOS MASKTEXTBOX DE LOS NÚMEROS DEL CÓDIGO                 */
        /*-------------------------------------------------------------------------------------------------*/
        private void codigo1_MaskChanged(object sender, EventArgs e)
        {
            if (codigo1.Text.Length == 1)
            {
                c1 = true;
            }

            habilitaAceptar();
        }

        private void codigo2_MaskChanged(object sender, EventArgs e)
        {
            if (codigo2.Text.Length == 1)
            {
                c2 = true;
            }

            habilitaAceptar();
        }

        private void codigo3_MaskChanged(object sender, EventArgs e)
        {
            if (codigo3.Text.Length == 1)
            {
                c3 = true;
            }

            habilitaAceptar();
        }

        private void codigo4_MaskChanged(object sender, EventArgs e)
        {
            if (codigo4.Text.Length == 1)
            {
                c4 = true;
            }

            habilitaAceptar();
        }

        private void codigo5_MaskChanged(object sender, EventArgs e)
        {
            if (codigo5.Text.Length == 1)
            {
                c5 = true;
            }

            habilitaAceptar();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                        GESTIÓN DE EVENTOS DEL BOTÓN ACEPTAR REGISTRO                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                               GESTIÓN DE EVENTOS DEL BOTÓN CANCELAR                             */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            registro.Visible = true;
            this.Close();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                                         MÉTODOS VARIOS USADOS                                   */
        /*-------------------------------------------------------------------------------------------------*/
        private void habilitaAceptar()
        {
            if(c1 && c2 && c3 && c4 && c5)
            {
                btnAceptar.Enabled = true;
            }
        }

        private bool compruebaCodigo()
        {
            int n1, n2, n3, n4, n5;

            n1 = int.Parse(codigo1.Text.ToString());
            n2 = int.Parse(codigo2.Text.ToString());
            n3 = int.Parse(codigo3.Text.ToString());
            n4 = int.Parse(codigo4.Text.ToString());
            n5 = int.Parse(codigo5.Text.ToString());

            if (n1.Equals(numero1) && n2.Equals(numero2) && n3.Equals(numero3) && n4.Equals(numero4) && n5.Equals(numero5))
            {
                return true;
            } else {
                return false;
            }
        }
    }
}
