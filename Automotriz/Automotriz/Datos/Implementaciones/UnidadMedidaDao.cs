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
    public class UnidadMedidaDao : IUnidadMedida
    {
        public List<UnidadMedida> GetAll()
        {

            List<UnidadMedida> lst = new List<UnidadMedida>();
            DataTable t = HelperDB.GetInstancia().Consulta("Sp_consultar_tipoMedida");

            foreach (DataRow row in t.Rows)
            {
                UnidadMedida um = new UnidadMedida();
                um.Id = Convert.ToInt32(row["id"]);
                um.Descripcion = Convert.ToString(row["descripcion"]);

                lst.Add(um);
            }
            return lst;
        }
    }
}
