using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class DetalleFactura
    {
        public Producto Producto { get; set; }
        public float PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public DetalleFactura()
        {
            Producto = new Producto();
            PrecioUnitario = 0;
            Cantidad = 0;
        }
        public DetalleFactura(Producto prod, float pre, int cant)
        {
            Producto = prod;
            PrecioUnitario = pre;
            Cantidad = cant;
        }
        public float CalcularSubTotal()
        {

            return Cantidad * Producto.Precio;
        }
    }
}
