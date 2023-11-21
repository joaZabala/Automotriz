namespace AutomotriszFront.Presentacion
{
    partial class frmConsulta
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
            txtNombre = new TextBox();
            label1 = new Label();
            cboTipo = new ComboBox();
            label2 = new Label();
            dgvClientes = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colRazonSocial = new DataGridViewTextBoxColumn();
            colCuil = new DataGridViewTextBoxColumn();
            colTipoCli = new DataGridViewTextBoxColumn();
            colContacto = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            btnConsultar = new Button();
            btnSalir = new Button();
            label3 = new Label();
            btnEliminar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 109);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(99, 113);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(516, 107);
            cboTipo.Margin = new Padding(3, 2, 3, 2);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(213, 23);
            cboTipo.TabIndex = 2;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(408, 112);
            label2.Name = "label2";
            label2.Size = new Size(97, 18);
            label2.TabIndex = 3;
            label2.Text = "Tipo cliente";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ColID, colNombre, colDireccion, colRazonSocial, colCuil, colTipoCli, colContacto, colAcciones });
            dgvClientes.Location = new Point(108, 146);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(822, 152);
            dgvClientes.TabIndex = 15;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // ColID
            // 
            ColID.HeaderText = "Column1";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Visible = false;
            ColID.Width = 125;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 125;
            // 
            // colDireccion
            // 
            colDireccion.HeaderText = "Direccion";
            colDireccion.MinimumWidth = 6;
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            colDireccion.Width = 125;
            // 
            // colRazonSocial
            // 
            colRazonSocial.HeaderText = "Razon Social";
            colRazonSocial.MinimumWidth = 6;
            colRazonSocial.Name = "colRazonSocial";
            colRazonSocial.ReadOnly = true;
            colRazonSocial.Width = 125;
            // 
            // colCuil
            // 
            colCuil.HeaderText = "Cuil";
            colCuil.MinimumWidth = 6;
            colCuil.Name = "colCuil";
            colCuil.ReadOnly = true;
            colCuil.Width = 125;
            // 
            // colTipoCli
            // 
            colTipoCli.HeaderText = "Tipo cliente";
            colTipoCli.MinimumWidth = 6;
            colTipoCli.Name = "colTipoCli";
            colTipoCli.ReadOnly = true;
            colTipoCli.Width = 125;
            // 
            // colContacto
            // 
            colContacto.HeaderText = "Contacto";
            colContacto.MinimumWidth = 6;
            colContacto.Name = "colContacto";
            colContacto.ReadOnly = true;
            colContacto.Width = 125;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            colAcciones.Text = "";
            colAcciones.Width = 125;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(752, 108);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(82, 22);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(953, 323);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 22);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(499, 22);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 18;
            label3.Text = "Clientes";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(847, 110);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 73);
            panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = AutomotrizFront.Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(15, 8);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // frmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 14, 2);
            ClientSize = new Size(1057, 354);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(dgvClientes);
            Controls.Add(label2);
            Controls.Add(cboTipo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConsulta";
            Text = "Consultar";
            Load += frmConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private ComboBox cboTipo;
        private Label label2;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn colBarrio;
        private Button btnConsultar;
        private Button btnSalir;
        private Label label3;
        private Button btnEliminar;
        private Button btnAtras;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colRazonSocial;
        private DataGridViewTextBoxColumn colCuil;
        private DataGridViewTextBoxColumn colTipoCli;
        private DataGridViewTextBoxColumn colContacto;
        private DataGridViewButtonColumn colAcciones;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}