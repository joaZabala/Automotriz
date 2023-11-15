using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomotrizBack.Entidades;

namespace AutomotrizBack.Datos.Interfaz.Productos
{
    public interface IProducto
    {
        List<ProductoAuto> GetAll();
        List<ProductoAuto> Get(string Nombre, int tipoProducto, int material, int marca);
        ProductoAuto GetbyId(int id_producto);
        bool Nuevo(ProductoAuto producto);
        bool deleteProd(int id_producto);
         bool ModificarProducto (ProductoAuto producto);
        
    }
}
