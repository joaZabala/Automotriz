namespace AutomotrizFront.Presentación
{
    partial class frmMejorCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFechaDesde = new DateTimePicker();
            label1 = new Label();
            dgvMejoresClientes = new DataGridView();
            ColCliente = new DataGridViewTextBoxColumn();
            ColCantidadProductos = new DataGridViewTextBoxColumn();
            ColSubTotal = new DataGridViewTextBoxColumn();
            ColAccion = new DataGridViewButtonColumn();
            btnConsultar = new Button();
            lblTotal = new Label();
            btnAyuda = new Button();
            btnSalir = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvMejoresClientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(242, 94);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(113, 29);
            dtpFechaDesde.TabIndex = 0;
            dtpFechaDesde.ValueChanged += dtpFechaDesde_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(99, 100);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 1;
            label1.Text = "Fecha desde:";
            label1.Click += label1_Click;
            // 
            // dgvMejoresClientes
            // 
            dgvMejoresClientes.AllowUserToAddRows = false;
            dgvMejoresClientes.AllowUserToDeleteRows = false;
            dgvMejoresClientes.BackgroundColor = Color.FromArgb(101, 14, 2);
            dgvMejoresClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMejoresClientes.Columns.AddRange(new DataGridViewColumn[] { ColCliente, ColCantidadProductos, ColSubTotal, ColAccion });
            dgvMejoresClientes.Location = new Point(88, 136);
            dgvMejoresClientes.Name = "dgvMejoresClientes";
            dgvMejoresClientes.ReadOnly = true;
            dgvMejoresClientes.RowHeadersWidth = 51;
            dgvMejoresClientes.RowTemplate.Height = 25;
            dgvMejoresClientes.Size = new Size(705, 260);
            dgvMejoresClientes.TabIndex = 2;
            dgvMejoresClientes.CellContentClick += dgvMejoresClientes_CellContentClick;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.MinimumWidth = 6;
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            ColCliente.Width = 300;
            // 
            // ColCantidadProductos
            // 
            ColCantidadProductos.HeaderText = "Cantidad Productos";
            ColCantidadProductos.MinimumWidth = 6;
            ColCantidadProductos.Name = "ColCantidadProductos";
            ColCantidadProductos.ReadOnly = true;
            ColCantidadProductos.Width = 200;
            // 
            // ColSubTotal
            // 
            ColSubTotal.HeaderText = "Sub Total";
            ColSubTotal.MinimumWidth = 6;
            ColSubTotal.Name = "ColSubTotal";
            ColSubTotal.ReadOnly = true;
            ColSubTotal.Width = 125;
            // 
            // ColAccion
            // 
            ColAccion.HeaderText = "Acción";
            ColAccion.MinimumWidth = 6;
            ColAccion.Name = "ColAccion";
            ColAccion.ReadOnly = true;
            ColAccion.Text = "Contacto";
            ColAccion.UseColumnTextForButtonValue = true;
            ColAccion.Width = 125;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(699, 94);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.ButtonFace;
            lblTotal.Location = new Point(565, 439);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 18);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: ";
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(19, 448);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(75, 23);
            btnAyuda.TabIndex = 5;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(121, 448);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(-11, -4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 81);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(352, 38);
            label2.Name = "label2";
            label2.Size = new Size(176, 24);
            label2.TabIndex = 68;
            label2.Text = "Mejores clientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(22, 13);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // frmMejorCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 14, 2);
            ClientSize = new Size(874, 481);
            Controls.Add(panel1);
            Controls.Add(btnSalir);
            Controls.Add(btnAyuda);
            Controls.Add(lblTotal);
            Controls.Add(btnConsultar);
            Controls.Add(dgvMejoresClientes);
            Controls.Add(label1);
            Controls.Add(dtpFechaDesde);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMejorCliente";
            Text = "Mejores Clientes";
            Load += frmMejorCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMejoresClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaDesde;
        private Label label1;
        private DataGridView dgvMejoresClientes;
        private Button btnConsultar;
        private Label lblTotal;
        private Button btnAyuda;
        private Button btnSalir;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColCantidadProductos;
        private DataGridViewTextBoxColumn ColSubTotal;
        private DataGridViewButtonColumn ColAccion;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}