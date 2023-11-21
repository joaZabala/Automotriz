using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using AutomotrizFront.ClienteH;
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
    public partial class FrmDetalleFacturas : Form
    {
        int nro_factura;
        public FrmDetalleFacturas(int id)
        {
            InitializeComponent();
            nro_factura = id;
        }

        private async void FrmDetalleFacturas_Load(object sender, EventArgs e)
        {

            await CargarDetalle();
        }

        public async Task CargarDetalle()
        {
            string url = string.Format("https://localhost:7063/api/Factura/DetallesFactura?cod={0}", nro_factura);
            var response = await ClienteSingleton.GetInstancia().GetAsync(url);

            var detalle = JsonConvert.DeserializeObject<List<DetalleFactura>>(response);

            if (detalle != null)
            {
                foreach (DetalleFactura d in detalle)
                {
                    dgvDetalles.Rows.Add(new object[] { d.Producto.Nombre, d.PrecioUnitario, d.Cantidad });
                }

            }
            else
            {
                MessageBox.Show("no se encuentra detalles", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
