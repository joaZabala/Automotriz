using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class barrio
    {
        public int id_barrio { get; set; }
        public string Nombre { get; set; }

        public barrio()
        {
            id_barrio = 0;
            Nombre = string.Empty;
        }
    }
}
