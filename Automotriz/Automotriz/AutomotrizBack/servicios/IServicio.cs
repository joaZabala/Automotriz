using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.servicios
{
    public interface IServicio
    {
       ProductoAuto GetbyId(int id_producto);
        List<barrio> GetBarrios();

        List<TipoCliente> GetTipoCliente();
        List<UnidadesMedida> GetUnidMedida();
        List<UnidadPeso> GetUnidadPeso();
        List<Pais> GetPais();


        bool NuevoCliente(Cliente cliente);
        bool NuevoProducto(ProductoAuto producto);
        bool ModificarProducto(ProductoAuto producto);
        List<Cliente>GetClientes();

        List<Cliente> GetByParam(string nombre, int tipo);

        List<ProductoAuto> GetProductos();

        List<ProductoAuto> GetProducParam(string Nombre, int tipoProducto, int material, int marca);


        bool DeleteCliente(int cod_cliente);
        bool DeleteProducto(int id_producto);
        List <Tipo_material> GetTipoMaterial();
        List<TipoProducto> GetTipoProductos();

        List<Marcas> GetMarcas();
    }
}
