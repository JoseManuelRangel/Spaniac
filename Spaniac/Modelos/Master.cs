using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaniac.Modelos
{
    public abstract class Master: Repositorio
    {
        protected List<SqlParameter> parametros;

        /* Método para ejecutar sentencias insert, update y delete con parámetros. */
        protected void executeNonQuery(string transactSql)
        {
            using(var conexion = obtenerConexion())
            {
                conexion.Open();
                using(var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = System.Data.CommandType.Text;

                    foreach(SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }

                    comando.ExecuteNonQuery();
                    parametros.Clear();
                }
            }
        }

        /* Método para ejecutar sentencias insert, update y delete con procedimientos almacenados. */
        protected void executeNonQuerySP(string transactSql)
        {
            using(var conexion = obtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    foreach(SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }

                    comando.ExecuteNonQuery();
                    parametros.Clear();
                }
            }
        }

        /* Método para ejecutar una consulta que devuelve una tabla. */
        protected DataTable executeReader(string transactSql)
        {
            using (var conexion = obtenerConexion() )
            {
                conexion.Open();
                using(var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;

                    SqlDataReader lector = comando.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }
    }
}
