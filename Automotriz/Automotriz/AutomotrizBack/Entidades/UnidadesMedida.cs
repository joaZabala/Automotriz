using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class UnidadesMedida
    {
        public int  id { get; set; }
        public string descripcion { get; set; }

        public UnidadesMedida()
        {
            id = 0;
            descripcion = string.Empty;
        }

    }
}
