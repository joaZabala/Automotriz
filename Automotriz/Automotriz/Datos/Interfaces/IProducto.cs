using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Interfaces
{
    public interface IProducto
    {
        List<Producto> GetAll();
        List<Producto> Get(string Nombre, int tipoProducto, int material, int marca);
        bool Nuevo(Producto producto);
        bool deleteProd(int id_producto);
        bool ModificarProducto(Producto Producto);
    }
}
