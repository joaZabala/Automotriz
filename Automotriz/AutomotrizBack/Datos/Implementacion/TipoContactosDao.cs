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
    public class TipoContactosDao : ITipoContacto
    {
        public List<TipoContacto> GetTipos()
        {
            DataTable dt = HelperDB.GetInstancia().Consulta("SP_TIPOS_CONTACTOS");
            List<TipoContacto> lst = new List<TipoContacto>();
            foreach (DataRow row in dt.Rows)
            {
                TipoContacto t = new TipoContacto();
                t.cod = int.Parse(row["id"].ToString());
                t.Descripcion = row["descripcion"].ToString();

                lst.Add(t);
            }
            return lst;

        }
    }
}
