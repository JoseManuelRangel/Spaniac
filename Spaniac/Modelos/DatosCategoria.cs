using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public class DatosCategoria : Master
    {
        private int id;
        private string nombre;
        private int productos;
        private int idAlmacen;

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

        public int Productos
        {
            get
            {
                return productos;
            }

            set
            {
                productos = value;
            }
        }

        public int IdAlmacen
        {
            get
            {
                return idAlmacen;
            }

            set
            {
                idAlmacen = value;
            }
        }

        public DatosCategoria()
        {
            id = ID;
            nombre = Nombre;
            productos = Productos;
            idAlmacen = IdAlmacen;
        }

        public void guardarCategoria()
        {
            string transactSql = "INSERT INTO Categoria VALUES (@id, @nombre, @productos, @idAlmacen)";
            parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@id", id));
            parametros.Add(new SqlParameter("@nombre", nombre));
            parametros.Add(new SqlParameter("@productos", productos));
            parametros.Add(new SqlParameter("@idAlmacen", idAlmacen));


            executeNonQuery(transactSql);
        }

        public void guardarCambios()
        {
            string mensaje = null;
            try
            {
                guardarCategoria();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
