using AutomotrizBack.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentación
{

    public partial class frmContactoCliente : Form
    {
        private DataTable tabla;
        public frmContactoCliente(string nombre)
        {

            InitializeComponent();
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@NOMBRE", nombre));
            tabla = HelperDB.GetInstancia().ConsultaParametros("SP_BUSCAR_CLIENTE", lst);

        }

        private void frmContactoCliente_Load(object sender, EventArgs e)
        {
            foreach (DataRow fila in tabla.Rows)
            {
                dgvContactos.Rows.Add(new object[] { fila["CONTACTO"].ToString(),
                                                        fila["TIPO_CONTACTO"].ToString(),});


            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
