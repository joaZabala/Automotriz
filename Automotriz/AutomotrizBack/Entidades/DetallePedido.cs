using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    internal class DetallePedido
    {
        public DateTime FechaEntrega { get; set; }
        public Producto ProductoPedido { get; set; }

        public int Cantidad { get; set; }
        public float Precio { get; set; }

        public DetallePedido(DateTime fec,Producto prod,int cantidad,float precio)
        {
            FechaEntrega = fec;
            ProductoPedido = prod;
            Cantidad = cantidad;
            Precio = precio;
        }

        public DetallePedido()
        {
            FechaEntrega = DateTime.Today;
            ProductoPedido = new Producto();
            Cantidad = 0;
            Precio = 0;


        }
    }
}
