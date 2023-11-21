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
    public class PaisDao : IPais
    {
        public List<Pais> GetAll()
        {
            List<Pais> lst = new List<Pais>();
            DataTable t = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_paises");
            foreach (DataRow row in t.Rows)
            {
                Pais p = new Pais();
                p.IdPais = Convert.ToInt32(row["id_pais"].ToString());
                p.Nombre = row["pais"].ToString();
                lst.Add(p);
            }
            return lst;

        }
    }
}
