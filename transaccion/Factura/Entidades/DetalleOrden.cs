using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Entidades
{
    public class DetalleOrden
    {
        public DateTime fechaEntrega { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public DetalleOrden(DateTime fec,  int idProd, int cant, decimal pre)
        {
            fechaEntrega = fec;
            IdProducto = idProd;
            Cantidad = cant;
            Precio = pre;
        }
        public DetalleOrden()
        {
            fechaEntrega = DateTime.Now.AddDays(7);
            IdProducto = 0;
            Cantidad = 0;
            Precio = 0;
        }

    }
}
