using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Interfaz
{
    public interface ICliente
    {
        List<Cliente> GetAll();
        List<Cliente> Get(int id);
        bool Nuevo(Cliente cliente);
    }
}
