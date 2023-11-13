using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.servicios
{
    public interface IServicio
    {
        List<barrio> GetBarrios();

        List<TipoCliente> GetTipoCliente();

        bool NuevoCliente(Cliente cliente);

        List<Cliente>GetClientes();

        List<Cliente> GetByParam(string nombre, int tipo);

        bool DeleteCliente(int cod_cliente);
    }
}
