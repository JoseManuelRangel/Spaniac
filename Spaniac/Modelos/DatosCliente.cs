using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public class DatosCliente : Master
    {
        private string id;
        private string nombre;
        private DateTime fechaRegistro;
        private string localidad;
        private string direccion;
        private string telefono;

        public string ID
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

        public string Localidad
        {
            get
            {
                return localidad;
            }

            set
            {
                localidad = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public DatosCliente()
        {
            id = ID;
            nombre = Nombre;
            fechaRegistro = FechaRegistro;
            localidad = Localidad;
            direccion = Direccion;
            telefono = Telefono;
        }

        public void guardarCliente()
        {
            string transactSql = "INSERT INTO Cliente VALUES (@id, @nombre, @fechaRegistro, @localidad, @direccion, @telefono)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@id", id));
            parametros.Add(new SqlParameter("@nombre", nombre));
            parametros.Add(new SqlParameter("@fechaRegistro", fechaRegistro));
            parametros.Add(new SqlParameter("@localidad", localidad));
            parametros.Add(new SqlParameter("@direccion", direccion));
            parametros.Add(new SqlParameter("@telefono", telefono));


            executeNonQuery(transactSql);
        }

        public void guardarCambios()
        {
            string mensaje = null;
            try
            {
                guardarCliente();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
