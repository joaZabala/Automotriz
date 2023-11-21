using AutomotrizBack.Datos.Implementaciones;
using AutomotrizBack.Entidades;
using AutomotrizBack.Servicio;
using AutomotrizFront;
using AutomotrizFront.ClienteH;
using AutomotrizFront.Presentacion;
using Microsoft.VisualBasic;
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

        private async void CargarTipoCli()
        {

            string url = "https://localhost:7063/api/Cliente/TipoCliente";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoCliente>>(result);

            cboTipo.DataSource = lst;
            cboTipo.DisplayMember = "Tipo";
            cboTipo.ValueMember = "Id";
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {

            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar untipo de cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe introducir el nombre de un cliente");
                return;
            }
            string nombre = txtNombre.Text; // nombre del cliente que quiero buscar

            TipoCliente tipo = (TipoCliente)cboTipo.SelectedItem; // obtengo el tipo de cliente que quiero bsucar
            int id_tipo = tipo.Id;
            string tipo_nom = tipo.Tipo;


            string url = string.Format("https://localhost:7063/api/Cliente/GetByFilters?tipo_cli={0}&name={1}", tipo.Id, nombre);
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(result);

            clientes = lst;   


            foreach (Cliente c in clientes)
            {
                string ur = string.Format("https://localhost:7063/api/Cliente/GetContactoById?cod_cliente={0}", c.Cod);
                var resultado = await ClienteSingleton.GetInstancia().GetAsync(ur);
                var list = JsonConvert.DeserializeObject<List<Contacto>>(resultado);
                
                foreach (Contacto contacto in list)
                {
                    dgvClientes.Rows.Add(new object[] { c.Cod,c.Nombre,c.Direccion,c.RazonSocial
                   ,c.CuilCuit,tipo_nom,contacto.Descripcion,"Editar" });
                }

            }


        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            if (dgvClientes.CurrentCell.ColumnIndex == 7)
            {
                if (MessageBox.Show("Desea editar el cliente " + "' " + nombre + "'?", "Question",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Codigo = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value.ToString());

                    FrmModificarCliente modificar = new FrmModificarCliente(Codigo, new FabricaServicioImp());
                    modificar.ShowDialog();

                    dgvClientes.Rows.Clear();
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
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            int nro = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value.ToString());

            string url = string.Format("https://localhost:7063/api/Cliente/Delete?id={0}", nro);
            var result = await ClienteSingleton.GetInstancia().DeleteAsync(url);


            if (MessageBox.Show("Esta seguro  que quiere dar de baja a " +
                nombre + "?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (result.Equals("cliente eliminado correctamente"))
                {
                    MessageBox.Show("Cliente " + nro + " dado de baja", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvClientes.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("no se pudo dar de baja al cliente ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
