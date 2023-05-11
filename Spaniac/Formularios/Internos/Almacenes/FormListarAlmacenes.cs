using Spaniac.Clases;
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
using System.Xml;

namespace Spaniac.Formularios.Internos.Almacenes
{
    public partial class FormListarAlmacenes : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* Ruta del archivo XML que queremos listar. */
        static string rutaxml;

        /* Cadena que indica si es un XML, JSON o Excel. */
        static string tipoArchivo;

        /* Listas que almacenan los datos del XML cargado y los muestra en los controles de texto. */
        static List<string> listaIDS = new List<string>();
        static List<string> listaActivos = new List<string>();
        static List<string> listaNombres = new List<string>();

        /* Variables que controlan en que posición de las listas nos encontramos. */
        static int registroXML = 0;
        static int registroJSON = 0;
        static int registroExcel = 0;

        /* Lista de Almacenes del fichero JSON. */
        List<Almacen> almacenes = new List<Almacen>();

        /* JSON Completo. */
        static string almJSON;

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormListarAlmacenes(string rutaXML)
        {
            InitializeComponent();
            rutaxml = rutaXML;
            cargaXML();
            tipoArchivo = "XML";

            if (listaIDS.Count > 0 && listaActivos.Count > 0 && listaNombres.Count > 0)
            {
                txtID.Text = listaIDS[0];
                txtActivo.Text = listaActivos[0];
                txtNombre.Text = listaNombres[0];
            }
        }

        public FormListarAlmacenes(string jsonCompleto, List<Almacen> listaAlm)
        {
            InitializeComponent();
            almJSON = jsonCompleto;
            almacenes = listaAlm;
            tipoArchivo = "JSON";

            for(int i = 0; i < almacenes.Count; i++)
            {
                int j = i + 1;
                Almacen a = new Almacen(almacenes[i].ID, almacenes[i].Activo, almacenes[i].Nombre);
                listadoCompleto.Text += "Almacen " + j + ": " + Environment.NewLine + "" +
                    "ID: " + a.ID + Environment.NewLine + "Activo: " + a.Activo + Environment.NewLine +
                    "Nombre: " + a.Nombre + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
        }

        public FormListarAlmacenes(List<Almacen> listaAlm)
        {
            InitializeComponent();
            almacenes = listaAlm;
            tipoArchivo = "EXCEL";

            for (int i = 0; i < almacenes.Count; i++)
            {
                int j = i + 1;
                Almacen a = new Almacen(almacenes[i].ID, almacenes[i].Activo, almacenes[i].Nombre);
                listadoCompleto.Text += "Almacen " + j + ": " + Environment.NewLine + "" +
                    "ID: " + a.ID + Environment.NewLine + "Activo: " + a.Activo + Environment.NewLine +
                    "Nombre: " + a.Nombre + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
        }

        private void FormXMLAlmacenes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*               GESTIÓN DE EVENTOS DEL BOTÓN QUE RETROCEDE UN REGISTRO DEL XML                    */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if(tipoArchivo.Equals("XML"))
            {
                retrocedeUno("XML");
            } else if(tipoArchivo.Equals("JSON"))
            {
                retrocedeUno("JSON");
            } else if(tipoArchivo.Equals("EXCEL"))
            {
                retrocedeUno("EXCEL");
            }
        }

        private void btnAnterior_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAnterior_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                 GESTIÓN DE EVENTOS DEL BOTÓN QUE AVANZA UN REGISTRO DEL XML                     */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (tipoArchivo.Equals("XML"))
            {
                avanzaUno("XML");
            }
            else if (tipoArchivo.Equals("JSON"))
            {
                avanzaUno("JSON");
            }
            else if (tipoArchivo.Equals("EXCEL"))
            {
                avanzaUno("EXCEL");
            }
        }

        private void btnSiguiente_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnSiguiente_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*               GESTIÓN DE EVENTOS DEL BOTÓN QUE RETROCEDE AL PRIMER REGISTRO DEL XML             */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (tipoArchivo.Equals("XML"))
            {
                primerReg("XML");
            }
            else if (tipoArchivo.Equals("JSON"))
            {
                primerReg("JSON");
            }
            else if (tipoArchivo.Equals("EXCEL"))
            {
                primerReg("EXCEL");
            }
        }

        private void btnPrimero_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnPrimero_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                 GESTIÓN DE EVENTOS DEL BOTÓN QUE AVANZA AL ÚLTIMO REGISTRO DEL XML              */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (tipoArchivo.Equals("XML"))
            {
                ultimoReg("XML");
            }
            else if (tipoArchivo.Equals("JSON"))
            {
                ultimoReg("JSON");
            }
            else if (tipoArchivo.Equals("EXCEL"))
            {
                ultimoReg("EXCEL");
            }
        }

        private void btnUltimo_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnUltimo_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                        GESTIÓN DE EVENTOS DEL BOTÓN QUE SALE DEL MENÚ XML                       */
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
        /*                                    MÉTODOS PRIVADOS DEL FORMULARIO                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void cargaXML()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(rutaxml);

                foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
                {
                    listadoCompleto.Text += "<" + n1.Name + ">";
                    if (n1.HasChildNodes)
                    {
                        foreach (XmlNode n2 in n1.ChildNodes)
                        {
                            switch (n2.Name)
                            {
                                case "ID":
                                    listaIDS.Add(n2.InnerText);
                                    break;
                                case "Activo":
                                    listaActivos.Add(n2.InnerText);
                                    break;
                                case "Nombre":
                                    listaNombres.Add(n2.InnerText);
                                    break;
                            }
                            listadoCompleto.Text += Environment.NewLine + "      <" + n2.Name + ">" + n2.InnerText + "</" + n2.Name + ">";
                        }
                    }
                    listadoCompleto.Text += Environment.NewLine + "</ " + n1.Name + ">" + Environment.NewLine + Environment.NewLine;

                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void retrocedeUno(string orden)
        {
            switch(orden)
            {
                case "XML":
                    if (registroXML > 0)
                    {
                        registroXML -= 1;

                        cambiaControles("XML");
                    }
                    break;
                case "JSON":
                    if(registroJSON > 0)
                    {
                        registroJSON -= 1;

                        cambiaControles("JSON");
                    }
                    break;
                case "EXCEL":
                    if (registroExcel > 0)
                    {
                        registroExcel -= 1;

                        cambiaControles("EXCEL");
                    }
                    break;
            }
        }

        private void primerReg(string orden)
        {
            switch (orden)
            {
                case "XML":
                    registroXML = 0;

                    cambiaControles("XML");
                    break;
                case "JSON":
                    registroJSON = 0;

                    cambiaControles("JSON");
                    break;
                case "EXCEL":
                    registroExcel = 0;

                    cambiaControles("EXCEL");
                    break;
            }
        }

        private void ultimoReg(string orden)
        {
            switch(orden)
            {
                case "XML":
                    registroXML = listaIDS.Count - 1;

                    cambiaControles("XML");
                    break;
                case "JSON":
                    registroJSON = almacenes.Count - 1;

                    cambiaControles("JSON");
                    break;
                case "EXCEL":
                    registroExcel = almacenes.Count - 1;

                    cambiaControles("EXCEL");
                    break;
            }
        }

        private void avanzaUno(string orden)
        {
            switch (orden)
            {
                case "XML":
                    if (registroXML < listaIDS.Count - 1)
                    {
                        registroXML += 1;

                        cambiaControles("XML");
                    }
                    break;
                case "JSON":
                    if (registroJSON < almacenes.Count - 1)
                    {
                        registroJSON += 1;

                        cambiaControles("JSON");
                    }
                    break;
                case "EXCEL":
                    if (registroExcel < almacenes.Count - 1)
                    {
                        registroExcel += 1;

                        cambiaControles("EXCEL");
                    }
                    break;
            }
        }

        private void cambiaControles(string orden)
        {
            switch(orden)
            {
                case "XML":
                    txtID.Text = listaIDS[registroXML];
                    txtActivo.Text = listaActivos[registroXML];
                    txtNombre.Text = listaNombres[registroXML];
                    break;
                case "JSON":
                    txtID.Text = almacenes[registroJSON].ID.ToString();
                    txtActivo.Text = almacenes[registroJSON].Activo.ToString();
                    txtNombre.Text = almacenes[registroJSON].Nombre;
                    break;
                case "EXCEL":
                    txtID.Text = almacenes[registroExcel].ID.ToString();
                    txtActivo.Text = almacenes[registroExcel].Activo.ToString();
                    txtNombre.Text = almacenes[registroExcel].Nombre.ToString();
                    break;
            }
            
        }
    }
}  

