using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Contacto
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public TipoContacto tipo_contacto { get; set; }

        public Contacto()
        {
            ID = 0;
            Descripcion = string.Empty;
            tipo_contacto = new TipoContacto();
        }
    }
}
