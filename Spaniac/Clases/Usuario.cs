using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Clases
{
    public class Usuario
    {
        string dni, nombre, ap1, ap2, usuario, clave, rol, email;
        byte[] imagen;

        public Usuario(string dni, string nombre, string ap1, string ap2, string usuario, string clave, string rol, string email, byte[] imagen)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.ap1 = ap1;
            this.ap2 = ap2;
            this.usuario = usuario;
            this.clave = clave;
            this.rol = rol;
            this.email = email;
            this.imagen = imagen;
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Ap1
        {
            get { return ap1; }
            set { ap1 = value; }
        }

        public string Ap2
        {
            get { return ap2; }
            set { ap2 = value; }
        }

        public string User
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
    }
}
