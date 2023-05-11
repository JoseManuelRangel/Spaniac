using Newtonsoft.Json;
using Spaniac.Formularios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Clases
{
    public class Almacen
    {
        private int id;
        private bool activo;
        private string nombre;

        public Almacen(int ID, bool Activo, string Nombre)
        {
            id = ID;
            activo = Activo;
            nombre = Nombre;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public string Nombre
        {
            get { return nombre;  }
            set { nombre = value; }
        }
    }
}
