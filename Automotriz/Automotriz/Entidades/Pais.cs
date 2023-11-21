using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Pais
    {
        public int IdPais { get; set; }
        public string Nombre { get; set; }
        public Pais()
        {
            IdPais = 0;
            Nombre = string.Empty;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
