using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public class DatosEntrada : Master
    {
        private string numDocumento;
        private int productos;
        private string total;
        private DateTime fechaRegistro;
        private DateTime fechaLlegada;
        private string estado;
        private string dniUsuario;
        private string cifProveedor;

        public string NumDocumento
        {
            get
            {
                return numDocumento;
            }

            set
            {
                numDocumento = value;
            }
        }

        public int Productos
        {
            get
            {
                return productos;
            }

            set
            {
                productos = value;
            }
        }

        public string Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public DateTime FechaRegistro
        {
            get
            {
                return fechaRegistro;
            }

            set
            {
                fechaRegistro = value;
            }
        }

        public DateTime FechaLlegada
        {
            get
            {
                return fechaLlegada;
            }

            set
            {
                fechaLlegada = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string DniUsuario
        {
            get
            {
                return dniUsuario;
            }

            set
            {
                dniUsuario = value;
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

        public DatosEntrada()
        {
            numDocumento = NumDocumento;
            productos = Productos;
            total = Total;
            fechaRegistro = FechaRegistro;
            fechaLlegada = FechaLlegada;
            estado = Estado;
            dniUsuario = DniUsuario;
            cifProveedor = CifProveedor;
        }

        public void guardarEntrada()
        {
            string transactSql = "INSERT INTO Entrada VALUES (@numDocumento, @productos, @total, @fechaRegistro, @fechaLlegada, @estado, @dniUsuario, @cifProveedor)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@numDocumento", numDocumento));
            parametros.Add(new SqlParameter("@productos", productos));
            parametros.Add(new SqlParameter("@total", total));
            parametros.Add(new SqlParameter("@fechaRegistro", fechaRegistro));
            parametros.Add(new SqlParameter("@fechaLlegada", fechaLlegada));
            parametros.Add(new SqlParameter("@estado", estado));
            parametros.Add(new SqlParameter("@dniUsuario", dniUsuario));
            parametros.Add(new SqlParameter("@cifProveedor", cifProveedor));

            executeNonQuery(transactSql);
        }

        public void guardarCambios()
        {
            string mensaje = null;
            try
            {
                guardarEntrada();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
