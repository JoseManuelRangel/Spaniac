using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
using Spaniac.Clases;
using Spaniac.Formularios.Internos.Clientes;
using Spaniac.Formularios.Internos.Productos;
using Spaniac.Modelos;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Spaniac.Formularios.FormulariosInternos.FormulariosProductos
{
    public partial class FormProductos : Form
    {
        /* Ruta de conexión para la BD. */
        static string conection = "server=localhost; database=Spaniac; integrated security=true";

        /* Variables booleanas que controlan si los datos de la categoría están rellenos para realizar la inserción. */
        bool nomCat = false, almCat = false;

        /* Variables booleanas que controlan si los datos de la categoría están rellenos para realizar la modificación. */
        bool idCatMod = false, nomCatMod = false, almCatMod = false;

        /* Variables booleanas que controlan si los datos de la categoría están rellenos para realizar el borrado. */
        bool idCatBorr = false;

        /* Variable que comprueba que es válido borrar la categoría seleccionada. */
        bool valido;

        /* Variables booleanas estáticas que controlan si los paneles están visibles o no. */
        static bool pExcel = false, pJson = false, pXml = false;

        /* Listas. */
        static List<string> nodosXML = new List<string>();

        /* Variable cadena que almacena el JSON cargado. */
        static string categoriasJSON;

        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormProductos()
        {
            InitializeComponent();

            rellenaTablaCategorias();
            rellenaComboBoxAlmacenes();
            rellenaCbDatosCategoria();
            rellenaComboBoxIDCat();

            panelPortada.Visible = true;

            /* Elementos del panel derecho de la sección de categorías. */
            imgLimpiar.Image = Image.FromFile("Goma.png");

            /* Elementos del subpanel de adición de categorías. */
            lbErrorAlmC.Text = "Selecciona un almacén.";
            lbErrorAlmC.Visible = true;

            /* Elementos del subpanel de modificación de categorías. */
            lbErrorIdCMod.Text = "Selecciona un ID para buscar categoría a editar.";
            lbErrorIdCMod.Visible = true;

            txtNombreCMod.Enabled = false;
            txtProdCMod.Enabled = false;
            cbAlmacenCMod.Enabled = false;


            /* Elementos del subpanel de borrado de categorías. */
            lbErrorIdCBorr.Text = "Selecciona un ID para buscar categoría a borrar.";
            lbErrorIdCBorr.Visible = true;

            btnAceptaCBorr.Enabled = false;
            panelConfBorr.Visible = false;

            EstilosTabla estilos = new EstilosTabla(this.dgvCategorias);
            estilos.estiloCabecera();
            estilos.estiloFila();
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
        /*                             GESTION DE EVENTOS DEL BOTÓN DE CATEGORÍAS                          */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            panelCategorias.Visible = true;
        }

        /*-------------------------------------------------------------------------------------------------*/
        /*                      GESTIÓN DE EVENTOS DEL BOTÓN DEL MENÚ XML DE CATEGORÍAS                    */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnMenuXml_Click(object sender, EventArgs e)
        {
            if(pXml == false)
            {
                panelMenuXml.Visible = true;
                pXml = true;
            } else
            {
                panelMenuXml.Visible = false;
                pXml = false;
            }
        }

        private void btnMenuXml_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnMenuXml_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        /*                   Gestión de eventos del botón generar XML del menú XML de categorías                 */
        private void btnGenXML_Click(object sender, EventArgs e)
        {
            generaXmlCategorias();
        }

        private void btnGenXML_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnGenXML.ForeColor = System.Drawing.Color.White;
        }

        private void btnGenXML_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btnGenXML.ForeColor = System.Drawing.Color.MidnightBlue;
        }


        /*                    Gestión de eventos del botón leer XML del menú XML de categorías                  */
        private void btnListarXML_Click(object sender, EventArgs e)
        {
            compruebaXmlCategorias();
        }

        private void btnListarXML_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnListarXML.ForeColor = System.Drawing.Color.White;
        }

        private void btnListarXML_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btnListarXML.ForeColor = System.Drawing.Color.MidnightBlue;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                     GESTIÓN DE EVENTOS DEL BOTÓN DEL MENÚ JSON DE CATEGORÍAS                    */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnMenuJSON_Click(object sender, EventArgs e)
        {
            if (pJson == false)
            {
                panelMenuJson.Visible = true;
                pJson = true;
            }
            else
            {
                panelMenuJson.Visible = false;
                pJson = false;
            }
        }

        private void btnMenuJSON_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnMenuJSON_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*                  Gestión de eventos del botón generar JSON del menú JSON de categorías                  */
        private void btnGenJSON_Click(object sender, EventArgs e)
        {
            generaJSONCategorias();
        }

        private void btnGenJSON_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnGenJSON.ForeColor = System.Drawing.Color.White;
        }

        private void btnGenJSON_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btnGenJSON.ForeColor = System.Drawing.Color.MidnightBlue;
        }


        /*                Gestión de eventos del botón leer JSON del menú JSON de categorías                */
        private void btnListarJSON_Click(object sender, EventArgs e)
        {
            compruebaJSONCategorias();
        }

        private void btnListarJSON_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnListarJSON.ForeColor = System.Drawing.Color.White;
        }

        private void btnListarJSON_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btnListarJSON.ForeColor = System.Drawing.Color.MidnightBlue;
        }



        /*-------------------------------------------------------------------------------------------------*/
        /*                     GESTIÓN DE EVENTOS DEL BOTÓN DEL MENÚ JSON DE CATEGORÍAS                    */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnMenuEXCEL_Click(object sender, EventArgs e)
        {
            if (pExcel == false)
            {
                panelMenuExcel.Visible = true;
                pExcel = true;
            }
            else
            {
                panelMenuExcel.Visible = false;
                pExcel = false;
            }
        }

        private void btnMenuEXCEL_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnMenuEXCEL_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*               Gestión de eventos del botón generar EXCEL del menú EXCEL de categorías               */
        private void btnGenEXCEL_Click(object sender, EventArgs e)
        {
            generaExcelCategorias();
        }

        private void btnGenEXCEL_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnGenEXCEL.ForeColor = System.Drawing.Color.White;
        }

        private void btnGenEXCEL_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btnGenEXCEL.ForeColor = System.Drawing.Color.MidnightBlue;
        }

        /*               Gestión de eventos del botón leer EXCEL del menú EXCEL de categorías               */
        private void btnListarEXCEL_Click(object sender, EventArgs e)
        {
            compruebaExcelCategorias();
        }

        private void btnListarEXCEL_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnListarEXCEL.ForeColor = System.Drawing.Color.White;
        }

        private void btnListarEXCEL_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btnListarEXCEL.ForeColor = System.Drawing.Color.MidnightBlue;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           ELEMENTOS DEL PANEL IZQUIERDO DE CATEGORÍAS                           */
        /*-------------------------------------------------------------------------------------------------*/
        /*             Gestión de eventos del botón que abre el panel para añadir una categoría.           */
        private void btnAñadirC_Click(object sender, EventArgs e)
        {
            panelAñadirC.Visible = true;
            panelModificarC.Visible = false;
            panelBorrarC.Visible = false;
            panelPortada.Visible = false;
        }

        private void btnAñadirC_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAñadirC_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*           Gestión de eventos del botón que abre el panel para modificar una categoría.          */
        private void btnModificarC_Click(object sender, EventArgs e)
        {
            panelModificarC.Visible = true;
            panelAñadirC.Visible = false;
            panelBorrarC.Visible = false;
            panelPortada.Visible = false;
        }

        private void btnModificarC_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnModificarC_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*              Gestión de eventos del botón que abre el panel para borrar una categoría.          */
        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            panelBorrarC.Visible = true;
            panelAñadirC.Visible = false;
            panelModificarC.Visible = false;
            panelPortada.Visible = false;
        }

        private void btnEliminarC_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnEliminarC_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                         ELEMENTOS DEL SUBPANEL QUE AÑADE UNA CATEGORÍA                          */
        /*-------------------------------------------------------------------------------------------------*/
        /*               Gestión de eventos del textbox del nombre de la categoría a añadir                */
        private void txtNombreC_Enter(object sender, EventArgs e)
        {
            if (txtNombreC.Text.Equals("Nombre"))
            {
                txtNombreC.Text = "";
                txtNombreC.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtNombreC_Leave(object sender, EventArgs e)
        {
            if (txtNombreC.Text.Equals(""))
            {
                txtNombreC.Text = "Nombre";
                txtNombreC.ForeColor = System.Drawing.Color.DarkGray;
                lbNombreC.ForeColor = System.Drawing.Color.Black;
                lbErrorNomC.Text = "";
                lbErrorNomC.Visible = false;
            }
        }

        private void txtNombreC_TextChanged(object sender, EventArgs e)
        {
            compruebaNombreCategoria("Añadir");
        }


        /*               Gestión de eventos del textbox del nombre de la categoría a añadir                */
        private void cbAlmacenC_SelectedIndexChanged(object sender, EventArgs e)
        {
            compruebaAlmacenCategoria("Añadir");
        }


        /*             Gestión de eventos del botón que limpia los datos de la categoría a añadir.         */
        private void btnLimpiarC_Click(object sender, EventArgs e)
        {
            txtNombreC.Text = "";
            cbAlmacenC.SelectedIndex = 0;
        }

        private void btnLimpiarC_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnLimpiarC_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*           Gestión de eventos del botón que registra una categoría en la base de datos.          */
        private void btnAñadeC_Click(object sender, EventArgs e)
        {
            if(nomCat && almCat)
            {
                DatosCategoria datosNuevaCat = new DatosCategoria();
                datosNuevaCat.Nombre = txtNombreC.Text.ToString();
                datosNuevaCat.Productos = 0;
                datosNuevaCat.IdAlmacen = int.Parse(cbAlmacenC.Text.ToString());
                datosNuevaCat.guardarCambios();

                txtNombreC.Text = "";
                cbAlmacenC.SelectedIndex = 0;

                FormNotificaciones form = new FormNotificaciones("Categoría registrada correctamente.");
                form.Show();

                rellenaTablaCategorias();
                rellenaComboBoxIDCat();
            }
        }

        private void btnAñadeC_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAñadeC_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                      ELEMENTOS DEL SUBPANEL QUE MODIFICA UNA CATEGORÍA                          */
        /*-------------------------------------------------------------------------------------------------*/
        /*         Gestión de eventos del combobox que selecciona el ID de la categoría a modificar.       */
        private void cbIdCMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIdCMod.SelectedIndex != 0)
            {
                try
                {
                    string sql = "SELECT * FROM Categoria";
                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    txtNombreCMod.Enabled = true;
                    cbAlmacenCMod.Enabled = true;

                    while(lector.Read())
                    {
                        if(lector.GetInt32(0) == int.Parse(cbIdCMod.Text))
                        {
                            txtNombreCMod.Text = lector.GetString(1);
                            txtProdCMod.Text = lector.GetInt32(2).ToString();
                            cbAlmacenCMod.Text = lector.GetInt32(3).ToString();
                        }
                    }
                    
                    lbErrorIdCMod.Text = "";
                    lbErrorIdCMod.Visible = false;

                    idCatMod = true;

                    command.Dispose();
                    cnx.Close();
                }
                catch (Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            } else
            {
                txtNombreCMod.Enabled = true;
                txtNombreCMod.Text = "";
                
                txtProdCMod.Enabled = true;
                txtProdCMod.Text = "";

                cbAlmacenCMod.Enabled = true;
                cbAlmacenCMod.SelectedIndex = 0;

                lbErrorIdCMod.Text = "Selecciona un ID para buscar categoría.";
                lbErrorIdCMod.Visible = true;

                idCatMod = false;
            }
        }


        /*              Gestión de eventos del textbox de nombre que modifica la categoría                 */
        private void txtNombreCMod_TextChanged(object sender, EventArgs e)
        {
            compruebaNombreCategoria("Modificar");
        }


        /*              Gestión de eventos del textbox de nombre que modifica la categoría                 */
        private void cbAlmacenCMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            compruebaAlmacenCategoria("Modificar");
        }


        /*           Gestión de eventos del botón que acepta la modificación de la categoría               */
        private void btnAceptarCMod_Click(object sender, EventArgs e)
        {
            if(idCatMod && nomCatMod && almCatMod)
            {
                try 
                {
                    string nombre = txtNombreCMod.Text;
                    int almacen = int.Parse(cbAlmacenCMod.Text);

                    string sql = "UPDATE Categoria SET nombre='" + nombre + "', idAlmacen=" + almacen + " WHERE id=" + int.Parse(cbIdCMod.Text);
                    SqlConnection cnx = new SqlConnection(conection);

                    cnx.Open();
                    SqlCommand command = new SqlCommand(sql, cnx);
                    command.ExecuteNonQuery();

                    FormNotificaciones form = new FormNotificaciones("Categoría modificada correctamente.");
                    form.Show();

                    rellenaTablaCategorias();
                } catch(Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
        }
        private void btnAceptarCMod_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAceptarCMod_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                         ELEMENTOS DEL SUBPANEL QUE BORRA UNA CATEGORÍA                          */
        /*-------------------------------------------------------------------------------------------------*/
        /*          Gestión de eventos del combobox que selecciona el ID de la categoría a borrar.         */
        private void cbIdCBorr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIdCBorr.SelectedIndex != 0)
            {
                lbErrorIdCBorr.Visible = false;
                idCatBorr = true;

                btnAceptaCBorr.Enabled = true;
            } else
            {
                lbErrorIdCBorr.Visible = true;
                idCatBorr = false;

                btnAceptaCBorr.Enabled = false;
            }
        }


        /*      Gestión de eventos del botón que hace que se abra el panel de borrado de la categoría.    */
        private void btnAceptaCBorr_Click(object sender, EventArgs e)
        {
            if(idCatBorr)
            {
                panelConfBorr.Visible = true;
            }
        }

        private void btnAceptaCBorr_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnAceptaCBorr_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*                     Gestión de eventos del botón de confirmación de borrado.                    */
        private void btnSi_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM Categoria WHERE id=" + int.Parse(cbIdCBorr.Text);
                SqlConnection cnx = new SqlConnection(conection);

                cnx.Open();
                
                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while(lector.Read())
                {
                    if(lector.GetInt32(2) == 0)
                    {
                        valido = true;
                    } else
                    {
                        valido = false;
                    }
                }

                lector.Close();

                if(valido == true)
                {
                    sql = "DELETE FROM Categoria WHERE id=" + int.Parse(cbIdCBorr.Text);
                    SqlCommand command2 = new SqlCommand(sql, cnx);
                    command2.ExecuteNonQuery();

                    FormNotificaciones form = new FormNotificaciones("Categoría borrada correctamente.");
                    form.Show();

                    rellenaTablaCategorias();
                    rellenaComboBoxIDCat();
                } else
                {
                    FormNotificaciones form = new FormNotificaciones("Error, la categoría tiene productos asociados. Elimina esos productos o cambialos de categoría para eliminar.");
                    form.Show();
                }

                panelConfBorr.Visible = false;
            } 
            catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void btnSi_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnSi_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        /*                     Gestión de eventos del botón de cancelación de borrado.                    */
        private void btnNo_Click(object sender, EventArgs e)
        {
            panelConfBorr.Visible = false;
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnNo_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           ELEMENTOS DEL PANEL DERECHO DE LAS CATEGORÍAS                         */
        /*-------------------------------------------------------------------------------------------------*/
        /*           Gestión de eventos del textbox que filtra el datagridview de las categorías           */
        private void txtFiltroC_TextChanged(object sender, EventArgs e)
        {
            filtroDatos();
        }


        /*          Gestión de eventos del picturebox que limpia el textbox del filtro de la tabla         */
        private void imgLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroC.Text = "";
            cbDatosC.SelectedIndex = 0;
        }

        private void imgLimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void imgLimpiar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                            METODOS USADOS EN EL CÓDIGO DEL FORMULARIO                           */
        /*-------------------------------------------------------------------------------------------------*/
        private void generaXmlCategorias()
        {
            try
            {
                string sql = "SELECT * FROM Categoria";
                SqlConnection cnx = new SqlConnection(conection);

                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                if (!System.IO.File.Exists("Categorias.xml"))
                {
                    XmlWriter listCli = XmlWriter.Create("Categorias.xml");
                    listCli.WriteStartDocument();
                    listCli.WriteStartElement("Categorias");

                    while (lector.Read())
                    {
                        listCli.WriteStartElement("Categoria");

                        listCli.WriteStartElement("ID");
                        listCli.WriteValue((lector.GetInt32(0)));
                        listCli.WriteEndElement();

                        listCli.WriteStartElement("Nombre");
                        listCli.WriteValue((lector.GetString(1)));
                        listCli.WriteEndElement();

                        listCli.WriteStartElement("Productos");
                        listCli.WriteValue((lector.GetInt32(2)));
                        listCli.WriteEndElement();

                        listCli.WriteStartElement("IDAlmacen");
                        listCli.WriteValue((lector.GetInt32(3)));
                        listCli.WriteEndElement();

                        listCli.WriteEndElement();
                    }

                    listCli.WriteEndElement();
                    listCli.WriteEndDocument();
                    listCli.Close();

                    FormNotificaciones form = new FormNotificaciones("XML generado correctamente.");
                    form.Show();

                    cnx.Close();
                }
                else
                {
                    FormNotificaciones form2 = new FormNotificaciones("Ya hay un documento XML de Categorias. Muévelo o cambialo de nombre para poder generar otro.");
                    form2.Show();
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void compruebaXmlCategorias()
        {
            nodosXML.Clear();

            try
            {
                OpenFileDialog buscador = new OpenFileDialog();
                buscador.Filter = "Archivos XML | *.xml";
                buscador.FileName = "";
                buscador.Title = "Cargar archivo xml";
                buscador.InitialDirectory = "C:\\";

                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    string nombre = buscador.FileName;

                    XmlDocument doc = new XmlDocument();
                    doc.Load(nombre);

                    foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
                    {
                        if (n1.HasChildNodes)
                        {
                            foreach (XmlNode n2 in n1.ChildNodes)
                            {
                                if (n2.Name.Equals("ID") || n2.Name.Equals("Nombre") || n2.Name.Equals("Productos")
                                    || n2.Name.Equals("IDAlmacen"))
                                {
                                    if (!nodosXML.Contains(n2.Name))
                                    {
                                        nodosXML.Add(n2.Name);
                                    }
                                }
                            }
                        }
                    }

                    if (nodosXML.Count == 4)
                    {
                        /* Redirige al formulario de lectura XML. */
                        FormListarCategorias form = new FormListarCategorias(nombre);
                        form.Show();
                    }
                    else
                    {
                        FormNotificaciones form = new FormNotificaciones("Error, XML incorrecto.");
                        form.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void generaJSONCategorias()
        {
            try
            {
                List<Categoria> listaCategorias = new List<Categoria>();
                string sql = "SELECT * FROM Categoria";
                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    Categoria c = new Categoria(lector.GetInt32(0), lector.GetString(1), lector.GetInt32(2),
                        lector.GetInt32(3));
                    listaCategorias.Add(c);
                }

                if (!File.Exists("Categorias.json"))
                {
                    string jsonCat = JsonConvert.SerializeObject(listaCategorias.ToArray(), Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText("Categorias.json", jsonCat);

                    FormNotificaciones form = new FormNotificaciones("JSON generado correctamente.");
                    form.Show();
                }
                else
                {
                    FormNotificaciones form2 = new FormNotificaciones("Ya hay un documento JSON de Categorias. Muévelo o cambialo de nombre para poder generar otro.");
                    form2.Show();
                }

                cnx.Close();
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void compruebaJSONCategorias()
        {
            try
            {
                OpenFileDialog buscador = new OpenFileDialog();
                buscador.Filter = "Archivos JSON | *.json";
                buscador.FileName = "";
                buscador.Title = "Cargar archivo json";
                buscador.InitialDirectory = "C:\\";

                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    string ruta = buscador.FileName;

                    JsonSerializer serializer = new JsonSerializer();
                    List<Categoria> listaCat = new List<Categoria>();

                    using (var streamReader = new StreamReader(ruta))
                    using (var textReader = new JsonTextReader(streamReader))
                    {
                        listaCat = serializer.Deserialize<List<Categoria>>(textReader);
                    }

                    FormListarCategorias form = new FormListarCategorias(categoriasJSON, listaCat);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void generaExcelCategorias()
        {
            try
            {
                List<Categoria> listaCategorias = new List<Categoria>();
                string sql = "SELECT * FROM Categoria";
                string ruta = AppDomain.CurrentDomain.BaseDirectory + "Categorias.xlsx";
                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    Categoria c = new Categoria(lector.GetInt32(0), lector.GetString(1), lector.GetInt32(2),
                        lector.GetInt32(3));
                    listaCategorias.Add(c);
                }

                if (!File.Exists(ruta))
                {
                    SLDocument excel = new SLDocument();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Columns.Add("Productos", typeof(int));
                    dt.Columns.Add("IDAlmacen", typeof(int));

                    foreach (Categoria categoria in listaCategorias)
                    {
                        dt.Rows.Add(categoria.ID, categoria.Nombre, categoria.Productos, categoria.IdAlmacen);
                    }

                    excel.ImportDataTable(1, 1, dt, true);
                    excel.SaveAs(ruta);

                    FormNotificaciones form = new FormNotificaciones("Excel generado correctamente.");
                    form.Show();
                }
                else
                {
                    FormNotificaciones form = new FormNotificaciones("Ya existe un excel de Categorías con ese nombre.");
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void compruebaExcelCategorias()
        {
            try
            {
                OpenFileDialog buscador = new OpenFileDialog();
                buscador.Filter = "Archivos EXCEL | *.xlsx";
                buscador.FileName = "";
                buscador.Title = "Cargar archivo excel";
                buscador.InitialDirectory = "C:\\";

                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    List<Categoria> categoriasExcel = new List<Categoria>();
                    string ruta = buscador.FileName;

                    SLDocument sl = new SLDocument(ruta);
                    int numFila = 1;

                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(numFila, 1)))
                    {
                        if (numFila != 1)
                        {
                            int id = sl.GetCellValueAsInt32(numFila, 1);
                            string nombre = sl.GetCellValueAsString(numFila, 2);
                            int productos = sl.GetCellValueAsInt32(numFila, 3);
                            int idAlmacen = sl.GetCellValueAsInt32(numFila, 4);

                            Categoria c = new Categoria(id, nombre, productos, idAlmacen);
                            categoriasExcel.Add(c);
                        }
                        numFila++;
                    }

                    FormListarCategorias form = new FormListarCategorias(categoriasExcel);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }


        private void rellenaTablaCategorias()
        {
            string sql = "SELECT * FROM Categoria";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(lector);
                dgvCategorias.DataSource = dt;

                foreach(DataGridViewColumn col in dgvCategorias.Columns)
                {
                    col.HeaderText = col.HeaderText.ToUpper();
                }

                command.Dispose();
                cnx.Close();
            } catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void rellenaComboBoxAlmacenes()
        {
            cbAlmacenC.Items.Add(" ");
            cbAlmacenCMod.Items.Add(" ");

            string sql = "SELECT * FROM Almacen";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    cbAlmacenC.Items.Add(lector.GetInt32(0));
                    cbAlmacenCMod.Items.Add(lector.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void rellenaComboBoxIDCat()
        {
            cbIdCMod.Items.Add(" ");
            cbIdCBorr.Items.Add(" ");

            string sql = "SELECT * FROM Categoria";
            SqlConnection cnx = new SqlConnection(conection);

            try
            {
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while(lector.Read()) 
                {
                    cbIdCMod.Items.Add(lector.GetInt32(0));
                    cbIdCBorr.Items.Add(lector.GetInt32(0));
                }
            } catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void rellenaCbDatosCategoria()
        {
            cbDatosC.Items.Add("");

            foreach (DataGridViewColumn col in dgvCategorias.Columns)
            {
                cbDatosC.Items.Add(col.HeaderText);
            }

            cbDatosC.SelectedIndex = 0;
        }

        private void compruebaNombreCategoria(string opcion)
        {
            switch(opcion)
            {
                case "Añadir":
                    string nombre = txtNombreC.Text.ToString();

                    if (nombre.Length == 0 || nombre.Length > 50)
                    {
                        lbErrorNomC.Visible = true;
                        lbNombreC.ForeColor = System.Drawing.Color.Red;

                        if (nombre.Length == 0)
                        {
                            lbErrorNomC.Text = "El nombre no puede estar vacío.";
                        }
                        else if (nombre.Length > 50)
                        {
                            lbErrorNomC.Text = "El nombre es demasiado largo.";
                        }

                        nomCat = false;
                    }
                    else if (nombre.Length > 0 && !nombre.Equals("Nombre"))
                    {
                        lbErrorNomC.Text = "";
                        lbErrorNomC.Visible = false;
                        lbNombreC.ForeColor = System.Drawing.Color.Green;
                        nomCat = true;
                    }
                    else if (nombre.Equals("Nombre"))
                    {
                        lbErrorNomC.Text = "";
                        lbErrorNomC.Visible = false;
                        lbNombreC.ForeColor = System.Drawing.Color.Black;
                        nomCat = false;
                    }
                    break;
                case "Modificar":
                    string nombreMod = txtNombreCMod.Text.ToString();

                    if (nombreMod.Length == 0 || nombreMod.Length > 50)
                    {
                        lbErrorNomCMod.Visible = true;
                        lbNombreCMod.ForeColor = System.Drawing.Color.Red;

                        if (nombreMod.Length == 0)
                        {
                            lbErrorNomCMod.Text = "El nombre no puede estar vacío.";
                        }
                        else if (nombreMod.Length > 50)
                        {
                            lbErrorNomCMod.Text = "El nombre es demasiado largo.";
                        }

                        nomCatMod = false;
                    }
                    else if (nombreMod.Length > 0 && !nombreMod.Equals("Nombre"))
                    {
                        lbErrorNomCMod.Text = "";
                        lbErrorNomCMod.Visible = false;
                        lbNombreCMod.ForeColor = System.Drawing.Color.Green;
                        nomCatMod = true;
                    }
                    break;
            }
            
        }

        private void compruebaAlmacenCategoria(string opcion)
        {
            switch(opcion)
            {
                case "Añadir":
                    int almacen = cbAlmacenC.SelectedIndex;

                    if (almacen == 0)
                    {
                        lbErrorAlmC.Text = "Selecciona un almacén.";
                        lbErrorAlmC.Visible = true;
                        almCat = false;
                    }
                    else
                    {
                        lbErrorAlmC.Text = "";
                        lbErrorAlmC.Visible = false;
                        almCat = true;
                    }
                    break;
                case "Modificar":
                    int almacenMod = cbAlmacenCMod.SelectedIndex;

                    if (almacenMod == 0)
                    {
                        lbErrorAlmCMod.Text = "Selecciona un almacén.";
                        lbErrorAlmCMod.Visible = true;
                        almCatMod = false;
                    } else
                    {
                        lbErrorAlmCMod.Text = "";
                        lbErrorAlmCMod.Visible = false;
                        almCatMod = true;
                    }
                    break;
            }
            
        }


        private void filtroDatos()
        {
            if(cbDatosC.SelectedIndex != 0)
            {
                try
                {
                    string sql = "SELECT * FROM Categoria WHERE " + cbDatosC.Text + " LIKE '%' + @filtro + '%'";
                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    command.Parameters.AddWithValue("@filtro", txtFiltroC.Text);

                    SqlDataReader lector = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(lector);
                    dgvCategorias.DataSource = dt;

                    command.Dispose();
                    cnx.Close();
                } catch(Exception ex) 
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            }
        }
    }
}
