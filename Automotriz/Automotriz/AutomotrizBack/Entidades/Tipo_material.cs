using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Tipo_material
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public Tipo_material ()
        {
            id = 0;
            descripcion = string.Empty;
        }
    }
}
