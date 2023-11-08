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
        ICliente cliente;
        ITipoCliente tipoCliente;
        public Servicio()
        {
            barrio = new barrioDao();
            cliente = new ClienteDao();
            tipoCliente = new TipoClienteDao();
        }

        public List<barrio> GetBarrios()
        {
            return barrio.get();
        }

        public List<TipoCliente> GetTipoCliente()
        {
            return tipoCliente.GetAll();
        }

    }
}
