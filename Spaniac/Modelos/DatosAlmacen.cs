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
        private string nombre;

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

        public DatosAlmacen()
        {
            id = ID;
            activo = Activo;
            nombre = Nombre;
        }

        public void guardarAlmacen()
        {
            string transactSql = "INSERT INTO Almacen VALUES (@activo, @nombre)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@activo", activo));
            parametros.Add(new SqlParameter("@nombre", nombre));

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
