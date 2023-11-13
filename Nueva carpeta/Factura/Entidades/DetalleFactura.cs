using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class DetalleFactura
    {
        public Producto Producto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public DetalleFactura()
        {
            Producto = new Producto();
            PrecioUnitario = 0;
            Cantidad = 0;
        }
        public DetalleFactura(Producto prod, decimal pre, int cant)
        {
            Producto = prod;
            PrecioUnitario = pre;
            Cantidad = cant;
        }
        public decimal CalcularSubTotal()
        {

            return Cantidad * Producto.Precio;
        }
    }
}
