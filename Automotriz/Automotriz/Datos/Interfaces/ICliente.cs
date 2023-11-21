using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Interfaces
{
    public interface ICliente
    {
        List<Cliente>GetAll();
        List<Cliente>Get(string nombre, int tipoCliente);
        Cliente GetById(int id);
        bool Nuevo(Cliente cliente);
        bool delete(int id);
        bool edit(Cliente cliente);
        bool Baja(int id);
    }
}
