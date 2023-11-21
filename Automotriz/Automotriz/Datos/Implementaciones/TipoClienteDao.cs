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
    public class TipoClienteDao : ITipoCliente
    {
        public List<TipoCliente> GetAll()
        {
            List<TipoCliente> lis = new List<TipoCliente>();
            DataTable tabla = HelperDB.GetInstancia().Consulta("sp_consultar_tipo_clientes");

            foreach (DataRow row in tabla.Rows)
            {
                TipoCliente t = new TipoCliente();
                t.Id = Convert.ToInt32(row["id_tipo"]);
                t.Tipo = Convert.ToString(row["tipo"]);

                lis.Add(t);
            }
            return lis;
        }
    }
}
