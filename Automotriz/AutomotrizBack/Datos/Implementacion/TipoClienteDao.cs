using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Datos.Interfazs;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Implementacion
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
                t.Id= Convert.ToInt32(row["id_tipo"].ToString());
                t.Tipo = Convert.ToString(row["nombre"]);

                lis.Add(t);
            }
            return lis;
        }
    }
}
