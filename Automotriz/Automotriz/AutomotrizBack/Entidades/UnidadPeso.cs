using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class UnidadPeso
    {
        public int id { get; set; }
        public string Descripcion { get; set; }

        public UnidadPeso()
        {
            id = 0;
            Descripcion = string.Empty;
        }
    }
}
