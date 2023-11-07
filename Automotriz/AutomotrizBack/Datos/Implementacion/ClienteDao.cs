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
    public class ClienteDao : ICliente
    {
        public List<Cliente> GetAll()
        {
            DataTable dt = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_CLIENTES");
            List<Cliente>lst = new List<Cliente>(); 
            foreach (DataRow row in dt.Rows)
            {
                Cliente c = new Cliente();
                c.Cod = Convert.ToInt32( row["cod_cliente"].ToString());
                c.Nombre = row["nombre"].ToString();
                c.RazonSocial = row["razon_social"].ToString();
                c.IdTipoCliente = Convert.ToInt32(row["id_tipo_cliente"].ToString());
                c.IdBarrio = Convert.ToInt32(row["id_barrio"].ToString());
                c.CuilCuit = row["cuil_cuit"].ToString();
                c.Direccion = row["direccion"].ToString();

                lst.Add(c);
            }
            return lst;
        }
    }
}
