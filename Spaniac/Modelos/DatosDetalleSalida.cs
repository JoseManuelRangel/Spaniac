using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public class DatosDetalleSalida : Master
    {
        private int idDetalle;
        private string idSalida;
        private int idProducto;
        private string nomProducto;
        private int almProducto;
        private string precioVenta;
        private int cantidad;
        private string subtotal;
        private string impuesto;
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

        public string IdSalida
        {
            get
            {
                return idSalida;
            }

            set
            {
                idSalida = value;
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

        public DatosDetalleSalida()
        {
            idDetalle = IdDetalle;
            idSalida = IdSalida;
            idProducto = IdProducto;
            nomProducto = NomProducto;
            almProducto = AlmProducto;
            precioVenta = PrecioVenta;
            cantidad = Cantidad;
            subtotal = Subtotal;
            impuesto = Impuesto;
            descuento = Descuento;
        }

        public void guardarDetalleSalida()
        {
            string transactSql = "INSERT INTO DetalleSalida VALUES (@idSalida, @idProducto, @nomProducto, @almProducto, @precioVenta, @cantidad, @subtotal, @impuesto, @descuento)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@idSalida", idSalida));
            parametros.Add(new SqlParameter("@idProducto", idProducto));
            parametros.Add(new SqlParameter("@nomProducto", nomProducto));
            parametros.Add(new SqlParameter("@almProducto", almProducto));
            parametros.Add(new SqlParameter("@precioVenta", precioVenta));
            parametros.Add(new SqlParameter("@cantidad", cantidad));
            parametros.Add(new SqlParameter("@subtotal", subtotal));
            parametros.Add(new SqlParameter("@impuesto", impuesto));
            parametros.Add(new SqlParameter("@descuento", descuento));


            executeNonQuery(transactSql);
        }

        public void guardarCambios()
        {
            string mensaje = null;
            try
            {
                guardarDetalleSalida();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
