using AutomotrizBack.Datos;
using AutomotrizBack.Servicio;
using AutomotrizFront.Presentacion;
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
    public partial class frmMejorCliente : Form
    {
        public frmMejorCliente()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value == DateTime.Now || dtpFechaDesde.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser mayor a la actual", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@Fecha", dtpFechaDesde.Value.ToString("yyyyMMdd")));

            DataTable tabla = HelperDB.GetInstancia().ConsultaParametros("SP_MEJORES_CLIENTES", lst);

            dgvMejoresClientes.Rows.Clear();
            decimal total = 0;
            foreach (DataRow fila in tabla.Rows)
            {
                dgvMejoresClientes.Rows.Add(new object[] { fila["CLIENTE"].ToString(),

                                                        fila["CANTIDAD_PRODUCTOS"].ToString(),
                                                        fila["SUB_TOTAL"].ToString(),});

                total += Convert.ToDecimal(fila["SUB_TOTAL"].ToString());
            }
            lblTotal.Text = "Total: " + total.ToString() + " $";
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta ventana facilita la visualización de los diez clientes más destacados en un intervalo de fechas específico, comenzando desde la fecha ingresada hasta el día actual. En ella, se exhiben el nombre del cliente, la cantidad de productos adquiridos, el monto total gastado por el cliente y se presenta la suma global de todos los subtotales correspondientes a los clientes.", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvMejoresClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            string nombre = dgvMejoresClientes.CurrentRow.Cells[0].Value.ToString();

            if (dgvMejoresClientes.CurrentCell.ColumnIndex == 3)
            {
                frmContactoCliente contacto = new frmContactoCliente(nombre);
                this.Hide();
                contacto.ShowDialog();
            }
            else { }
        }

        private void frmMejorCliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
