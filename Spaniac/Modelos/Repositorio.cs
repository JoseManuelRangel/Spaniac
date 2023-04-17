using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public abstract class Repositorio
    {
        /* Atributo de sólo lectura. */
        private readonly string cadenaConexion;

        /* Fijamos la cadena de conexión conectándonos a la base de datos Spaniac. */
        public Repositorio() 
        {
            cadenaConexion = "server=localhost; database=Spaniac; integrated security = true";
        }

        /* Método protegido para obtener la cadena de conexión. */
        protected SqlConnection obtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
