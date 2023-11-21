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
    public class MarcasDao : IMarca
    {
        public List<Marcas> GetAll()
        {

            List<Marcas> lst = new List<Marcas>();
            DataTable t = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_MARCAS");
            foreach (DataRow row in t.Rows)
            {
                Marcas m = new Marcas();
                m.Id = Convert.ToInt32(row["id"].ToString());
                m.Marca = Convert.ToString(row["marca"]);

                lst.Add(m);
            }
            return lst;
        }
    }
}
