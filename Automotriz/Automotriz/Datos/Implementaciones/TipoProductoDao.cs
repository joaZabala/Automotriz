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
    public class TipoProductoDao : ITipoProducto
    {
        public List<TipoProducto> GetAll()

        {
            List<TipoProducto> lst = new List<TipoProducto>();
            DataTable t = HelperDB.GetInstancia().Consulta("Sp_consultar_tipoProducto");
            foreach (DataRow row in t.Rows)
            {
                TipoProducto tp = new TipoProducto();
                tp.Id = Convert.ToInt32(row["id"]);
                tp.Descripcion = row["descripcion"].ToString();

                lst.Add(tp);
            }
            return lst;
        }
    }
}
