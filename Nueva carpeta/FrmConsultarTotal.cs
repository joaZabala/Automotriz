﻿using AutomotrizBack.Datos;
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
    public partial class FrmConsultarTotal : Form
    {
        public FrmConsultarTotal()
        {
            InitializeComponent();
        }

        private void FrmConsultarTotal_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;

            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@fecha_desde", fechaDesde));
            lista.Add(new Parametro("@fecha_Hasta", fechaHasta));

            DataTable dt = HelperDB.GetInstancia().ConsultaParametros("SP_MONTO_TOTAL_XFECHA", lista);

            foreach (DataRow row in dt.Rows)
            {
                // Creamos una nueva fila en el DataGridView.
                int rowIndex = dgvTotal.Rows.Add();

                // Rellenamos cada celda de la fila con los datos del DataTable.

                dgvTotal.Rows[rowIndex].Cells["ColTotal"].Value = row["Total recaudado"];
                dgvTotal.Rows[rowIndex].Cells["ColPromedio"].Value = row["promedio por factura"];
                dgvTotal.Rows[rowIndex].Cells["ColCantidadFac"].Value = row["cantidad de facturas"];
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
                this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este formulario devuelve los montos totales ,el promedio y la cantidad de facturas realizadas en el periodo de tiempo especificado"
                , "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
