
using Factura.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public class HelperDB
    {
        private SqlConnection conexion;
        static HelperDB instancia;
        private HelperDB()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-H5O1V1P\SQLEXPRESS;Initial Catalog=autotest2;Integrated Security=True") ;

        }

        public static HelperDB GetInstancia()
        {
            if (instancia == null)
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
        public List<Producto> ConsultarListaProductos()
        {
            conexion.Open();
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "SP_CONSULTAR_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;

            tabla.Load(cmd.ExecuteReader());
            conexion.Close();

            List<Producto> list = new List<Producto>();
            foreach (DataRow dr in tabla.Rows)
            {
                Producto producto = new Producto();
                producto.Id = Convert.ToInt32(dr["id_producto"]);
                producto.Nombre = Convert.ToString(dr["producto"]);
                producto.IdTipoProducto = Convert.ToInt32(dr["id_tipo_producto"]);
                producto.NumSerie = Convert.ToInt32(dr["num_serie"]);
                producto.Precio = Convert.ToDecimal(dr["precio"]);
                producto.FechaFab = Convert.ToDateTime(dr["fecha_fabricacion"]);
                producto.VidaUtil = Convert.ToInt32(dr["vida_util"]);
                producto.Peso = Convert.ToDecimal(dr["peso"]);
                producto.IdUnidadPeso = Convert.ToInt32(dr["id_unidad_peso"]);
                producto.Largo = Convert.ToDecimal(dr["largo"]);
                producto.Ancho = Convert.ToDecimal(dr["ancho"]);
                producto.Alto = Convert.ToDecimal(dr["alto"]);
                producto.IdUnidadMedida = Convert.ToInt32(dr["id_unidad_medida"]);
                producto.IdTipoMaterial = Convert.ToInt32(dr["id_tipo_material"]);
                producto.IdPais = Convert.ToInt32(dr["id_pais"]);
                producto.IdMarca = Convert.ToInt32(dr["id_marca"]);
                list.Add(producto);
            }
            return list;
        }
        public List<Cliente> ConsultarListaClientes()
        {
            conexion.Open();
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "SP_CONSULTAR_CLIENTES";
            cmd.CommandType = CommandType.StoredProcedure;

            tabla.Load(cmd.ExecuteReader());
            conexion.Close();

            List<Cliente> list = new List<Cliente>();
            foreach (DataRow dr in tabla.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.Cod = Convert.ToInt32(dr["cod_cliente"]);
                cliente.Nombre = Convert.ToString(dr["nombre"]);
                cliente.RazonSocial = Convert.ToString(dr["razon_social"]);
                cliente.CuilCuit = Convert.ToString(dr["cuil_cuit"]);
                cliente.Barrio.id_barrio = Convert.ToInt32(dr["id_barrio"]);
                cliente.Direccion = Convert.ToString(dr["direccion"]);
                cliente.Tipo.Id = Convert.ToInt32(dr["id_tipo_cliente"]);
                list.Add(cliente);
            }
            return list;
        }
        public List<TipoFactura> ConsultarListaTFactura()
        {
            conexion.Open();
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "SP_CONSULTAR_TIPO_FACTURAS";
            cmd.CommandType = CommandType.StoredProcedure;

            tabla.Load(cmd.ExecuteReader());
            conexion.Close();

            List<TipoFactura> list = new List<TipoFactura>();
            foreach (DataRow dr in tabla.Rows)
            {
                TipoFactura tp = new TipoFactura();
                tp.Id = Convert.ToInt32(dr["id"]);
                tp.Tipo = Convert.ToString(dr["descripcion"]);
                list.Add(tp);
            }
            return list;
        }
        public DataTable ConsultaParametros(string nombreSp, List<Parametro> parametros)
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

        public bool Confirmar(Factura factura)
        {
            bool aux = true;
            SqlTransaction t = null;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("sp_insertar_factura", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@cliente", factura.Cliente.Cod);
                comando.Parameters.AddWithValue("@tipo_facturas", factura.IdTipoFactura);
                
                SqlParameter param = new SqlParameter();
                param.Direction = ParameterDirection.Output;
                param.ParameterName = "@factura";
                param.SqlDbType = SqlDbType.Int;
                comando.Parameters.Add(param);

                comando.ExecuteNonQuery();

                int id = (int)param.Value;
                int idDetalle = id;

                foreach(DetalleFactura df in factura.Detalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand("sp_insertar_detalle_f", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@factura", idDetalle);
                    cmdDetalle.Parameters.AddWithValue("@producto", df.Producto.Id);
                    cmdDetalle.Parameters.AddWithValue("precio", df.PrecioUnitario);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", df.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    idDetalle++;
                }
               

                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    aux = false;
                }
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return aux;
        }
    }
}
