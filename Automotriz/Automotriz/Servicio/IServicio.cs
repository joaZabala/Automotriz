using AutomotrizBack.Datos.Interfaces;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomotrizBack.Servicio
{
    public interface IServicio
    {
        Cliente ClienteById(int id);
        List<Barrio> GetBarrios();
        List<TipoCliente> GetTipoCliente();
        bool NuevoCliente(Cliente cliente);
        List<Cliente> GetClientes();
        List<Cliente> GetByParam(string nombre, int tipo);
        //   bool DeleteCliente(int cod_cliente);
        bool editarCliente(Cliente cliente);
        List<TipoContacto> tiposContac();
        List<UnidadMedida> GetUnidMedida();
        List<UnidadPeso> GetUnidadPeso();
        List<Pais> GetPais();
        bool NuevoProducto(Producto producto);
        List<Producto> GetProductos();
        List<Producto> GetProducParam(string Nombre, int tipoProducto, int material, int marca);
        bool DeleteCliente(int cod_cliente);
        bool DeleteProducto(int id_producto);
        List<TipoMaterial> GetTipoMaterial();
        List<TipoProducto> GetTipoProductos();
        List<Marcas> GetMarcas();
        bool BajaCliente(int cod_cliente);
        List<Contacto> ContactosBYId(int id);
    }
}
