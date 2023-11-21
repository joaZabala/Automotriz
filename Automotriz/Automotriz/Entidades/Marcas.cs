using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Marcas
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public Marcas()
        {
            Id = 0;
            Marca = string.Empty;
        }
        public override string ToString()
        {
            return Marca;
        }
    }
}
