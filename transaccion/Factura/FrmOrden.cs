using Factura.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class FrmOrden : Form
    {
        private Orden ordenNueva;
        private DetalleOrden detOrden;
        public FrmOrden(Producto prod, int cant, decimal pre)
        {
            InitializeComponent();
            txtProducto.Text = prod.Nombre.ToString();
            txtCantidad.Text = cant.ToString();
            txtPrecio.Text = pre.ToString();
            ordenNueva = new Orden();
            detOrden = new DetalleOrden(dtpFechaEntrega.Value, prod.Id, cant , pre);
        }

        private void FrmOrden_Load(object sender, EventArgs e)
        {
            txtProducto.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecio.Enabled = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ordenNueva.Especificacion = txtEspecificaciones.Text;
            ordenNueva.Agregar(detOrden);

            if (HelperDB.GetInstancia().ConfirmarOrden(ordenNueva))
            {
                MessageBox.Show("Órden hecha con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }
    }
}
