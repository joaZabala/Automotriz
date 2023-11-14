using AutomotrizBack.Datos.Interfaz.Producto;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Implementacion.Producto
{
    public class TipoMaterialDao : ITipoMaterial
    {
        public List<Tipo_material> GetAll()
        {
            List<Tipo_material> lst = new List<Tipo_material>();
            DataTable t = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_TIPOMATERIAL");

            foreach (DataRow row in t.Rows)
            {
                Tipo_material tm = new Tipo_material();
                tm.id = Convert.ToInt32(row["id"].ToString());
                tm.descripcion = Convert.ToString(row["descripcion"]);

                lst.Add(tm);
            }
            return lst;
        }
    }
}
