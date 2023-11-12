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
        public Servicio()
        {
            barrio = new barrioDao();
            Daocliente = new ClienteDao();
            tipoCliente = new TipoClienteDao();
        }

        public Cliente ClienteById(int id)
        {
            return Daocliente.GetById(id);
        }

        public bool DeleteCliente(int cod_cliente)
        {
            return Daocliente.delete(cod_cliente);
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
    }
}
