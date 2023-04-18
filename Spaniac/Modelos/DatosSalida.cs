using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public class DatosSalida : Master
    {
        private string numDocumento;
        private int productos;
        private string total;
        private DateTime fechaRegistro;
        private DateTime fechaLlegada;
        private string estado;
        private string dniUsuario;
        private string idCliente;

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

        public string IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public DatosSalida()
        {
            numDocumento = NumDocumento;
            productos = Productos;
            total = Total;
            fechaRegistro = FechaRegistro;
            fechaLlegada = FechaLlegada;
            estado = Estado;
            dniUsuario = DniUsuario;
            idCliente = IdCliente;
        }

        public void guardarSalida()
        {
            string transactSql = "INSERT INTO Salida VALUES (@numDocumento, @productos, @total, @fechaRegistro, @fechaLlegada, @estado, @dniUsuario, @idCliente)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@numDocumento", numDocumento));
            parametros.Add(new SqlParameter("@productos", productos));
            parametros.Add(new SqlParameter("@total", total));
            parametros.Add(new SqlParameter("@fechaRegistro", fechaRegistro));
            parametros.Add(new SqlParameter("@fechaLlegada", fechaLlegada));
            parametros.Add(new SqlParameter("@estado", estado));
            parametros.Add(new SqlParameter("@dniUsuario", dniUsuario));
            parametros.Add(new SqlParameter("@idCliente", idCliente));

            executeNonQuery(transactSql);
        }

        public void guardarCambios()
        {
            string mensaje = null;
            try
            {
                guardarSalida();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
