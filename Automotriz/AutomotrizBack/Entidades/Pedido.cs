using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    internal class Pedido
    {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Especificacion { get; set; }

        public List<DetallePedido> Detalle { get; set; }

        public Pedido(int id, DateTime fecha, string especificacion,List<DetallePedido> detalle)
        {
            Id = id;
            Fecha = fecha;
            Especificacion = especificacion;
            Detalle = detalle;
            
        }
        public Pedido()
        {
            Id = 0;
            Fecha = DateTime.Today;
            Especificacion = string.Empty;
            Detalle = new List<DetallePedido>();
        }

    }
}
