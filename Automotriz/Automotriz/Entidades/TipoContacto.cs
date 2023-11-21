using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class TipoContacto
    {
        public int Cod { get; set; }

        public string Descripcion { get; set; }

        public TipoContacto()
        {
            Cod = 0;
            Descripcion = string.Empty;
        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
