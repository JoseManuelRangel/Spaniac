using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public class DatosDetalleEntrada : Master
    {
        private int idDetalle;
        private string idEntrada;
        private int idProducto;
        private string nomProducto;
        private int almProducto;
        private string precioCompra;
        private string precioVenta;
        private int cantidad;
        private string impuesto;
        private string subtotal;
        private string descuento;

        public int IdDetalle
        {
            get
            {
                return idDetalle;
            }

            set
            {
                idDetalle = value;
            }
        }

        public string IdEntrada
        {
            get
            {
                return idEntrada;
            }

            set
            {
                idEntrada = value;
            }
        }

        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public string NomProducto
        {
            get
            {
                return nomProducto;
            }

            set
            {
                nomProducto = value;
            }
        }

        public int AlmProducto
        {
            get
            {
                return almProducto;
            }

            set
            {
                almProducto = value;
            }
        }

        public string PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set 
            {
                precioCompra = value;
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

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set 
            {
                cantidad = value;
            }
        }

        public string Impuesto
        {
            get
            {
                return impuesto;
            }

            set
            {
                impuesto = value;
            }
        }

        public string Subtotal
        {
            get
            {
                return subtotal;
            }

            set
            {
                subtotal = value;
            }
        }

        public string Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

        public DatosDetalleEntrada()
        {
            idDetalle = IdDetalle;
            idEntrada = IdEntrada;
            idProducto = IdProducto;
            nomProducto = NomProducto;
            almProducto = AlmProducto;
            precioCompra = PrecioCompra;
            precioVenta = PrecioVenta;
            cantidad = Cantidad;
            impuesto = Impuesto;
            subtotal = Subtotal;
            descuento = Descuento;
        }

        public void guardarDetalleEntrada()
        {
            string transactSql = "INSERT INTO DetalleEntrada VALUES (@idEntrada, @idProducto, @nomProducto, @almProducto, @precioCompra, @precioVenta, @cantidad, @impuesto, @subtotal, @descuento)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@idEntrada", idEntrada));
            parametros.Add(new SqlParameter("@idProducto", idProducto));
            parametros.Add(new SqlParameter("@nomProducto", nomProducto));
            parametros.Add(new SqlParameter("@almProducto", almProducto));
            parametros.Add(new SqlParameter("@precioCompra", precioCompra));
            parametros.Add(new SqlParameter("@precioVenta", precioVenta));
            parametros.Add(new SqlParameter("@cantidad", cantidad));
            parametros.Add(new SqlParameter("@impuesto", impuesto));
            parametros.Add(new SqlParameter("@subtotal", subtotal));
            parametros.Add(new SqlParameter("@descuento", descuento));

            executeNonQuery(transactSql);
        }

        public void guardarCambios()
        {
            string mensaje = null;
            try
            {
                guardarDetalleEntrada();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }


    }
}
