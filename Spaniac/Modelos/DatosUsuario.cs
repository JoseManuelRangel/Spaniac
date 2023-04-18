using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public class DatosUsuario : Master
    {
        private string dni;
        private string nombre;
        private string ap1;
        private string ap2;
        private string usuario;
        private string clave;
        private string rol;
        private string email;
        private byte[] imagen;

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
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

        public string Ap1
        {
            get
            {
                return ap1;
            }

            set
            {
                ap1 = value;
            }
        }

        public string Ap2
        {
            get
            {
                return ap2;
            }

            set
            {
                ap2 = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set 
            {
                usuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public string Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public byte[] Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        public DatosUsuario()
        {
            dni = Dni;
            nombre = Nombre;
            ap1 = Ap1;
            ap2 = Ap2;
            usuario = Usuario;
            clave = Clave;
            rol = Rol;
            email = Email;
            imagen = Imagen;
        }

        public void guardarUsuario()
        {
            string transactSql = "INSERT INTO Usuario VALUES (@dni, @nombre, @ap1, @ap2, @usuario, @clave, @rol, @email, @imagen)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@dni", dni));
            parametros.Add(new SqlParameter("@nombre", nombre));
            parametros.Add(new SqlParameter("@ap1", ap1));
            parametros.Add(new SqlParameter("@ap2", ap2));
            parametros.Add(new SqlParameter("@usuario", usuario));
            parametros.Add(new SqlParameter("@clave", clave));
            parametros.Add(new SqlParameter("@rol", rol));
            parametros.Add(new SqlParameter("@email", email));
            parametros.Add(new SqlParameter("@imagen", imagen));

            executeNonQuery(transactSql);
        }

        public void guardarCambios()
        {
            string mensaje = null;
            try
            {
                guardarUsuario();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
