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
        public string? Nombre { get; set; }
        public string? RazonSocial { get; set; }
        public string? CuilCuit { get; set; }
        public int IdBarrio { get; set; }
        public string Direccion { get; set; }
        public int IdTipoCliente { get; set; }

        public Cliente()
        {
            Cod = 0;
            Nombre = string.Empty;
            RazonSocial = string.Empty;
            CuilCuit = string.Empty;
            IdBarrio = 0;
            IdTipoCliente = 0;
            Direccion = string.Empty;
            IdTipoCliente = 0;
        }
        public Cliente(int cod, string nom, string razon, string cuil, int idBarrio, string direcc, int idTipoCliente)
        {
            Cod = cod;
            Nombre = nom;
            RazonSocial = razon;
            CuilCuit = cuil;
            IdBarrio = idBarrio;
            Direccion = direcc;
            IdTipoCliente = idTipoCliente;
        }
    }
}
