using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public class DatosProveedor : Master
    {
        private string cif;
        private string nombre;
        private int tipoProveedor;
        private DateTime fechaRegistro;
        private string localidad;
        private string direccion;
        private string telefono;

        public string Cif
        {
            get
            {
                return cif;
            }

            set
            {
                cif = value;
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

        public int TipoProveedor
        {
            get
            {
                return tipoProveedor;
            }

            set
            {
                tipoProveedor = value;
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

        public DatosProveedor()
        {
            cif = Cif;
            nombre = Nombre;
            tipoProveedor = TipoProveedor;
            fechaRegistro = FechaRegistro;
            localidad = Localidad;
            direccion = Direccion;
            telefono = Telefono;
        }

        public void guardarProveedor()
        {
            string transactSql = "INSERT INTO Proveedor VALUES (@cif, @nombre, @tipoProveedor, @fechaRegistro, @localidad, @direccion, @telefono)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@cif", cif));
            parametros.Add(new SqlParameter("@nombre", nombre));
            parametros.Add(new SqlParameter("@tipoProveedor", tipoProveedor));
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
                guardarProveedor();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
