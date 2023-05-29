using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Clases
{
    public class Categoria
    {
        int id, productos, idAlmacen;
        string nombre;

        public Categoria(int Id, string Nombre, int Productos, int IdAlmacen)
        {
            this.id = Id;
            this.nombre = Nombre;
            this.productos = Productos;
            this.idAlmacen = IdAlmacen;
        }

        public int ID 
        {
            get { return id; } 
            set {  id = value; } 
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Productos
        {
            get { return productos; }
            set { productos = value; }
        }

        public int IdAlmacen
        {
            get { return idAlmacen; }
            set { idAlmacen = value; }
        }
    }
}
