using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Implementacion
{
    public class barrioDao : IBarrio
    {
        public List<barrio> get()
        {
            List<barrio>lis = new List<barrio>();
            DataTable tabla = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_BARRIOS");

            foreach (DataRow row in tabla.Rows) 
            { 
                barrio b = new barrio();
                b.id_barrio=  Convert.ToInt32(row["id_barrio"].ToString());
                b.Nombre = row["barrio"].ToString();

                lis.Add(b);
            }
            return lis;
        }
    }
}
