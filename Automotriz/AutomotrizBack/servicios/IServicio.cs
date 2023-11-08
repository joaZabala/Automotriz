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
        
    }
}
