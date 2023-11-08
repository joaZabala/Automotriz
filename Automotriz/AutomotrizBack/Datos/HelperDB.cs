using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos
{
    public class HelperDB
    {
        SqlConnection conexion;
        static HelperDB instancia;
        public HelperDB()
        {
        conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AUTOMOTRIZ_V2;Integrated Security=True; TrustServerCertificate=True");

        }

        public static HelperDB GetInstancia()
        {
            if(instancia == null)
            {
                instancia = new HelperDB();
            }
            return instancia;
        }

        public DataTable Consulta(string nombreSP)
        {
            conexion.Open();
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = nombreSP;
            cmd.CommandType = CommandType.StoredProcedure;

            tabla.Load(cmd.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public DataTable ConsultaParametros(string nombreSp , List<Parametro>parametros)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSp;
            comando.Parameters.Clear();
            foreach (Parametro p in parametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        public SqlConnection GetConexion()
        {
            return conexion;
        }

    }
}
