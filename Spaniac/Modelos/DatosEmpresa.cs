using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public class DatosEmpresa : Master
    {
        private string nombre;
        private string direccion;
        private byte[] logo;

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

        public byte[] Logo
        {
            get
            {
                return logo;
            }

            set
            {
                logo = value;
            }
        }

        public DatosEmpresa()
        {
            nombre = Nombre;
            direccion = Direccion;
            logo = Logo;
        }

        public void guardarEmpresa()
        {
            string transactSql = "INSERT INTO Empresa VALUES (@nombre, @direccion, @logo)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@nombre", nombre));
            parametros.Add(new SqlParameter("@direccion", direccion));
            parametros.Add(new SqlParameter("@logo", logo));

            executeNonQuery(transactSql);
        }

        public void guardarCambios()
        {
            string mensaje = null;
            try
            {
                guardarEmpresa();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
