using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class TipoContacto
    {
        public int cod { get; set; }

        public string Descripcion { get; set; }

        public TipoContacto()
        {
            cod = 0;
            Descripcion = string.Empty;
        }
    }
}
