using AutomotrizBack.Datos.Implementacion;
using AutomotrizBack.Datos.Interfaz;
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
        ITipoContacto TipoContacto;
        IContacto contacDao;
        public Servicio()
        {
            barrio = new barrioDao();
            Daocliente = new ClienteDao();
            tipoCliente = new TipoClienteDao();
            TipoContacto = new TipoContactosDao();
            contacDao = new ContactoDao();
        }

        public bool BajaCliente(int cod_cliente)
        {
            return Daocliente.Baja(cod_cliente);
        }

        public Cliente ClienteById(int id)
        {
            return Daocliente.GetById(id);
        }

        public List<Contacto> ContactosBYId(int id)
        {
            return contacDao.GetById(id);
        }

        public bool editarCliente(Cliente cliente)
        {
            return Daocliente.edit(cliente);
        }

        public List<barrio> GetBarrios()
        {
            return barrio.get();
        }

        public List<Cliente> GetByParam(string nombre, int tipo)
        {
            return Daocliente.GetBYFilters(nombre, tipo);
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


    }
}
