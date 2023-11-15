using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Datos.Interfaz.Producto;
using AutomotrizBack.Datos.Interfaz.Productos;
using AutomotrizBack.Datos.Interfazs;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutomotrizBack.Datos.Implementacion.Producto
{
    public class ProductoDao : IProducto
    {
        public List<ProductoAuto> GetAll()
        {
            DataTable dt = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_PRODUCTOS");
            List<ProductoAuto> lst = new List<ProductoAuto>();
            foreach (DataRow row in dt.Rows)
            {
                ProductoAuto p = new ProductoAuto();
                p.Id = Convert.ToInt32(row["id_producto"].ToString());
                p.Productos = row["producto"].ToString();
                p.IdTipoProducto.Id = Convert.ToInt32(row["id_tipo_producto"].ToString());
                p.NumSerie = Convert.ToInt32(row["num_serie"].ToString());
                p.Precio = Convert.ToDecimal(row["Precio"].ToString());
                p.FechaFab = DateTime.Parse(row["Fecha_fabricacion"].ToString());
                p.VidaUtil = Convert.ToInt32(row["vida_util"].ToString());
                p.Peso = Convert.ToDecimal(row["peso"].ToString());
                p.IdUnidadPeso.id = Convert.ToInt32(row["id_unidad_peso"].ToString());
                p.Largo = Convert.ToDecimal(row["Largo"].ToString());
                p.Ancho = Convert.ToDecimal(row["Ancho"].ToString());
                p.Alto = Convert.ToDecimal(row["alto"].ToString());
                p.IdUnidadMedida.id = Convert.ToInt32(row["id_unidad_medida"].ToString());
                p.IdTipoMaterial.id = Convert.ToInt32(row["id_tipo_material"].ToString());
                p.IdPais.id_pais = Convert.ToInt32(row["id_pais"].ToString());
                p.IdMarca.id = Convert.ToInt32(row["id_marca"].ToString());
            


                lst.Add(p);
            }
            return lst;
        }

        public List<ProductoAuto> Get(string Nombre, int tipoProducto, int material, int marca)
        {
            List<Parametro> Param = new List<Parametro>();
            Param.Add(new Parametro("@NombreProducto", Nombre));
            Param.Add(new Parametro("@Marca", marca));
            Param.Add(new Parametro("@TipoProductoID", tipoProducto));
            Param.Add(new Parametro("@TipoMaterialID", material));
           
            DataTable t = HelperDB.GetInstancia().ConsultaParametros("sp_ConsultarProductos_param", Param);

            List<ProductoAuto> lst = new List<ProductoAuto>();
            foreach (DataRow row in t.Rows)
            {
                ProductoAuto p = new ProductoAuto();
                p.Id = Convert.ToInt32(row["id_producto"].ToString());
                p.Productos = row["producto"].ToString();
                p.IdTipoProducto.Id = Convert.ToInt32(row["id_tipo_producto"]);
                p.NumSerie = Convert.ToInt32(row["num_serie"]);
                p.Precio = Convert.ToDecimal(row["Precio"]);
                p.FechaFab = Convert.ToDateTime(row["Fecha_fabricacion"]);
                p.VidaUtil = Convert.ToInt32(row["vida_util"]);
                p.Peso = Convert.ToDecimal(row["peso"]);
                p.IdUnidadPeso.id = Convert.ToInt32(row["id_unidad_peso"]);
                p.Largo = Convert.ToDecimal(row["Largo"]);
                p.Ancho = Convert.ToDecimal(row["Ancho"]);
                p.Alto = Convert.ToDecimal(row["alto"]);
                p.IdUnidadMedida.id = Convert.ToInt32(row["id_unidad_medida"]);
                p.IdTipoMaterial.id = Convert.ToInt32(row["id_tipo_material"]);
                p.IdPais.id_pais = Convert.ToInt32(row["id_pais"]);
                p.IdMarca.id = Convert.ToInt32(row["id_marca"]);



                lst.Add(p);
            }
            return lst;

            
        }

        public bool Nuevo(ProductoAuto producto)
        {
            bool aux = true;
            SqlConnection conexion = HelperDB.GetInstancia().GetConexion();
            
            
                conexion.Open();
               


                SqlCommand cmd = new SqlCommand("SP_INSERTAR_PRODUCTOS", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@producto", producto.Productos);
                cmd.Parameters.AddWithValue("@id_tipo_producto", producto.IdTipoProducto.Id);
                cmd.Parameters.AddWithValue("@num_serie", producto.NumSerie);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@fecha_fabricacion", producto.FechaFab);
                cmd.Parameters.AddWithValue("@vida_util", producto.VidaUtil);
                cmd.Parameters.AddWithValue("@peso", producto.Peso);
                cmd.Parameters.AddWithValue("@id_unidad_peso", producto.IdUnidadPeso.id);
                cmd.Parameters.AddWithValue("@largo", producto.Largo);
                cmd.Parameters.AddWithValue("@ancho", producto.Ancho);
                cmd.Parameters.AddWithValue("@alto", producto.Alto);
                cmd.Parameters.AddWithValue("@id_unidad_medida", producto.IdUnidadMedida.id);
                cmd.Parameters.AddWithValue("@id_tipo_material", producto.IdTipoMaterial.id);
                cmd.Parameters.AddWithValue("@id_pais", producto.IdPais.id_pais);
                cmd.Parameters.AddWithValue("@id_marca", producto.IdMarca.id);

                
                cmd.ExecuteNonQuery();


            conexion.Close();
            
           
           
            return aux;
        }

        public bool deleteProd(int id_producto)
        {
            bool aux = true;
            SqlConnection conexion = HelperDB.GetInstancia().GetConexion();
            
         
            
                conexion.Open();
              
                SqlCommand cmd = new SqlCommand("Sp_EliminarProducto", conexion );
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", id_producto);
                cmd.ExecuteNonQuery();
               
            
            return aux;
        }
      

        public bool ModificarProducto(ProductoAuto producto)
        {
            SqlConnection conexion = HelperDB.GetInstancia().GetConexion();
            bool aux = true;
            conexion.Open();

            SqlCommand cmd = new SqlCommand("SP_MODIFICAR_PRODUCTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_producto", producto.Id);
            cmd.Parameters.AddWithValue("@producto", producto.Productos);
            cmd.Parameters.AddWithValue("@id_tipo_producto", producto.IdTipoProducto.Id);
            cmd.Parameters.AddWithValue("@num_serie", producto.NumSerie);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
            cmd.Parameters.AddWithValue("@fecha_fabricacion", producto.FechaFab);
            cmd.Parameters.AddWithValue("@vida_util", producto.VidaUtil);
            cmd.Parameters.AddWithValue("@peso", producto.Peso);
            cmd.Parameters.AddWithValue("@id_unidad_peso", producto.IdUnidadPeso.id);
            cmd.Parameters.AddWithValue("@largo", producto.Largo);
            cmd.Parameters.AddWithValue("@ancho", producto.Ancho);
            cmd.Parameters.AddWithValue("@alto", producto.Alto);
            cmd.Parameters.AddWithValue("@id_unidad_medida", producto.IdUnidadMedida.id);
            cmd.Parameters.AddWithValue("@id_tipo_material", producto.IdTipoMaterial.id);
            cmd.Parameters.AddWithValue("@id_pais", producto.IdPais.id_pais);
            cmd.Parameters.AddWithValue("@id_marca", producto.IdMarca.id);

            cmd.ExecuteNonQuery();
            return aux;
        }

        public ProductoAuto GetbyId(int id_producto)
        {
            List<Parametro> Param = new List<Parametro>();
            Param.Add(new Parametro("@id", id_producto));

            DataTable t = HelperDB.GetInstancia().ConsultaParametros("SP_CONSULTAR_PRODUCTOS_ID", Param);

            ProductoAuto producto = null;
            foreach (DataRow row in t.Rows)
            {
                ProductoAuto p = new ProductoAuto();
                p.Id = Convert.ToInt32(row["id_producto"].ToString());
                p.Productos = row["producto"].ToString();
                p.IdTipoProducto.Id = Convert.ToInt32(row["id_tipo_producto"]);
                p.NumSerie = Convert.ToInt32(row["num_serie"]);
                p.Precio = Convert.ToDecimal(row["Precio"]);
                p.FechaFab = Convert.ToDateTime(row["Fecha_fabricacion"]);
                p.VidaUtil = Convert.ToInt32(row["vida_util"]);
                p.Peso = Convert.ToDecimal(row["peso"]);
                p.IdUnidadPeso.id = Convert.ToInt32(row["id_unidad_peso"]);
                p.Largo = Convert.ToDecimal(row["Largo"]);
                p.Ancho = Convert.ToDecimal(row["Ancho"]);
                p.Alto = Convert.ToDecimal(row["alto"]);
                p.IdUnidadMedida.id = Convert.ToInt32(row["id_unidad_medida"]);
                p.IdTipoMaterial.id = Convert.ToInt32(row["id_tipo_material"]);
                p.IdPais.id_pais = Convert.ToInt32(row["id_pais"]);
                p.IdMarca.id = Convert.ToInt32(row["id_marca"]);

                // Asignar el producto local (p) a la variable producto
                producto = p;
            }
            return producto;
        }

      
    }
}
