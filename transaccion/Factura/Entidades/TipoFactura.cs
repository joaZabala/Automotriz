using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Entidades
{
    public class TipoFactura
    {
        public int Id { get; set; }
        public string Tipo { get; set; }

        public TipoFactura()
        {
            Id = 0;
            Tipo = string.Empty;
        }
        public override string ToString()
        {
            return Tipo;
        }
    }
}
