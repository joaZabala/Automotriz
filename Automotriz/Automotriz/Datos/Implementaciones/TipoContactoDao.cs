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
    public class TipoContactoDao : ITipoContacto
    {
        public List<TipoContacto> GetTipos()
        {
            DataTable dt = HelperDB.GetInstancia().Consulta("SP_TIPOS_CONTACTOS");
            List<TipoContacto> lst = new List<TipoContacto>();
            foreach (DataRow row in dt.Rows)
            {
                TipoContacto t = new TipoContacto();
                t.Cod = Convert.ToInt32(row["id"]);
                t.Descripcion = row["descripcion"].ToString();

                lst.Add(t);
            }
            return lst;

        }
    }
}
