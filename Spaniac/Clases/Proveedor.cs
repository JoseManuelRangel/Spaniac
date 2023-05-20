using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Clases
{
    public class Proveedor
    {
        private string id;
        private string nombre;
        private int tipoProveedor;
        private DateTime fechaRegistro;
        private string localidad;
        private string direccion;
        private string telefono;

        public Proveedor(string ID, string Nombre, int TipoProveedor, DateTime FechaRegistro, string Localidad, string Direccion
            , string Telefono)
        {
            id = ID;
            nombre = Nombre;
            tipoProveedor = TipoProveedor;
            fechaRegistro = FechaRegistro;
            localidad = Localidad;
            direccion = Direccion;
            telefono = Telefono;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int TipoProveedor
        {
            get { return tipoProveedor; }
            set { tipoProveedor = value; }
        }

        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
