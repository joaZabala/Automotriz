using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class TipoCliente
    {
        public int Id { get; set; }  
        public string Tipo { get; set; }

        public TipoCliente()
        {
            Id = 0;
            Tipo = string.Empty;
        }
    }
}
