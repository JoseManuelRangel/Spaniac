using DocumentFormat.OpenXml.Wordprocessing;
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

namespace Spaniac.Formularios.Internos.Productos
{
    public partial class FormListarCategorias : Form
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
        static List<int> listaIDS = new List<int>();
        static List<string> listaNombres = new List<string>();
        static List<int> listaProductos = new List<int>();
        static List<int> listaIDAlmacenes = new List<int>();

        /* Variables que controlan en que posición de las listas nos encontramos. */
        static int registroXML = 0;
        static int registroJSON = 0;
        static int registroExcel = 0;

        /* Lista de Categorias del fichero JSON y del fichero EXCEL. */
        List<Categoria> categorias = new List<Categoria>();

        /* JSON Completo. */
        static string catJSON;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormListarCategorias(string rutaXML)
        {
            InitializeComponent();
            rutaxml = rutaXML;
            cargaXML();
            tipoArchivo = "XML";

            if(listaIDS.Count > 0)
            {
                txtID.Text = listaIDS[0].ToString();
                txtNombre.Text = listaNombres[0].ToString();
                txtProductos.Text = listaProductos[0].ToString();
                txtIDAlmacen.Text = listaIDAlmacenes[0].ToString();
            }
        }

        public FormListarCategorias(string jsonCompleto, List<Categoria> listaCat)
        {
            InitializeComponent();
            catJSON = jsonCompleto;
            categorias = listaCat;
            tipoArchivo = "JSON";

            if (categorias.Count > 0)
            {
                txtID.Text = categorias[0].ID.ToString();
                txtNombre.Text = categorias[0].Nombre.ToString();
                txtProductos.Text = categorias[0].Productos.ToString();
                txtIDAlmacen.Text = categorias[0].IdAlmacen.ToString();
            }

            for (int i = 0; i < categorias.Count; i++)
            {
                int j = i + 1;
                Categoria c = new Categoria(categorias[i].ID, categorias[i].Nombre, categorias[i].Productos, categorias[i].IdAlmacen);
                listadoCompleto.Text += "Categoria " + j + ": " + Environment.NewLine + "" +
                    "ID: " + c.ID + Environment.NewLine + "Nombre: " + c.Nombre + Environment.NewLine +
                    "Productos: " + c.Productos + Environment.NewLine + "ID Almacen: " + c.IdAlmacen
                    + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
        }

        public FormListarCategorias(List<Categoria> listaCat)
        {
            InitializeComponent();
            categorias = listaCat;
            tipoArchivo = "EXCEL";

            if (categorias.Count > 0)
            {
                txtID.Text = categorias[0].ID.ToString();
                txtNombre.Text = categorias[0].Nombre.ToString();
                txtProductos.Text = categorias[0].Productos.ToString();
                txtIDAlmacen.Text = categorias[0].IdAlmacen.ToString();
            }

            for (int i = 0; i < categorias.Count; i++)
            {
                int j = i + 1;
                Categoria c = new Categoria(categorias[i].ID, categorias[i].Nombre, categorias[i].Productos, categorias[i].IdAlmacen);
                listadoCompleto.Text += "Categoria " + j + ": " + Environment.NewLine + "" +
                    "ID: " + c.ID + Environment.NewLine + "Nombre: " + c.Nombre + Environment.NewLine +
                    "Productos: " + c.Productos + Environment.NewLine + "ID Almacen: " + c.IdAlmacen
                    + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
        }

        private void FormListarCategorias_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                     GESTIÓN DE EVENTOS DEL BOTÓN QUE RETROCEDE UN REGISTRO                       */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (tipoArchivo.Equals("XML"))
            {
                retrocedeUno("XML");
            }
            else if (tipoArchivo.Equals("JSON"))
            {
                retrocedeUno("JSON");
            }
            else if (tipoArchivo.Equals("EXCEL"))
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
        /*                       GESTIÓN DE EVENTOS DEL BOTÓN QUE AVANZA UN REGISTRO                         */
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
        /*                   GESTIÓN DE EVENTOS DEL BOTÓN QUE RETROCEDE AL PRIMER REGISTRO                   */
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
        /*                     GESTIÓN DE EVENTOS DEL BOTÓN QUE AVANZA AL ÚLTIMO REGISTRO                  */
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
        /*                        GESTIÓN DE EVENTOS DEL BOTÓN QUE SALE DEL MENÚ                           */
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
                int i = 1;

                foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
                {
                    listadoCompleto.Text += "Categoria " + i;
                    if (n1.HasChildNodes)
                    {
                        foreach (XmlNode n2 in n1.ChildNodes)
                        {
                            switch (n2.Name)
                            {
                                case "ID":
                                    listaIDS.Add(int.Parse(n2.InnerText));
                                    break;
                                case "Nombre":
                                    listaNombres.Add(n2.InnerText);
                                    break;
                                case "Productos":
                                    listaProductos.Add(int.Parse(n2.InnerText));
                                    break;
                                case "IDAlmacen":
                                    listaIDAlmacenes.Add(int.Parse(n2.InnerText));
                                    break;
                            }
                            listadoCompleto.Text += Environment.NewLine + n2.Name + ": " + n2.InnerText;
                        }
                    }
                    listadoCompleto.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine;
                    i++;
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
            switch (orden)
            {
                case "XML":
                    if (registroXML > 0)
                    {
                        registroXML -= 1;

                        cambiaControles("XML");
                    }
                    break;
                case "JSON":
                    if (registroJSON > 0)
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
            switch (orden)
            {
                case "XML":
                    registroXML = listaIDS.Count - 1;

                    cambiaControles("XML");
                    break;
                case "JSON":
                    registroJSON = categorias.Count - 1;

                    cambiaControles("JSON");
                    break;
                case "EXCEL":
                    registroExcel = categorias.Count - 1;

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
                    if (registroJSON < categorias.Count - 1)
                    {
                        registroJSON += 1;

                        cambiaControles("JSON");
                    }
                    break;
                case "EXCEL":
                    if (registroExcel < categorias.Count - 1)
                    {
                        registroExcel += 1;

                        cambiaControles("EXCEL");
                    }
                    break;
            }
        }

        private void cambiaControles(string orden)
        {
            switch (orden)
            {
                case "XML":
                    txtID.Text = listaIDS[registroXML].ToString();
                    txtNombre.Text = listaNombres[registroXML];
                    txtProductos.Text = listaProductos[registroXML].ToString();
                    txtIDAlmacen.Text = listaIDAlmacenes[registroXML].ToString();
                    break;
                case "JSON":
                    txtID.Text = categorias[registroJSON].ID.ToString();
                    txtNombre.Text = categorias[registroJSON].Nombre.ToString();
                    txtProductos.Text = categorias[registroJSON].Productos.ToString();
                    txtIDAlmacen.Text = categorias[registroJSON].IdAlmacen.ToString();
                    break;
                case "EXCEL":
                    txtID.Text = categorias[registroExcel].ID.ToString();
                    txtNombre.Text = categorias[registroExcel].Nombre.ToString();
                    txtProductos.Text = categorias[registroExcel].Productos.ToString();
                    txtIDAlmacen.Text = categorias[registroExcel].IdAlmacen.ToString();
                    break;
            }
        }
    }
}
