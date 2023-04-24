using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public class DatosProducto : Master
    {
        private int id;
        private string nombre;
        private int stock;
        private int stockReservado;
        private int stockFuturo;
        private int cantMin;
        private int cantMax;
        private string precioVenta;
        private string cifProveedor;
        private int idCategoria;
        private int idAlmacen;

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public int StockReservado
        {
            get
            {
                return stockReservado;
            }

            set
            {
                stockReservado = value;
            }
        }

        public int StockFuturo
        {
            get
            {
                return stockFuturo;
            }

            set
            {
                stockFuturo = value;
            }
        }

        public int CantMin
        {
            get
            {
                return cantMin;
            }

            set
            {
                cantMin = value;
            }
        }

        public int CantMax
        {
            get
            {
                return cantMax;
            }

            set
            {
                cantMax = value;
            }
        }

        public string PrecioVenta
        {
            get
            {
                return precioVenta;
            }

            set 
            {
                precioVenta = value;
            }
        }

        public string CifProveedor
        {
            get
            {
                return cifProveedor;
            }

            set 
            {
                cifProveedor = value;
            }
        }

        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }

            set
            {
                idCategoria = value;
            }
        }

        public int IdAlmacen
        {
            get
            {
                return idAlmacen;
            }

            set
            {
                idAlmacen = value;
            }
        }

        public void guardarProducto()
        {
            string transactSql = "INSERT INTO Producto VALUES (@nombre, @stock, @stockReservado, @stockFuturo, @cantMin, @cantMax, @precioVenta, @cifProveedor, @idCategoria, @idAlmacen)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@nombre", nombre));
            parametros.Add(new SqlParameter("@stock", stock));
            parametros.Add(new SqlParameter("@stockReservado", stockReservado));
            parametros.Add(new SqlParameter("@stockFuturo", stockFuturo));
            parametros.Add(new SqlParameter("@cantMin", cantMin));
            parametros.Add(new SqlParameter("@cantMax", cantMax));
            parametros.Add(new SqlParameter("@precioVenta", precioVenta));
            parametros.Add(new SqlParameter("@cifProveedor", cifProveedor));
            parametros.Add(new SqlParameter("@idCategoria", idCategoria));
            parametros.Add(new SqlParameter("@idAlmacen", idAlmacen));

            executeNonQuery(transactSql);
        }

        public void guardarCambios()
        {
            string mensaje = null;
            try
            {
                guardarProducto();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
