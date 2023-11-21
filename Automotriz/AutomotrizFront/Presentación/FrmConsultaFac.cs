using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using AutomotrizFront.ClienteH;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
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
    public partial class FrmConsultaFac : Form
    {
        public FrmConsultaFac()
        {
            InitializeComponent();
        }

        private void FrmConsultaFac_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddYears(-3);
            dtpHasta.Value = DateTime.Now;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvFacturas.Rows.Clear();
            String fecDesde, fecHasta;
            fecDesde = Uri.EscapeDataString(dtpDesde.Value.ToString("yyyy/MM/dd"));
            fecHasta = Uri.EscapeDataString(dtpHasta.Value.ToString("yyyy/MM/dd"));

            CargarFacturas(fecDesde, fecHasta);
        }

        private async void CargarFacturas(string desde, string hasta)
        {
            string url = string.Format("https://localhost:7063/api/Factura/FacturaByParam?desde={0}&hasta={1}", desde, hasta);

            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            List<Factura> facturas = JsonConvert.DeserializeObject<List<Factura>>(result);

            dgvFacturas.Rows.Clear();

            if (facturas != null)
            {
                foreach (Factura f in facturas)
                {
                    dgvFacturas.Rows.Add(new object[] {
                    f.Nro,
                    f.Fecha.ToString("dd/MM/yyyy"),
                    f.Cliente.Nombre,
                    "ver detalles",
                    "Eliminar"
                    });
                }
            }
            else
            {
                MessageBox.Show("Sin datos de presupuestos para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFacturas.CurrentCell.ColumnIndex == 3)
            {
                int valor = Convert.ToInt32(dgvFacturas.CurrentRow.Cells["colID"].Value);
                FrmDetalleFacturas fdetalles = new FrmDetalleFacturas(valor);
                fdetalles.Show();
            }
            if (dgvFacturas.CurrentCell.ColumnIndex == 4)
            {
                int valor = Convert.ToInt32(dgvFacturas.CurrentRow.Cells["colID"].Value);

                if (MessageBox.Show("Desea dar de baja a la factura " + valor, "Pregunta", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string url = string.Format("https://localhost:7063/api/Factura/delete?id={0}", valor);
                    var response = await ClienteSingleton.GetInstancia().DeleteAsync(url);

                    if (response.Equals("Factura dada de baja"))
                    {
                        MessageBox.Show("Factura dada de baja", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvFacturas.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("La factura no se pudo dar de baja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
