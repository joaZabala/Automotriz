using AutomotrizBack.Datos.Implementaciones;
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
    public class Servicio : IServicio
    {
        IBarrio barrio;
        ICliente Daocliente;
        ITipoCliente tipoCliente;
        ITipoContacto TipoContacto;
        IContacto contacDao;
        ITipoMaterial tpMaterial;
        IMarca marca;
        IProducto DaoProducto;
        ITipoProducto tipoProducto;
        IUnidadMedida UnidMedida;
        IUnidadPeso UnidPeso;
        IPais pais;
        public Servicio()
        {
            barrio = new BarrioDao();
            Daocliente = new ClienteDao();
            tipoCliente = new TipoClienteDao();
            TipoContacto = new TipoContactoDao();
            contacDao = new ContactoDao();
            tpMaterial = new TipoMaterialDao();
            marca = new MarcasDao();
            DaoProducto = new ProductoDao();
            tipoProducto = new TipoProductoDao();
            UnidMedida = new UnidadMedidaDao();
            UnidPeso = new UnidadPesoDao();
            pais = new PaisDao();
        }


        public Cliente ClienteById(int id)
        {
            return Daocliente.GetById(id);
        }

        /*  public bool DeleteCliente(int cod_cliente)
          {
             return Daocliente.delete(cod_cliente);
          }*/

        public bool editarCliente(Cliente cliente)
        {
            return Daocliente.edit(cliente);
        }

        public List<Barrio> GetBarrios()
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

        public List<TipoCliente> GetTipoCliente()
        {
            return tipoCliente.GetAll();
        }

        public bool NuevoCliente(Cliente cliente)
        {
            return Daocliente.Nuevo(cliente);
        }

        public List<TipoContacto> tiposContac()
        {
            return TipoContacto.GetTipos();
        }

        bool IServicio.BajaCliente(int cod_cliente)
        {
            return Daocliente.Baja(cod_cliente);
        }

        List<Contacto> IServicio.ContactosBYId(int id)
        {
            return contacDao.GetById(id);
        }

        //Sofi

       public bool DeleteCliente(int cod_cliente)
        {
            return Daocliente.delete(cod_cliente);
        }

        public bool DeleteProducto(int id_producto)
        {
            return DaoProducto.deleteProd(id_producto);
        }

        List<Marcas> IServicio.GetMarcas()
        {
            return marca.GetAll();
        }

        List<Pais> IServicio.GetPais()
        {
            return pais.GetAll();
        }

        List<Producto>IServicio.GetProducParam(string Nombre, int tipoProducto, int material, int marca)
        {
            return DaoProducto.Get(Nombre, tipoProducto, material, marca);
        }

        List<Producto> IServicio.GetProductos()
        {
            return DaoProducto.GetAll();
        }

        List<TipoMaterial> IServicio.GetTipoMaterial()
        {
            return tpMaterial.GetAll();
        }

        List<TipoProducto> IServicio.GetTipoProductos()
        {
            return tipoProducto.GetAll();
        }

        List<UnidadPeso> IServicio.GetUnidadPeso()
        {
            return UnidPeso.GetAll();
        }

        List<UnidadMedida> IServicio.GetUnidMedida()
        {
            return UnidMedida.GetAll();
        }

        bool IServicio.NuevoProducto(Producto producto)
        {
            return DaoProducto.Nuevo(producto);
        }
    }
}
