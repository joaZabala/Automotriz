using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public  class TipoProducto
    {
        public int Id { get; set; }
        public string descripcion { get; set; }

        public TipoProducto() {
            Id = 0;
            descripcion = string.Empty; 
        }

    }
}
