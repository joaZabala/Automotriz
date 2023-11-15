using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Factura
    {
        public int Nro { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public int IdTipoFactura { get; set; }
        public int IdOrdenPedido { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
        public Factura()
        {
            Nro = 0;
            Fecha = DateTime.Now;
            Cliente = new Cliente();
            IdTipoFactura = 0;
            IdOrdenPedido = 0;
            Detalles = new List<DetalleFactura>();
        }
        public Factura(int nro, DateTime fec, Cliente cliente, int idTipoFactura, int idOrdenPedido, List<DetalleFactura> detalles)
        {
            Nro = nro;
            Fecha = fec;
            Cliente = cliente;
            IdTipoFactura = idTipoFactura;
            IdOrdenPedido = idOrdenPedido;
            Detalles = detalles;
        }
        public void AgregarDetalle(DetalleFactura detalles)
        {
            Detalles.Add(detalles);
        }
        public void QuitarDetalle(int index)
        {
            Detalles.RemoveAt(index);
        }
        
    }
}
