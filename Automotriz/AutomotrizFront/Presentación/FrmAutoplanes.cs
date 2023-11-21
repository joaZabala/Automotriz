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
using AutomotrizBack.Datos.Reportes;
using Microsoft.Reporting.WinForms;

namespace AutomotrizFront.Presentación
{
    public partial class FrmAutoplanes : Form
    {
        public FrmAutoplanes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //DataTable data = HelperDB.GetInstancia().Consulta("sp_Autoplan_popular");
            //foreach (DataRow row in data.Rows)
            //{
            //    int rowIndex = dgvAutoplanes.Rows.Add();

            //    dgvAutoplanes.Rows[rowIndex].Cells["colAutoplanes"].Value = row["AutoPlan más Elegido"];
            //}
            reportViewer1.Enabled = true;
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\lenovo\\Downloads\\Automotriz\\Automotriz\\Automotriz\\Automotriz\\Datos\\Reportes\\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", HelperDB.GetInstancia().Consulta("sp_Autoplan_popular")));
            reportViewer1.RefreshReport();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un Formulario que te permitirá ver cuál AutoPlan es el que más eligen los clientes en este año! Verás los Top 5 Mejores y podrás saber qué hacer con esta información. Presionar 'Consultar'", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FrmAutoplanes_Load(object sender, EventArgs e)
        {

            reportViewer1.Enabled = false;
        }
    }
}
