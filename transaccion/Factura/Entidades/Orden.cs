using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Entidades
{
    public class Orden
    {
        public string Especificacion { get; set; }
        public List<DetalleOrden> DetalleOrdenes { get; set; }

        public Orden()
        {
            Especificacion = string.Empty;
            DetalleOrdenes = new List<DetalleOrden>();
        }
        public void Agregar(DetalleOrden detalle)
        {
            DetalleOrdenes.Add(detalle);
        }
    }
}
