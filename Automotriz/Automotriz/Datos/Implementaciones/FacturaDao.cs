using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Implementaciones
{
    public class FacturaDao
    {
        public List<TipoFactura> ConsultarListaTFactura()
        {
            DataTable dt = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_TIPO_FACTURAS");
            List<TipoFactura> list = new List<TipoFactura>();
            foreach (DataRow dr in dt.Rows)
            {
                TipoFactura tp = new TipoFactura();
                tp.Id = Convert.ToInt32(dr["id"]);
                tp.Tipo = Convert.ToString(dr["descripcion"]);
                list.Add(tp);
            }
            return list;
        }

        public List<Producto> Productos()
        {
            DataTable tabla = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_PRODUCTOS");
            List<Producto> list = new List<Producto>();
            foreach (DataRow dr in tabla.Rows)
            {
                Producto producto = new Producto();
                producto.Id = Convert.ToInt32(dr["id_producto"]);
                producto.Nombre = Convert.ToString(dr["producto"]);
                producto.IdTipoProducto.Id = Convert.ToInt32(dr["id_tipo_producto"]);
                producto.NumSerie = Convert.ToInt32(dr["num_serie"]);
                producto.Precio = Convert.ToDecimal(dr["precio"]);
                producto.FechaFab = Convert.ToDateTime(dr["fecha_fabricacion"]);
                producto.VidaUtil = Convert.ToInt32(dr["vida_util"]);
                producto.Peso = Convert.ToDecimal(dr["peso"]);
                producto.IdUnidadPeso.Id = Convert.ToInt32(dr["id_unidad_peso"]);
                producto.Largo = Convert.ToDecimal(dr["largo"]);
                producto.Ancho = Convert.ToDecimal(dr["ancho"]);
                producto.Alto = Convert.ToDecimal(dr["alto"]);
                producto.IdUnidadMedida.Id = Convert.ToInt32(dr["id_unidad_medida"]);
                producto.IdTipoMaterial.Id = Convert.ToInt32(dr["id_tipo_material"]);
                producto.IdPais.IdPais = Convert.ToInt32(dr["id_pais"]);
                producto.IdMarca.Id = Convert.ToInt32(dr["id_marca"]);
                list.Add(producto);
            }
            return list;
        }


        public bool GuardarFactura(Factura factura)
        {
            SqlConnection conexion = HelperDB.GetInstancia().GetConexion();
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

                foreach (DetalleFactura df in factura.Detalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand("sp_insertar_detalle_f", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@factura", idDetalle);
                    cmdDetalle.Parameters.AddWithValue("@producto", df.Producto.Id);
                    cmdDetalle.Parameters.AddWithValue("precio", df.PrecioUnitario);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", df.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    
                }


                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                {
                    t.Rollback();
                    aux = false;
                }
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

        public List<Factura> ConsultarFacturas(DateTime fecha_desde, DateTime fecha_hasta)
        {
            List<Parametro>param = new List<Parametro>();
            param.Add(new Parametro("@fec_desde", fecha_desde));
            param.Add(new Parametro("@fec_hasta", fecha_hasta));

            DataTable table = HelperDB.GetInstancia().ConsultaParametros("SP_VER_FACTURAS", param);

            List<Factura>lst = new List<Factura>(); 
          
            foreach (DataRow row in table.Rows)
            {
                Factura factura = new Factura();
                factura.Nro= Convert.ToInt32( row["nro_factura"].ToString());
                factura.Fecha = Convert.ToDateTime(row["fecha"].ToString());
                factura.Cliente.Nombre = row["nombre"].ToString();

                lst.Add(factura);
            }
            return lst;
        }

        public List<DetalleFactura> detalles_facturas(int cod)
        {
            List<Parametro>param = new List<Parametro>();
            param.Add(new Parametro("@nro_factura",cod));
            DataTable dt = HelperDB.GetInstancia().ConsultaParametros("SP_VER_DETALLE_FACTURA",param);

            List<DetalleFactura> lst = new List<DetalleFactura>();  
            foreach (DataRow row in dt.Rows)
            {
                DetalleFactura df = new DetalleFactura();
                df.Producto.Nombre = row["producto"].ToString();
                df.Cantidad = Convert.ToInt32(row["cantidad"].ToString()) ;
                df.PrecioUnitario = Convert.ToDecimal(row["pre_unitario"].ToString()); 

                lst.Add(df);
            }
            return lst;
        }

        public bool deleteFacturas(int nro)
        {
            SqlConnection conexion = HelperDB.GetInstancia().GetConexion() ;
            SqlTransaction t = null;
            bool aux = true;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("sp_eliminar_detalle_factura", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nro_factura", nro);

                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch(Exception)
            {
                if(t!=null) t.Rollback();
                aux=false; 
            }
            finally
            {
                if(conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return aux;
        }
    }
}
