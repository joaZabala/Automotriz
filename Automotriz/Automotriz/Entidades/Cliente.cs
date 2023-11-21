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
        public Barrio IdBarrio { get; set; }
        public string Direccion { get; set; }
        public TipoCliente IdTipoCliente { get; set; }
        public List<Contacto> Contactos { get; set; }

        public Cliente()
        {
            Cod = 0;
            Nombre = string.Empty;
            RazonSocial = string.Empty;
            CuilCuit = string.Empty;
            IdBarrio = new Barrio();
            IdTipoCliente = new TipoCliente();
            Direccion = string.Empty;
            Contactos = new List<Contacto>();
        }
        public Cliente(int cod, string nom, string razon, string cuil, Barrio idBarrio, string direcc, TipoCliente idTipoCliente, List<Contacto> contactos)
        {
            Cod = cod;
            Nombre = nom;
            RazonSocial = razon;
            CuilCuit = cuil;
            IdBarrio = idBarrio;
            Direccion = direcc;
            IdTipoCliente = idTipoCliente;
            Contactos = contactos;
        }
        public void QuitarContacto(int index)
        {
            Contactos.RemoveAt(index);
        }

        public void AgregarContacto(Contacto contacto)
        {
            Contactos.Add(contacto);
        }
    }
}
