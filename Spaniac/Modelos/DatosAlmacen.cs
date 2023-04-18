using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public class DatosAlmacen : Master
    {
        private int id;
        private int activo;

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

        public int Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }

        public DatosAlmacen()
        {
            id = ID;
            activo = Activo;
        }

        public void guardarAlmacen()
        {
            string transactSql = "INSERT INTO Almacen VALUES (@id, @activo)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@id", id));
            parametros.Add(new SqlParameter("@activo", activo));

            executeNonQuery(transactSql);
        }

        public void guardarCambios()
        {
            string mensaje = null;
            try
            {
                guardarAlmacen();
            } catch(Exception ex) 
            {
                mensaje = ex.Message;
            }
        }
    }
}
