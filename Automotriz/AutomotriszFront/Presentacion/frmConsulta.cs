using AutomotrizBack.Datos.Implementacion;
using AutomotrizBack.Entidades;
using AutomotrizBack.servicios;
using AutomotrizFront;
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

namespace AutomotriszFront.Presentacion
{
    public partial class frmConsulta : Form
    {
        IServicio servicio;
        List<Cliente> clientes;
        int Codigo = 0;
        public frmConsulta(FabricaServicioImp factory)
        {
            InitializeComponent();
            servicio = factory.CrearServicio();
            clientes = new List<Cliente>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            CargarTipoCli();
        }

        private void CargarTipoCli()
        {
            cboTipo.DataSource = servicio.GetTipoCliente();
            cboTipo.DisplayMember = "Tipo";
            cboTipo.ValueMember = "id";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrEmpty(txtNombre.Text) && cboTipo.SelectedIndex == -1)
            //{
            //    clientes = servicio.GetClientes();
            //    foreach (Cliente c in clientes)
            //    {
            //        dgvClientes.Rows.Add(new object[] { c.Nombre,c.Barrio,c.Direccion,c.RazonSocial
            //    ,c.CuilCuit,c.Tipo.Tipo,"quitar"});
            //    }
            //}
            string nombre = txtNombre.Text;
            TipoCliente tipo = (TipoCliente)cboTipo.SelectedItem;
            int id_tipo = tipo.Id;
            string tipo_nom = tipo.Tipo;

            clientes = servicio.GetByParam(nombre, id_tipo);

            foreach (Cliente c in clientes)
            {
                dgvClientes.Rows.Add(new object[] { c.Cod,c.Nombre,c.Direccion,c.RazonSocial
                ,c.CuilCuit,tipo_nom,"Editar"});
            }

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            if (dgvClientes.CurrentCell.ColumnIndex == 6)
            {
                if(MessageBox.Show("Desea editar el cliente "+"' "+ nombre+"'?","Question",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Codigo = Convert.ToInt32( dgvClientes.CurrentRow.Cells[0].Value.ToString());

                  FrmModificarCliente modificar = new FrmModificarCliente(Codigo, new FabricaServicioImp());
                    modificar.ShowDialog(); 
                }
            }

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada en el DataGridView
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Habilita el botón si hay una fila seleccionada
                btnEliminar.Enabled = true;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            int nro = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value.ToString());

            if (MessageBox.Show("Esta seguro  que quiere borra para siempre el cliente " +
                nombre + "?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (servicio.DeleteCliente(nro))
                {
                    MessageBox.Show("Cliente " + nro + " borrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("no se pudo borrar el cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                this.Dispose();
        }
    }
}
