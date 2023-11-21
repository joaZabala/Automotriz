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
    public class TipoMaterialDao : ITipoMaterial
    {
        public List<TipoMaterial> GetAll()
        {
            List<TipoMaterial> lst = new List<TipoMaterial>();
            DataTable t = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_TIPOMATERIAL");

            foreach (DataRow row in t.Rows)
            {
                TipoMaterial tm = new TipoMaterial();
                tm.Id = Convert.ToInt32(row["id"]);
                tm.Descripcion = Convert.ToString(row["descripcion"]);

                lst.Add(tm);
            }
            return lst;
        }
    }
}
