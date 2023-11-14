using AutomotrizBack.Datos.Implementacion;
using AutomotrizBack.Datos.Implementacion.Producto;
using AutomotrizBack.Datos.Implementacion.Productos;
using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Datos.Interfaz.Producto;
using AutomotrizBack.Datos.Interfaz.Productos;
using AutomotrizBack.Datos.Interfazs;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.servicios
{
    public class Servicio : IServicio
    {
        IBarrio barrio;
        ICliente Daocliente;
        ITipoCliente tipoCliente;
        ITipoMaterial tpMaterial;
        IMarca marca;
        IProducto DaoProducto;
        ITipoProducto tipoProducto;
        IUnidadMedida UnidMedida;
        IUnidadPeso UnidPeso;
        IPais pais;
        public Servicio()
        {
            barrio = new barrioDao();
            Daocliente = new ClienteDao();
            tipoCliente = new TipoClienteDao();
            marca = new MarcasDao();
            DaoProducto = new ProductoDao();
            tipoProducto = new TipoProductoDao();
            UnidMedida = new unidadMedidaDao();
            UnidPeso = new UnidadPesoDao();
            tpMaterial = new TipoMaterialDao();
            pais = new PaisDao();
        }

        public bool DeleteCliente(int cod_cliente)
        {
            return Daocliente.delete(cod_cliente);
        }

        public bool DeleteProducto(int id_producto)
        {
            return DaoProducto.deleteProd(id_producto);
        }

        public List<barrio> GetBarrios()
        {
            return barrio.get();
        }

        public List<Cliente> GetByParam(string nombre, int tipo)
        {
            return Daocliente.Get(nombre, tipo);
        }

        public List<Cliente> GetClientes()
        {
            return Daocliente.GetAll();
        }

        public List<Marcas> GetMarcas()
        {
            return marca.GetAll();
        }

        public List<Pais> GetPais()
        {
            return pais.GetAll();
        }

        public List<ProductoAuto> GetProducParam(string Nombre, int tipoProducto, int material, int marca)
        {
            return DaoProducto.Get(Nombre, tipoProducto, material, marca);
        }

        public List<ProductoAuto> GetProductos()
        {
            return DaoProducto.GetAll();

        }

        public List<TipoCliente> GetTipoCliente()
        {
            return tipoCliente.GetAll();
        }

        public List<Tipo_material> GetTipoMaterial()
        {
            return tpMaterial.GetAll();
        }

        public List<TipoProducto> GetTipoProductos()
        {
            return tipoProducto.GetAll();
        }

        public List<UnidadPeso> GetUnidadPeso()
        {
            return UnidPeso.GetAll();
        }

        public List<UnidadesMedida> GetUnidMedida()
        {
            return UnidMedida.GetAll();
        }

        public bool NuevoCliente(Cliente cliente)
        {
            return Daocliente.Nuevo(cliente);
        }
        public bool NuevoProducto(ProductoAuto producto)
        {
            return DaoProducto.Nuevo(producto);
        }
    }
}
