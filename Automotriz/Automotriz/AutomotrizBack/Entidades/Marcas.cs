using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Marcas
    {
        public int id { get; set; }
        public string marca { get; set; }
        public Marcas()
        {
            id = 0;
            marca = string.Empty;
        }
    }
}
