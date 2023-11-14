using AutomotrizBack.Datos.Interfaz.Productos;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Implementacion.Productos
{
    public class unidadMedidaDao : IUnidadMedida
    {
        public List<UnidadesMedida> GetAll()
        {

            List<UnidadesMedida> lst = new List<UnidadesMedida>();
            DataTable t = HelperDB.GetInstancia().Consulta("Sp_consultar_tipoMedida");

            foreach (DataRow row in t.Rows)
            {
                UnidadesMedida um = new UnidadesMedida();
                um.id = Convert.ToInt32(row["id"].ToString());
                um.descripcion = Convert.ToString(row["descripcion"]);

                lst.Add(um);
            }
            return lst;
        }
    }
}
