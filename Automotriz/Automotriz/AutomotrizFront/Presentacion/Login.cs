using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentacion
{
    public partial class Login : Form
    {
        string user = "solo autos";
        string contra = "Automotriz";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Ingrese usuario y contraseña", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return;
            }
            if (txtUser.Text != user || txtContra.Text != contra)
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }

            FrmPrincipal princ = new FrmPrincipal();
            princ.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                this.Dispose();
        }
    }
}
