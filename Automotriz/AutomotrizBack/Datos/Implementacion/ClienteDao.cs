using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Implementacion
{
    public class ClienteDao : ICliente
    {
        public List<Cliente> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            DataTable dt = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_CLIENTES");
            List<Cliente> lst = new List<Cliente>();
            foreach (DataRow row in dt.Rows)
            {
                Cliente c = new Cliente();
                c.Cod = Convert.ToInt32(row["cod_cliente"].ToString());
                c.Nombre = row["nombre"].ToString();
                c.RazonSocial = row["razon_social"].ToString();
                c.Tipo.Id = Convert.ToInt32(row["id_tipo_cliente"].ToString());
                c.Barrio.id_barrio = Convert.ToInt32(row["id_barrio"].ToString());
                c.CuilCuit = row["cuil_cuit"].ToString();
                c.Direccion = row["direccion"].ToString();

                lst.Add(c);
            }
            return lst;
        }

        public bool Nuevo(Cliente cliente)
        {
            bool aux = true;
            SqlConnection conexion = HelperDB.GetInstancia().GetConexion();
            SqlTransaction t = null;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comand = new SqlCommand("SP_INSERTAR_CLIENTES", conexion, t);
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comand.Parameters.AddWithValue("@razonSocial", cliente.RazonSocial);
                comand.Parameters.AddWithValue("@cuil_cuit", cliente.CuilCuit);
                comand.Parameters.AddWithValue("@id_barrio", cliente.Barrio.id_barrio);
                comand.Parameters.AddWithValue("@direccion", cliente.Direccion);
                comand.Parameters.AddWithValue("@id_tipo_cliente", cliente.Tipo.Id);


                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@id";
                parameter.SqlDbType = System.Data.SqlDbType.Int;
                parameter.Direction = System.Data.ParameterDirection.Output;
                comand.Parameters.Add(parameter);

                comand.ExecuteNonQuery();
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                aux = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return aux;
        }
    }
}

  