using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Interfaz.Productos
{
    public interface IUnidadMedida
    {
        List<UnidadesMedida> GetAll();

    }
}
