using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomotrizBack.Datos.Interfaces;

namespace AutomotrizBack.Datos.Implementaciones
{
    public class ClienteDao : ICliente
    {
        public List<Cliente> GetBYFilters(string nombre, int tipoCliente)
        {
            List<Parametro> Param = new List<Parametro>();
            Param.Add(new Parametro("@NOMBRE", nombre));
            Param.Add(new Parametro("@ID_TIPO_CLIENTE", tipoCliente));
            DataTable tabla = HelperDB.GetInstancia().ConsultaParametros("SP_CONSULTAR_CLIENTES_PARAM", Param);

            List<Cliente> list = new List<Cliente>();

            foreach (DataRow row in tabla.Rows)
            {
                Cliente c = new Cliente();
                c.Cod = int.Parse(row["cod_cliente"].ToString());
                c.Nombre = row["nombre"].ToString();
                c.RazonSocial = row["razon_social"].ToString();
                c.IdTipoCliente.Id = Convert.ToInt32(row["id_tipo_cliente"]);
                c.IdBarrio.IdBarrio = Convert.ToInt32(row["id_barrio"]);
                c.CuilCuit = row["cuil_cuit"].ToString();
                c.Direccion = row["direccion"].ToString();

                list.Add(c);
            }
            return list;
        }


        public List<Cliente> GetAll()
        {
            DataTable dt = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_CLIENTES");
            List<Cliente> lst = new List<Cliente>();
            foreach (DataRow row in dt.Rows)
            {
                Cliente c = new Cliente();
                c.Cod = int.Parse(row["cod_cliente"].ToString());
                c.Nombre = row["nombre"].ToString();
                c.RazonSocial = row["razon_social"].ToString();
                c.IdTipoCliente.Id = Convert.ToInt32(row["id_tipo_cliente"]);
                c.IdBarrio.IdBarrio = Convert.ToInt32(row["id_barrio"]);
                c.CuilCuit = row["cuil_cuit"].ToString();
                c.Direccion = row["direccion"].ToString();

                lst.Add(c);
            }
            return lst;
        }

        public Cliente GetById(int id)
        {
            List<Parametro> param = new List<Parametro>();
            param.Add(new Parametro("@Id", id));
            DataTable t = HelperDB.GetInstancia().ConsultaParametros("SP_CONSULTAR_CLIENTES_BY_ID", param);

            Cliente cliente = null;
            foreach (DataRow row in t.Rows)
            {
                cliente = new Cliente();
                cliente.Cod = int.Parse(row["cod_cliente"].ToString());
                cliente.Nombre = row["nombre"].ToString();
                cliente.RazonSocial = row["razon_social"].ToString();
                cliente.IdTipoCliente.Id = Convert.ToInt32(row["id_tipo_cliente"]);
                cliente.IdBarrio.IdBarrio = Convert.ToInt32(row["id_barrio"]);
                cliente.CuilCuit = row["cuil_cuit"].ToString();
                cliente.Direccion = row["direccion"].ToString();
            }
            return cliente;
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
                comand.Parameters.AddWithValue("@id_barrio", cliente.IdBarrio.IdBarrio);
                comand.Parameters.AddWithValue("@direccion", cliente.Direccion);
                comand.Parameters.AddWithValue("@id_tipo_cliente", cliente.IdTipoCliente.Id);


                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@id";
                parameter.SqlDbType = System.Data.SqlDbType.Int;
                parameter.Direction = System.Data.ParameterDirection.Output;
                comand.Parameters.Add(parameter);

                comand.ExecuteNonQuery();

                int codigo = (int)parameter.Value;

                foreach (Contacto c in cliente.Contactos)
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERTAR_CONTACTOS", conexion, t);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DESCRIPCION", c.Descripcion);
                    cmd.Parameters.AddWithValue("@ID_TIPO_CONTACTO", c.tipo_contacto.Cod);
                    cmd.Parameters.AddWithValue("@COD_CLIENTE", codigo);

                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@COD";
                    p.SqlDbType = SqlDbType.Int;
                    p.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p);

                    cmd.ExecuteNonQuery();
                }

                t.Commit();
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                    aux = false;
                }
            }
            finally
            {
                if (conexion!=null || conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return aux;
        }

        public bool edit(Cliente cliente)
        {
            SqlConnection conexion = HelperDB.GetInstancia().GetConexion();
            SqlTransaction t = null;
            bool aux = true;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_CLIENTES", conexion, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod", cliente.Cod);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@razonSocial", cliente.RazonSocial);
                cmd.Parameters.AddWithValue("@cuil_cuit", cliente.CuilCuit);
                cmd.Parameters.AddWithValue("@id_barrio", cliente.IdBarrio.IdBarrio);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@id_tipo_cliente", cliente.IdTipoCliente.Id);

                cmd.ExecuteNonQuery();

                foreach (Contacto c in cliente.Contactos)
                {
                    SqlCommand comando = new SqlCommand("sp_modificar_contacto", conexion, t);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@descripcion", c.Descripcion);
                    comando.Parameters.AddWithValue("@id_tipo_contacto", c.tipo_contacto.Cod);

                    comando.Parameters.AddWithValue("@cod_cliente", cliente.Cod);

                    comando.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                    aux = false;
                }
            }
            finally
            {
                if (conexion!=null || conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return aux;
        }

        public bool Baja(int id)
        {
            SqlConnection con = HelperDB.GetInstancia().GetConexion();
            SqlTransaction t = null;
            bool aux = true;
            try
            {
                con.Open();
                t = con.BeginTransaction();

                SqlCommand cmd = new SqlCommand("SP_BAJA_CLIENTES", con, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod", id);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                    aux = false;
                }
            }
            finally
            {
                if (con != null || con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return aux;
        }

        public List<Cliente> Get(string nombre, int tipoCliente)
        {
            List<Parametro> Param = new List<Parametro>();
            Param.Add(new Parametro("@NOMBRE", nombre));
            Param.Add(new Parametro("@ID_TIPO_CLIENTE", tipoCliente));
            DataTable tabla = HelperDB.GetInstancia().ConsultaParametros("SP_CONSULTAR_CLIENTES_PARAM", Param);

            List<Cliente> list = new List<Cliente>();

            foreach (DataRow row in tabla.Rows)
            {
                Cliente c = new Cliente();
                c.Cod = int.Parse(row["cod_cliente"].ToString());
                c.Nombre = row["nombre"].ToString();
                c.RazonSocial = row["razon_social"].ToString();
                c.IdTipoCliente.Id = Convert.ToInt32(row["id_tipo_cliente"]);
                c.IdBarrio.IdBarrio = Convert.ToInt32(row["id_barrio"]);
                c.CuilCuit = row["cuil_cuit"].ToString();
                c.Direccion = row["direccion"].ToString();

                list.Add(c);
            }
            return list;
        }

        public bool delete(int id)
        {
            bool aux = true;
            SqlConnection conexion = HelperDB.GetInstancia().GetConexion();
            SqlTransaction t = null;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand cmd = new SqlCommand("sp_eliminar_cliente", conexion, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod", id);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch
            {
                if (t != null) t.Rollback();
                aux = false;
            }
            finally
            {
                if (conexion!=null || conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

            }
            return aux;

        }
    }
}
