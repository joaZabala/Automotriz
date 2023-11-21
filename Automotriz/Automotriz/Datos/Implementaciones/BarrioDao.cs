using AutomotrizBack.Datos.Interfaces;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Implementaciones
{
    public class BarrioDao : IBarrio
    {
        public List<Barrio> get()
        {
            List<Barrio> lis = new List<Barrio>();
            DataTable tabla = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_BARRIOS");

            foreach (DataRow row in tabla.Rows)
            {
                Barrio b = new Barrio();
                b.IdBarrio = Convert.ToInt32(row["id_barrio"].ToString());
                b.Nombre = row["barrio"].ToString();

                lis.Add(b);
            }
            return lis;
        }
    }
}
