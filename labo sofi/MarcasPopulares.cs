using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
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
    public partial class MarcasPopulares : Form
    {
        IServicio servicio;
        public MarcasPopulares()
        {
            InitializeComponent();
            servicio = new Servicio();
        }

        private void MarcasPopulares_Load(object sender, EventArgs e)
        {
            CargarTipos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarTipos()
        {
            cboTipoCliente.ValueMember = "Id";
            cboTipoCliente.DisplayMember = "Tipo";
            cboTipoCliente.DataSource = servicio.GetTipoCliente();
            cboTipoCliente.SelectedIndex = -1;
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dvgMarcasPopulares.Rows.Clear(); // Limpia las filas de la grilla si es necesario


            dvgMarcasPopulares.ClearSelection();
            TipoCliente tpCliente = (TipoCliente)cboTipoCliente.SelectedItem;
            int id_tipo_cliente = Convert.ToInt32(tpCliente.Id);
            List<Parametro> Param = new List<Parametro>();
            Param.Add(new Parametro("@tipo_cliente", id_tipo_cliente));


            DataTable t = HelperDB.GetInstancia().ConsultaParametros("sp_marcas_populares", Param);


            foreach (DataRow row in t.Rows)
            {
                // Creamos una nueva fila en el DataGridView.
                int rowIndex = dvgMarcasPopulares.Rows.Add();

                // Rellenamos cada celda de la fila con los datos del DataTable.
                dvgMarcasPopulares.Rows[rowIndex].Cells["Marca"].Value = row["marca"];
                dvgMarcasPopulares.Rows[rowIndex].Cells["Total_vendido"].Value = row["total_vendido"];
                dvgMarcasPopulares.Rows[rowIndex].Cells["Tipo_Cliente"].Value = row["tipo de cliente"];
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {


            FrmPrincipal a = new FrmPrincipal();
            this.Hide();
            a.ShowDialog();
            this.Close();


        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta consulta esta para mostrar las marcas mas populares segun los tipos de clientes," +
                " asi podra saber la preferencias de sus clientes con respecto a las diferentes marcas");
        }
    }
}
