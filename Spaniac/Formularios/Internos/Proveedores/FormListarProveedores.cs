using DocumentFormat.OpenXml.Office2010.Drawing.Charts;
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

namespace Spaniac.Formularios.Internos.Proveedores
{
    public partial class FormListarProveedores : Form
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
        static List<string> listaCIFs = new List<string>();
        static List<string> listaNombres = new List<string>();
        static List<string> listaTipos = new List<string>();
        static List<string> listaFechas = new List<string>();
        static List<string> listaLocalidades = new List<string>();
        static List<string> listaDirecciones = new List<string>();
        static List<string> listaTelefonos = new List<string>();

        /* Variables que controlan en que posición de las listas nos encontramos. */
        static int registroXML = 0;
        static int registroJSON = 0;
        static int registroExcel = 0;

        /* Lista de Proveedores del fichero JSON y del fichero EXCEL. */
        List<Proveedor> proveedores = new List<Proveedor>();

        /* JSON Completo. */
        static string provJSON;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormListarProveedores(string rutaXML)
        {
            InitializeComponent();
            rutaxml = rutaXML;
            cargaXML();
            tipoArchivo = "XML";

            if (listaCIFs.Count > 0)
            {
                txtID.Text = listaCIFs[0];
                txtNombre.Text = listaNombres[0];
                txtTipoProv.Text = listaTipos[0];
                txtFecha.Text = listaFechas[0];
                txtLocalidad.Text = listaLocalidades[0];
                txtDireccion.Text = listaDirecciones[0];
                txtTelefono.Text = listaTelefonos[0];
            }
        }

        public FormListarProveedores(string jsonCompleto, List<Proveedor> listaProv)
        {
            InitializeComponent();
            provJSON = jsonCompleto;
            proveedores = listaProv;
            tipoArchivo = "JSON";

            if (proveedores.Count > 0)
            {
                txtID.Text = proveedores[0].ID.ToString();
                txtNombre.Text = proveedores[0].Nombre.ToString();
                txtTipoProv.Text = proveedores[0].TipoProveedor.ToString();
                txtFecha.Text = proveedores[0].FechaRegistro.ToString();
                txtLocalidad.Text = proveedores[0].Localidad.ToString();
                txtDireccion.Text = proveedores[0].Direccion.ToString();
                txtTelefono.Text = proveedores[0].Telefono.ToString();
            }

            for (int i = 0; i < proveedores.Count; i++)
            {
                int j = i + 1;
                Proveedor p = new Proveedor(proveedores[i].ID, proveedores[i].Nombre, proveedores[i].TipoProveedor, proveedores[i].FechaRegistro, proveedores[i].Localidad,
                    proveedores[i].Direccion, proveedores[i].Telefono);
                listadoCompleto.Text += "Proveedor " + j + ": " + Environment.NewLine + "" +
                    "ID: " + p.ID + Environment.NewLine + "Nombre: " + p.Nombre + Environment.NewLine +
                    "TipoProveedor: " + p.TipoProveedor + Environment.NewLine + "Fecha Registro: " + p.FechaRegistro + Environment.NewLine + "Localidad: " + p.Localidad
                    + Environment.NewLine + "Direccion: " + p.Direccion + Environment.NewLine + "Telefono: " + p.Telefono
                    + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
        }

        public FormListarProveedores(List<Proveedor> listaProv)
        {
            InitializeComponent();
            proveedores = listaProv;
            tipoArchivo = "EXCEL";

            if (proveedores.Count > 0)
            {
                txtID.Text = proveedores[0].ID.ToString();
                txtNombre.Text = proveedores[0].Nombre.ToString();
                txtTipoProv.Text = proveedores[0].TipoProveedor.ToString();
                txtFecha.Text = proveedores[0].FechaRegistro.ToString();
                txtLocalidad.Text = proveedores[0].Localidad.ToString();
                txtDireccion.Text = proveedores[0].Direccion.ToString();
                txtTelefono.Text = proveedores[0].Telefono.ToString();
            }

            for (int i = 0; i < proveedores.Count; i++)
            {
                int j = i + 1;
                Proveedor p = new Proveedor(proveedores[i].ID, proveedores[i].Nombre, proveedores[i].TipoProveedor, proveedores[i].FechaRegistro, proveedores[i].Localidad,
                    proveedores[i].Direccion, proveedores[i].Telefono);
                listadoCompleto.Text += "Proveedor " + j + ": " + Environment.NewLine + "" +
                    "ID: " + p.ID + Environment.NewLine + "Nombre: " + p.Nombre + Environment.NewLine +
                    "TipoProveedor: " + p.TipoProveedor + Environment.NewLine + "Fecha Registro: " + p.FechaRegistro + Environment.NewLine + "Localidad: " + p.Localidad
                    + Environment.NewLine + "Direccion: " + p.Direccion + Environment.NewLine + "Telefono: " + p.Telefono
                    + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
        }

        private void FormListarProveedores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                 GESTIÓN DE EVENTOS DEL PANEL IZQUIERDO DEL FORMULARIO                           */
        /*-------------------------------------------------------------------------------------------------*/
        private void panelIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*               GESTIÓN DE EVENTOS DEL BOTÓN QUE RETROCEDE UN REGISTRO DEL XML                    */
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
                int i = 1;

                foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
                {
                    listadoCompleto.Text += "Proveedor " + i;
                    if (n1.HasChildNodes)
                    {
                        foreach (XmlNode n2 in n1.ChildNodes)
                        {
                            switch (n2.Name)
                            {
                                case "CIF":
                                    listaCIFs.Add(n2.InnerText);
                                    break;
                                case "Nombre":
                                    listaNombres.Add(n2.InnerText);
                                    break;
                                case "TipoProveedor":
                                    listaTipos.Add(n2.InnerText);
                                    break;
                                case "FechaRegistro":
                                    listaFechas.Add(n2.InnerText);
                                    break;
                                case "Localidad":
                                    listaLocalidades.Add(n2.InnerText);
                                    break;
                                case "Direccion":
                                    listaDirecciones.Add(n2.InnerText);
                                    break;
                                case "Telefono":
                                    listaTelefonos.Add(n2.InnerText);
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
                    registroXML = listaCIFs.Count - 1;

                    cambiaControles("XML");
                    break;
                case "JSON":
                    registroJSON = proveedores.Count - 1;

                    cambiaControles("JSON");
                    break;
                case "EXCEL":
                    registroExcel = proveedores.Count - 1;

                    cambiaControles("EXCEL");
                    break;
            }
        }

        private void avanzaUno(string orden)
        {
            switch (orden)
            {
                case "XML":
                    if (registroXML < listaCIFs.Count - 1)
                    {
                        registroXML += 1;

                        cambiaControles("XML");
                    }
                    break;
                case "JSON":
                    if (registroJSON < proveedores.Count - 1)
                    {
                        registroJSON += 1;

                        cambiaControles("JSON");
                    }
                    break;
                case "EXCEL":
                    if (registroExcel < proveedores.Count - 1)
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
                    txtID.Text = listaCIFs[registroXML];
                    txtNombre.Text = listaNombres[registroXML];
                    txtTipoProv.Text = listaTipos[registroXML];
                    txtFecha.Text = listaFechas[registroXML];
                    txtLocalidad.Text = listaLocalidades[registroXML];
                    txtDireccion.Text = listaDirecciones[registroXML];
                    txtTelefono.Text = listaTelefonos[registroXML];
                    break;
                case "JSON":
                    txtID.Text = proveedores[registroJSON].ID.ToString();
                    txtNombre.Text = proveedores[registroJSON].Nombre.ToString();
                    txtTipoProv.Text = proveedores[registroJSON].TipoProveedor.ToString();
                    txtFecha.Text = proveedores[registroJSON].FechaRegistro.ToString();
                    txtLocalidad.Text = proveedores[registroJSON].Localidad.ToString();
                    txtDireccion.Text = proveedores[registroJSON].Direccion.ToString();
                    txtTelefono.Text = proveedores[registroJSON].Telefono.ToString();
                    break;
                case "EXCEL":
                    txtID.Text = proveedores[registroExcel].ID.ToString();
                    txtNombre.Text = proveedores[registroExcel].Nombre.ToString();
                    txtTipoProv.Text = proveedores[registroExcel].TipoProveedor.ToString();
                    txtFecha.Text = proveedores[registroExcel].FechaRegistro.ToString();
                    txtLocalidad.Text = proveedores[registroExcel].Localidad.ToString();
                    txtDireccion.Text = proveedores[registroExcel].Direccion.ToString();
                    txtTelefono.Text = proveedores[registroExcel].Telefono.ToString();
                    break;
            }
        }
    }
}
