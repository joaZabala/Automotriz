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
    public class ContactoDao : IContacto
    {
        public List<Contacto> GetById(int id)
        {
            List<Parametro> Param = new List<Parametro>();
            Param.Add(new Parametro("@id", id));

            DataTable tabla = HelperDB.GetInstancia().ConsultaParametros("sp_consultar_contacto_By_Id", Param);

            List<Contacto> list = new List<Contacto>();

            foreach (DataRow row in tabla.Rows)
            {
                Contacto c = new Contacto();
                c.ID = Convert.ToInt32(row["id_contacto"]);
                c.Descripcion = row["descripcion"].ToString();
                c.tipo_contacto.Cod = Convert.ToInt32(row["id_tipo_contacto"]);
                list.Add(c);
            }
            return list;
        }
    }
}
