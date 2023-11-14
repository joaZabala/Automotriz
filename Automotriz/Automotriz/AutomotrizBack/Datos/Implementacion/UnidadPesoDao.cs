using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Datos.Interfaz.Productos;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Implementacion
{
    public class UnidadPesoDao : IUnidadPeso
    {
        public List<UnidadPeso> GetAll()
        {
            List<UnidadPeso> lst = new List<UnidadPeso>();
            DataTable t = HelperDB.GetInstancia().Consulta("Sp_consultar_tipoPeso");

            foreach (DataRow row in t.Rows)
            {
                UnidadPeso up = new UnidadPeso();
                up.id = Convert.ToInt32(row["id"].ToString());
                up.Descripcion = Convert.ToString(row["descripcion"]);

                lst.Add(up);
            }
            return lst;
        }
    }
}
