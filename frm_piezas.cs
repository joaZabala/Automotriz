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
    public partial class frm_piezas : Form
    {
        DataTable t;
        List<Parametro> lista;
        public frm_piezas()
        {
            InitializeComponent();
            
            t = HelperDB.GetInstancia().Consulta("sp_zonas");
        }

        private void dgv_piezas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_piezas_Load(object sender, EventArgs e)
        {
            cargar_zonas();
        }

        private void cargar_zonas()
        {
            cbo_zona.DataSource = t;
            cbo_zona.DisplayMember = "ubicacion";
            cbo_zona.ValueMember = "id";
            cbo_zona.SelectedIndex = 6;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            FrmPrincipal a = new FrmPrincipal();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta ventana permite revisar la cantidad de piezas que hay en una ubicación específica dentro de la compañía y funciona de la siguiente manera:\n   1. Se elige la zona de la empresa que se quiere revisar. \n   2. Se indica la cantidad mínima de piezas que se quiere revisar.\n   3. Se presiona 'Consultar'.\nUna vez hecho esto, la grilla inferior se llenará con la información que deseas.", "Ayuda",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dgv_piezas.Rows.Clear();
            lista = new List<Parametro>();

            string test = cbo_zona.Text;

            lista.Add(new Parametro("@ubica", test));
            lista.Add(new Parametro("@cantidad", (int)nud_cantidad.Value));
            DataTable consu = HelperDB.GetInstancia().ConsultaParametros("sp_productos_en", lista);

            foreach (DataRow row in consu.Rows)
            {
                int row_index = dgv_piezas.Rows.Add();
                dgv_piezas.Rows[row_index].Cells["c_año"].Value = row["Año y mes de fabricacion"];
                dgv_piezas.Rows[row_index].Cells["c_producto"].Value = row["producto"];
                dgv_piezas.Rows[row_index].Cells["c_cantidad"].Value = row["cantidad"];
                dgv_piezas.Rows[row_index].Cells["c_ubicacion"].Value = row["ubicacion"];
            }
        }
    }
}
