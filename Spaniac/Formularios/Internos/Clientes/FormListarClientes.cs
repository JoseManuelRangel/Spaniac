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

namespace Spaniac.Formularios.Internos.Clientes
{
    public partial class FormListarClientes : Form
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
        static List<string> listaDNIs = new List<string>();
        static List<string> listaNombres = new List<string>();
        static List<string> listaFechas = new List<string>();
        static List<string> listaLocalidades = new List<string>();
        static List<string> listaDirecciones = new List<string>();
        static List<string> listaTelefonos = new List<string>();

        /* Variables que controlan en que posición de las listas nos encontramos. */
        static int registroXML = 0;
        static int registroJSON = 0;
        static int registroExcel = 0;

        /* Lista de Clientes del fichero JSON y del fichero EXCEL. */
        List<Cliente> clientes = new List<Cliente>();

        /* JSON Completo. */
        static string cliJSON;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormListarClientes(string rutaXML)
        {
            InitializeComponent();
            rutaxml = rutaXML;
            cargaXML();
            tipoArchivo = "XML";

            if (listaDNIs.Count > 0 && listaNombres.Count > 0 && listaFechas.Count > 0
                && listaLocalidades.Count > 0 && listaDirecciones.Count > 0 && listaTelefonos.Count > 0)
            {
                txtID.Text = listaDNIs[0];
                txtNombre.Text = listaNombres[0];
                txtFecha.Text = listaFechas[0];
                txtLocalidad.Text = listaLocalidades[0];
                txtDireccion.Text = listaDirecciones[0];
                txtTelefono.Text = listaTelefonos[0];
            }
        }

        public FormListarClientes(string jsonCompleto, List<Cliente> listaCli)
        {
            InitializeComponent();
            cliJSON = jsonCompleto;
            clientes = listaCli;
            tipoArchivo = "JSON";

            if (clientes.Count > 0)
            {
                txtID.Text = clientes[0].ID.ToString();
                txtNombre.Text = clientes[0].Nombre.ToString();
                txtFecha.Text = clientes[0].FechaRegistro.ToString();
                txtLocalidad.Text = clientes[0].Localidad.ToString();
                txtDireccion.Text = clientes[0].Direccion.ToString();
                txtTelefono.Text = clientes[0].Telefono.ToString();
            }

            for (int i = 0; i < clientes.Count; i++)
            {
                int j = i + 1;
                Cliente c = new Cliente(clientes[i].ID, clientes[i].Nombre, clientes[i].FechaRegistro, clientes[i].Localidad, 
                    clientes[i].Direccion, clientes[i].Telefono);
                listadoCompleto.Text += "Cliente " + j + ": " + Environment.NewLine + "" +
                    "ID: " + c.ID + Environment.NewLine + "Nombre: " + c.Nombre + Environment.NewLine +
                    "Fecha Registro: " + c.FechaRegistro + Environment.NewLine + "Localidad: " + c.Localidad 
                    + Environment.NewLine + "Direccion: " + c.Direccion + Environment.NewLine + "Telefono: " + c.Telefono
                    + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
        }

        public FormListarClientes(List<Cliente> listaCli)
        {
            InitializeComponent();
            clientes = listaCli;
            tipoArchivo = "EXCEL";

            if (clientes.Count > 0)
            {
                txtID.Text = clientes[0].ID.ToString();
                txtNombre.Text = clientes[0].Nombre.ToString();
                txtFecha.Text = clientes[0].FechaRegistro.ToString();
                txtLocalidad.Text = clientes[0].Localidad.ToString();
                txtDireccion.Text = clientes[0].Direccion.ToString();
                txtTelefono.Text = clientes[0].Telefono.ToString();
            }

            for (int i = 0; i < clientes.Count; i++)
            {
                int j = i + 1;
                Cliente c = new Cliente(clientes[i].ID, clientes[i].Nombre, clientes[i].FechaRegistro, clientes[i].Localidad,
                    clientes[i].Direccion, clientes[i].Telefono);
                listadoCompleto.Text += "Cliente " + j + ": " + Environment.NewLine + "" +
                    "ID: " + c.ID + Environment.NewLine + "Nombre: " + c.Nombre + Environment.NewLine +
                    "Fecha Registro: " + c.FechaRegistro + Environment.NewLine + "Localidad: " + c.Localidad
                    + Environment.NewLine + "Direccion: " + c.Direccion + Environment.NewLine + "Telefono: " + c.Telefono
                    + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
        }

        private void FormListarClientes_MouseDown(object sender, MouseEventArgs e)
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

                foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
                {
                    listadoCompleto.Text += "<" + n1.Name + ">";
                    if (n1.HasChildNodes)
                    {
                        foreach (XmlNode n2 in n1.ChildNodes)
                        {
                            switch (n2.Name)
                            {
                                case "DNI":
                                    listaDNIs.Add(n2.InnerText);
                                    break;
                                case "Nombre":
                                    listaNombres.Add(n2.InnerText);
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
                    registroXML = listaDNIs.Count - 1;

                    cambiaControles("XML");
                    break;
                case "JSON":
                    registroJSON = clientes.Count - 1;

                    cambiaControles("JSON");
                    break;
                case "EXCEL":
                    registroExcel = clientes.Count - 1;

                    cambiaControles("EXCEL");
                    break;
            }
        }

        private void avanzaUno(string orden)
        {
            switch (orden)
            {
                case "XML":
                    if (registroXML < listaDNIs.Count - 1)
                    {
                        registroXML += 1;

                        cambiaControles("XML");
                    }
                    break;
                case "JSON":
                    if (registroJSON < clientes.Count - 1)
                    {
                        registroJSON += 1;

                        cambiaControles("JSON");
                    }
                    break;
                case "EXCEL":
                    if (registroExcel < clientes.Count - 1)
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
                    txtID.Text = listaDNIs[registroXML];
                    txtNombre.Text = listaNombres[registroXML];
                    txtFecha.Text = listaFechas[registroXML];
                    txtLocalidad.Text = listaLocalidades[registroXML];
                    txtDireccion.Text = listaDirecciones[registroXML];
                    txtTelefono.Text = listaTelefonos[registroXML];
                    break;
                case "JSON":
                    txtID.Text = clientes[registroJSON].ID.ToString();
                    txtNombre.Text = clientes[registroJSON].Nombre.ToString();
                    txtFecha.Text = clientes[registroJSON].FechaRegistro.ToString();
                    txtLocalidad.Text = clientes[registroJSON].Localidad.ToString();
                    txtDireccion.Text = clientes[registroJSON].Direccion.ToString();
                    txtTelefono.Text = clientes[registroJSON].Telefono.ToString();
                    break;
                case "EXCEL":
                    txtID.Text = clientes[registroExcel].ID.ToString();
                    txtNombre.Text = clientes[registroExcel].Nombre.ToString();
                    txtFecha.Text = clientes[registroExcel].FechaRegistro.ToString();
                    txtLocalidad.Text = clientes[registroExcel].Localidad.ToString();
                    txtDireccion.Text = clientes[registroExcel].Direccion.ToString();
                    txtTelefono.Text = clientes[registroExcel].Telefono.ToString();
                    break;
            }
        }

    }
}
