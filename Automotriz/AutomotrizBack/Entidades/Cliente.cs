using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Cliente
    {
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string CuilCuit { get; set; }
        public string Direccion { get; set; }
        public TipoCliente Tipo { get; set; }
        public barrio Barrio{ get; set; }


        public Cliente()
        {
            Cod = 0;
            Nombre = string.Empty;
            RazonSocial = string.Empty;
            CuilCuit = string.Empty;
            Direccion = string.Empty;
            
           
        }
        public Cliente(int cod, string nom, string razon, string cuil, barrio barrio, string direcc,TipoCliente tipo )
        {
            Cod = cod;
            Nombre = nom;
            RazonSocial = razon;
            CuilCuit = cuil;
            Barrio = barrio;
            Direccion = direcc;
            Tipo = tipo;
        }
    }
}
