using Spaniac.Modelos;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaniac.Formularios.Internos.Productos
{
    public partial class FormMenuProductos : Form
    {
        /* Código que permite arrastrar el formulario. */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* Variables estáticas boolenas que controlan que los controles de registros están rellenos correctamente. */
        static bool nomb = false, stoc = true, cif = false, idC = false, min = false, max = false, precio = false;

        /* Ruta de conexión para la base de datos. */
        string conection = "server=localhost; database=Spaniac; integrated security = true";

        /* Tabla de productos. */
        DataGridView tablaProd;


        /*-------------------------------------------------------------------------------------------------*/
        /*                      CONFIGURACIÓN DEL FORMULARIO. EVENTOS Y CONSTRUCTOR                        */
        /*-------------------------------------------------------------------------------------------------*/
        public FormMenuProductos(string orden, DataGridView tablaProductos)
        {
            InitializeComponent();
            switch(orden)
            {
                case "Insertar":
                    lbTitulo.Text = "INSERCIÓN DE PRODUCTO";
                    txtDescripcion.Text = "Para insertar un producto, hay que tener en cuenta que el stock reservado y el futuro" +
                        "no pueden ser establecidos por el usuario debido a que el producto no ha recibido ni entradas ni salidas previamente" +
                        "a ser creado. El ID del almacén va en consonancia con el id de la categoría puesto que para cada categoría hay un almacén asignado.";

                    tablaProd = tablaProductos;
                    panelAñadirProducto.Visible = true;

                    rellenaCifs();
                    rellenaCategorias();
                    break;
            }
        }

        private void FormMenuProductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                     GESTIÓN DE EVENTOS DEL PANEL IZQUIERDO DEL FORMULARIO                       */
        /*-------------------------------------------------------------------------------------------------*/
        private void panelIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                       GESTIÓN DE EVENTOS DEL PANEL DEL MENÚ DE PRODUCTOS                        */
        /*-------------------------------------------------------------------------------------------------*/
        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                           GESTIÓN DE EVENTOS DEL TEXTBOX DE NOMBRE                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("Nombre"))
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DarkGray;
                lbNombre.ForeColor = Color.Black;
                lbErrorNombre.Text = "";
                lbErrorNombre.Visible = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            compruebaNombre();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                              GESTIÓN DE EVENTOS DEL STOCK DE PRODUCTO                           */
        /*-------------------------------------------------------------------------------------------------*/
        private void stock_ValueChanged(object sender, EventArgs e)
        {
            if(stock.Value < 0)
            {
                lbErrorStock.Text = "El stock no puede ser negativo.";
                lbErrorStock.Visible = true;
                stoc = false;
            } else
            {
                lbErrorStock.Text = "";
                lbErrorStock.Visible = false;
                stoc = true;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                             GESTIÓN DE EVENTOS DEL CIF DE PROVEEDOR                             */
        /*-------------------------------------------------------------------------------------------------*/
        private void cbCifProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCifProveedor.SelectedIndex != 0)
            {
                lbErrorCIF.Text = "";
                lbErrorCIF.Visible = false;

                cif = true;
            } else
            {
                lbErrorCIF.Text = "Selecciona un CIF válido.";
                lbErrorCIF.Visible = true;

                cif = false;
            }
        }

        /*-------------------------------------------------------------------------------------------------*/
        /*                             GESTIÓN DE EVENTOS DEL ID DE CATEGORIA                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void cbIdCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIdCategoria.SelectedIndex != 0)
            {
                lbErrorIDCategoria.Text = "";
                lbErrorIDCategoria.Visible = false;
                
                try
                {
                    string sql = "SELECT * FROM Categoria WHERE nombre='" + cbIdCategoria.Text + "'";

                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    while(lector.Read())
                    {
                        txtIDAlmacen.Text = lector.GetInt32(3).ToString();
                    }

                    idC = true;

                } catch(Exception ex)
                {
                    FormNotificaciones form = new FormNotificaciones(ex.Message);
                    form.Show();
                }
            } else
            {
                lbErrorIDCategoria.Text = "Selecciona una categoría.";
                lbErrorIDCategoria.Visible = true;
                idC = false;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                          GESTIÓN DE EVENTOS DE LA CANTIDAD MÍNIMA Y MÁXIMA                            */
        /*-------------------------------------------------------------------------------------------------*/
        private void cantMinima_ValueChanged(object sender, EventArgs e)
        {
            if(cantMinima.Value < 0)
            {
                lbErrorCantMin.Text = "La cantidad mínima no puede ser negativa.";
                lbErrorCantMin.Visible = true;
                min = false;
            } else
            {
                lbErrorCantMin.Text = "";
                lbErrorCantMin.Visible = false;
                min = true;
            }
        }

        private void cantMaxima_ValueChanged(object sender, EventArgs e)
        {
            if(cantMaxima.Value <= 0)
            {
                lbErrorCantMax.Text = "La cantidad máxima no puede ser 0 o menor.";
                lbErrorCantMax.Visible = true;
                max = false;
            }
            else
            {
                lbErrorCantMax.Text = "";
                lbErrorCantMax.Visible = false;
                max = true;
            }
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                         GESTIÓN DE EVENTOS DEL TEXTBOX DEL PRECIO DE VENTA                      */
        /*-------------------------------------------------------------------------------------------------*/
        private void txtPrecioVenta_Enter(object sender, EventArgs e)
        {
            if(txtPrecioVenta.Text.Equals("Precio de venta"))
            {
                txtPrecioVenta.Text = "";
                txtPrecioVenta.ForeColor = Color.Black;
            }
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text.Equals(""))
            {
                txtPrecioVenta.Text = "Precio de venta";
                txtPrecioVenta.ForeColor = Color.DarkGray;
                lbPrecioVenta.ForeColor = Color.Black;
                lbErrorPrecioVenta.Text = "";
                lbErrorPrecioVenta.Visible = false;
            }
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            compruebaPrecioVenta();
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                              GESTIÓN DE EVENTOS DEL BOTÓN INSERTAR                              */
        /*-------------------------------------------------------------------------------------------------*/
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (nomb == true && stoc == true && cif == true && idC == true && min == true && max == true && precio == true)
            {
                try
                {
                    string sql = "SELECT id FROM Categoria WHERE nombre='" + cbIdCategoria.Text + "'";

                    SqlConnection cnx = new SqlConnection(conection);
                    cnx.Open();

                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataReader lector = command.ExecuteReader();

                    DatosProducto datosNuevoProd = new DatosProducto();
                    datosNuevoProd.Nombre = txtNombre.Text.ToString();
                    datosNuevoProd.Stock = int.Parse(stock.Value.ToString());
                    datosNuevoProd.StockReservado = 0;
                    datosNuevoProd.StockFuturo = 0;
                    datosNuevoProd.CantMin = int.Parse(cantMinima.Value.ToString());
                    datosNuevoProd.CantMax = int.Parse(cantMaxima.Value.ToString());
                    datosNuevoProd.PrecioVenta = txtPrecioVenta.Text;
                    datosNuevoProd.CifProveedor = cbCifProveedor.Text;
                    datosNuevoProd.IdAlmacen = int.Parse(txtIDAlmacen.Text);

                    while (lector.Read())
                    {
                        datosNuevoProd.IdCategoria = lector.GetInt32(0);
                    }

                    datosNuevoProd.guardarCambios();

                    this.Close();

                    FormNotificaciones form = new FormNotificaciones("Producto insertado corraectamente.");
                    form.Show();

                    rellenaTablaProductos();

                } catch(Exception ex)
                {
                    FormNotificaciones form2 = new FormNotificaciones(ex.Message);
                    form2.Show();
                }
            }
        }

        private void btnInsertar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnInsertar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /*-------------------------------------------------------------------------------------------------*/
        /*                              GESTIÓN DE EVENTOS DEL BOTÓN SALIR                                 */
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
        /*                                MÉTODOS PRIVADOS DEL FORMULARIO                                  */
        /*-------------------------------------------------------------------------------------------------*/
        private void compruebaNombre()
        {
            string nombre = txtNombre.Text.ToString();

            if (nombre.Length == 0 || nombre.Length > 30)
            {
                lbErrorNombre.Visible = true;
                lbNombre.ForeColor = Color.Red;

                if (nombre.Length == 0)
                {
                    lbErrorNombre.Text = "El nombre no puede estar vacío.";
                }
                else if (nombre.Length > 30)
                {
                    lbErrorNombre.Text = "El nombre es demasiado largo.";
                }

                nomb = false;
            }
            else if (nombre.Length > 0 && !nombre.Equals("Nombre"))
            {
                lbErrorNombre.Text = "";
                lbErrorNombre.Visible = false;
                lbNombre.ForeColor = Color.Green;
                nomb = true;
            }
            else if (nombre.Equals("Nombre"))
            {
                lbErrorNombre.Text = "";
                lbErrorNombre.Visible = false;
                lbNombre.ForeColor = Color.Black;
                nomb = false;
            }
        }

        private void compruebaPrecioVenta()
        {
            bool correcto = precioV(txtPrecioVenta.Text);

            if(correcto == true)
            {
                lbPrecioVenta.ForeColor = Color.Green;

                lbErrorPrecioVenta.Text = "";
                lbErrorPrecioVenta.Visible = false;

                precio = true;
            } else
            {
                lbPrecioVenta.ForeColor = Color.Red;

                lbErrorPrecioVenta.Text = "Precio de venta incorrecto.";
                lbErrorPrecioVenta.Visible = true;

                precio = false;
            }
        }

        private void rellenaTablaProductos()
        {
            try
            {
                string sql = "SELECT id, nombre, stock, stockReservado, stockFuturo, cantMin, cantMax, precioVenta  FROM Producto";
                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(lector);
                tablaProd.DataSource = dt;

                foreach (DataGridViewColumn col in tablaProd.Columns)
                {
                    col.HeaderText = col.HeaderText.ToUpper();
                }

                command.Dispose();
                lector.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void rellenaCifs()
        {
            cbCifProveedor.Items.Clear();

            cbCifProveedor.Items.Add(" ");

            try
            {
                string sql = "SELECT cif FROM Proveedor";

                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while(lector.Read())
                {
                    cbCifProveedor.Items.Add(lector.GetString(0));
                }

                command.Dispose();
                lector.Close();
                cnx.Close();
            } catch(Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private void rellenaCategorias()
        {
            cbIdCategoria.Items.Clear();

            cbIdCategoria.Items.Add(" ");

            try
            {
                string sql = "SELECT nombre FROM Categoria";

                SqlConnection cnx = new SqlConnection(conection);
                cnx.Open();

                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    cbIdCategoria.Items.Add(lector.GetString(0));
                }

                command.Dispose();
                lector.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {
                FormNotificaciones form = new FormNotificaciones(ex.Message);
                form.Show();
            }
        }

        private bool precioV(string texto)
        {
            bool num = false, caraesp = false;
            for (int i = 0; i < texto.Length; i++)
            {
                if (Char.IsDigit(texto, i))
                {
                    num = true;
                }
                else if (Char.IsPunctuation(texto, i))
                {
                    caraesp = true;
                }
            }

            if (num && caraesp && !texto.Equals("Precio de venta"))
            {
                return true;
            }

            return false;
        }
    }
}
