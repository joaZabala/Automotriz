﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomotrizBack.Entidades;
using AutomotrizBack.Datos.Interfaces;

namespace AutomotrizBack.Datos.Implementaciones
{
    public class ProductoDao : IProducto
    {
        public List<Producto> GetAll()
        {
            DataTable dt = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_PRODUCTOS");
            List<Producto> lst = new List<Producto>();
            foreach (DataRow row in dt.Rows)
            {
                Producto p = new Producto();
                p.Id = Convert.ToInt32(row["id_producto"]);
                p.Nombre = row["producto"].ToString();
                p.IdTipoProducto.Id = Convert.ToInt32(row["id_tipo_producto"]);
                p.NumSerie = Convert.ToInt32(row["num_serie"]);
                p.Precio = Convert.ToDecimal(row["Precio"]);
                p.FechaFab = Convert.ToDateTime(row["Fecha_fabricacion"]);
                p.VidaUtil = Convert.ToInt32(row["vida_util"]);
                p.Peso = Convert.ToDecimal(row["peso"].ToString());
                p.IdUnidadPeso.Id = Convert.ToInt32(row["id_unidad_peso"]);
                p.Largo = Convert.ToDecimal(row["Largo"]);
                p.Ancho = Convert.ToDecimal(row["Ancho"]);
                p.Alto = Convert.ToDecimal(row["alto"]);
                p.IdUnidadMedida.Id = Convert.ToInt32(row["id_unidad_medida"]);
                p.IdTipoMaterial.Id = Convert.ToInt32(row["id_tipo_material"]);
                p.IdPais.IdPais = Convert.ToInt32(row["id_pais"]);
                p.IdMarca.Id = Convert.ToInt32(row["id_marca"]);



                lst.Add(p);
            }
            return lst;
        }
        public DataTable GetbyId(int id_producto)
        {
            List<Parametro> Param = new List<Parametro>();
            Param.Add(new Parametro("@id", id_producto));

            DataTable t = HelperDB.GetInstancia().ConsultaParametros("SP_CONSULTAR_PRODUCTOS_ID", Param);

            return t;

        }
        public List<Producto> Get(string Nombre, int tipoProducto, int material, int marca)
        {
            List<Parametro> Param = new List<Parametro>();
            Param.Add(new Parametro("@NombreProducto", Nombre));
            Param.Add(new Parametro("@Marca", marca));
            Param.Add(new Parametro("@TipoProductoID", tipoProducto));
            Param.Add(new Parametro("@TipoMaterialID", material));

            DataTable t = HelperDB.GetInstancia().ConsultaParametros("sp_ConsultarProductos_param", Param);

            List<Producto> lst = new List<Producto>();

            foreach (DataRow row in t.Rows)
            {
                Producto p = new Producto();
                p.Id = Convert.ToInt32(row["id_producto"]);
                p.Nombre = row["producto"].ToString();
                p.IdTipoProducto.Id = Convert.ToInt32(row["id_tipo_producto"]);
                p.NumSerie = Convert.ToInt32(row["num_serie"]);
                p.Precio = Convert.ToDecimal(row["Precio"]);
                p.FechaFab = Convert.ToDateTime(row["Fecha_fabricacion"]);
                p.VidaUtil = Convert.ToInt32(row["vida_util"]);
                p.Peso = Convert.ToDecimal(row["peso"]);
                p.IdUnidadPeso.Id = Convert.ToInt32(row["id_unidad_peso"]);
                p.Largo = Convert.ToDecimal(row["Largo"]);
                p.Ancho = Convert.ToDecimal(row["Ancho"]);
                p.Alto = Convert.ToDecimal(row["alto"]);
                p.IdUnidadMedida.Id = Convert.ToInt32(row["id_unidad_medida"]);
                p.IdTipoMaterial.Id = Convert.ToInt32(row["id_tipo_material"]);
                p.IdPais.IdPais = Convert.ToInt32(row["id_pais"]);
                p.IdMarca.Id = Convert.ToInt32(row["id_marca"]);



                lst.Add(p);
            }
            return lst;


        }

        public bool Nuevo(Producto producto)
        {
            bool aux = true;
            SqlConnection conexion = HelperDB.GetInstancia().GetConexion();


            conexion.Open();



            SqlCommand cmd = new SqlCommand("SP_INSERTAR_PRODUCTOS", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@producto", producto.Nombre);
            cmd.Parameters.AddWithValue("@id_tipo_producto", producto.IdTipoProducto.Id);
            cmd.Parameters.AddWithValue("@num_serie", producto.NumSerie);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
            cmd.Parameters.AddWithValue("@fecha_fabricacion", producto.FechaFab);
            cmd.Parameters.AddWithValue("@vida_util", producto.VidaUtil);
            cmd.Parameters.AddWithValue("@peso", producto.Peso);
            cmd.Parameters.AddWithValue("@id_unidad_peso", producto.IdUnidadPeso.Id);
            cmd.Parameters.AddWithValue("@largo", producto.Largo);
            cmd.Parameters.AddWithValue("@ancho", producto.Ancho);
            cmd.Parameters.AddWithValue("@alto", producto.Alto);
            cmd.Parameters.AddWithValue("@id_unidad_medida", producto.IdUnidadMedida.Id);
            cmd.Parameters.AddWithValue("@id_tipo_material", producto.IdTipoMaterial.Id);
            cmd.Parameters.AddWithValue("@id_pais", producto.IdPais.IdPais);
            cmd.Parameters.AddWithValue("@id_marca", producto.IdMarca.Id);


            cmd.ExecuteNonQuery();


            conexion.Close();



            return aux;
        }

        public bool deleteProd(int id_producto)
        {
            bool aux = true;
            SqlConnection conexion = HelperDB.GetInstancia().GetConexion();



            conexion.Open();

            SqlCommand cmd = new SqlCommand("Sp_EliminarProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductoID", id_producto);
            cmd.ExecuteNonQuery();
            conexion.Close();

            return aux;
        }
        public bool ModificarProducto(Producto producto)
        {
            SqlConnection conexion = HelperDB.GetInstancia().GetConexion();
            bool aux = true;
            conexion.Open();

            SqlCommand cmd = new SqlCommand("SP_MODIFICAR_PRODUCTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_producto", producto.Id);
            cmd.Parameters.AddWithValue("@producto", producto.Nombre);
            cmd.Parameters.AddWithValue("@id_tipo_producto", producto.IdTipoProducto.Id);
            cmd.Parameters.AddWithValue("@num_serie", producto.NumSerie);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
            cmd.Parameters.AddWithValue("@fecha_fabricacion", producto.FechaFab);
            cmd.Parameters.AddWithValue("@vida_util", producto.VidaUtil);
            cmd.Parameters.AddWithValue("@peso", producto.Peso);
            cmd.Parameters.AddWithValue("@id_unidad_peso", producto.IdUnidadPeso.Id);
            cmd.Parameters.AddWithValue("@largo", producto.Largo);
            cmd.Parameters.AddWithValue("@ancho", producto.Ancho);
            cmd.Parameters.AddWithValue("@alto", producto.Alto);
            cmd.Parameters.AddWithValue("@id_unidad_medida", producto.IdUnidadMedida.Id);
            cmd.Parameters.AddWithValue("@id_tipo_material", producto.IdTipoMaterial.Id);
            cmd.Parameters.AddWithValue("@id_pais", producto.IdPais.IdPais);
            cmd.Parameters.AddWithValue("@id_marca", producto.IdMarca.Id);

            cmd.ExecuteNonQuery();
            return aux;
        }


    }
}
