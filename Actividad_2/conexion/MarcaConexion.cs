using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    internal class MarcaConexion
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion From MARCAS";
                comando.Connection = conexion;  

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = lector.GetInt32(0);
                    aux.Descripcion = (string)lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

