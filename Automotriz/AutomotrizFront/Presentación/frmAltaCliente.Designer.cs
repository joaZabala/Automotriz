namespace AutomotriszFront.Presentacion
{
    partial class frmAltaCliente
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
            button1 = new Button();
            btnCancelar = new Button();
            btnagregar = new Button();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtContacto = new TextBox();
            label7 = new Label();
            cboTipoContacto = new ComboBox();
            dgvAltaClientes = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colBarrio = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colRazonSocial = new DataGridViewTextBoxColumn();
            colCuil = new DataGridViewTextBoxColumn();
            colTipoCli = new DataGridViewTextBoxColumn();
            colContacto = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboTipo = new ComboBox();
            cboBarrio = new ComboBox();
            txtCuil = new TextBox();
            txtDireccion = new TextBox();
            txtRazonSocial = new TextBox();
            txtNombre = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAltaClientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(300, 422);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(146, 22);
            button1.TabIndex = 12;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(585, 422);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 22);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnagregar
            // 
            btnagregar.ForeColor = SystemColors.ActiveCaptionText;
            btnagregar.Location = new Point(956, 120);
            btnagregar.Margin = new Padding(3, 2, 3, 2);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(71, 28);
            btnagregar.TabIndex = 15;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1006, 480);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 21);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtContacto);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnagregar);
            groupBox1.Controls.Add(cboTipoContacto);
            groupBox1.Controls.Add(dgvAltaClientes);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboTipo);
            groupBox1.Controls.Add(cboBarrio);
            groupBox1.Controls.Add(txtCuil);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(38, 84);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1044, 320);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(793, 98);
            label8.Name = "label8";
            label8.Size = new Size(74, 17);
            label8.TabIndex = 39;
            label8.Text = "Contacto";
            label8.Click += label8_Click_1;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(724, 120);
            txtContacto.Margin = new Padding(3, 2, 3, 2);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(209, 23);
            txtContacto.TabIndex = 38;
            txtContacto.TextChanged += txtContacto_TextChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(765, 28);
            label7.Name = "label7";
            label7.Size = new Size(112, 17);
            label7.TabIndex = 37;
            label7.Text = "Tipo Contacto";
            label7.Click += label7_Click_1;
            // 
            // cboTipoContacto
            // 
            cboTipoContacto.FormattingEnabled = true;
            cboTipoContacto.Location = new Point(724, 57);
            cboTipoContacto.Margin = new Padding(3, 2, 3, 2);
            cboTipoContacto.Name = "cboTipoContacto";
            cboTipoContacto.Size = new Size(202, 23);
            cboTipoContacto.TabIndex = 36;
            cboTipoContacto.SelectedIndexChanged += cboTipoContacto_SelectedIndexChanged_1;
            // 
            // dgvAltaClientes
            // 
            dgvAltaClientes.AllowUserToAddRows = false;
            dgvAltaClientes.AllowUserToDeleteRows = false;
            dgvAltaClientes.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvAltaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAltaClientes.Columns.AddRange(new DataGridViewColumn[] { colNombre, colBarrio, colDireccion, colRazonSocial, colCuil, colTipoCli, colContacto, colAcciones });
            dgvAltaClientes.GridColor = SystemColors.ActiveCaptionText;
            dgvAltaClientes.Location = new Point(27, 171);
            dgvAltaClientes.Margin = new Padding(3, 2, 3, 2);
            dgvAltaClientes.Name = "dgvAltaClientes";
            dgvAltaClientes.ReadOnly = true;
            dgvAltaClientes.RowHeadersWidth = 51;
            dgvAltaClientes.RowTemplate.Height = 29;
            dgvAltaClientes.Size = new Size(921, 132);
            dgvAltaClientes.TabIndex = 34;
            dgvAltaClientes.CellContentClick += dgvAltaClientes_CellContentClick_1;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 125;
            // 
            // colBarrio
            // 
            colBarrio.HeaderText = "Barrio";
            colBarrio.MinimumWidth = 6;
            colBarrio.Name = "colBarrio";
            colBarrio.ReadOnly = true;
            colBarrio.Width = 125;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(547, 94);
            label6.Name = "label6";
            label6.Size = new Size(98, 17);
            label6.TabIndex = 33;
            label6.Text = "Tipo Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(324, 98);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 32;
            label5.Text = "Barrio";
            label5.Click += label5_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(72, 98);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 31;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(547, 28);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 30;
            label3.Text = "Cuil-cuit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(284, 28);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 29;
            label2.Text = "Razon Social";
            label2.Click += label2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(84, 28);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 28;
            label1.Text = "Nombre";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(480, 118);
            cboTipo.Margin = new Padding(3, 2, 3, 2);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(209, 23);
            cboTipo.TabIndex = 27;
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(248, 122);
            cboBarrio.Margin = new Padding(3, 2, 3, 2);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(187, 23);
            cboBarrio.TabIndex = 26;
            cboBarrio.SelectedIndexChanged += cboBarrio_SelectedIndexChanged_1;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(480, 53);
            txtCuil.Margin = new Padding(3, 2, 3, 2);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(209, 23);
            txtCuil.TabIndex = 25;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(27, 122);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(172, 23);
            txtDireccion.TabIndex = 24;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(248, 58);
            txtRazonSocial.Margin = new Padding(3, 2, 3, 2);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(187, 23);
            txtRazonSocial.TabIndex = 23;
            txtRazonSocial.TextChanged += txtRazonSocial_TextChanged_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(27, 55);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(172, 23);
            txtNombre.TabIndex = 22;
            txtNombre.KeyPress += txtNombre_KeyPress_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-5, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 81);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(455, 20);
            label9.Name = "label9";
            label9.Size = new Size(168, 27);
            label9.TabIndex = 24;
            label9.Text = "Nuevo cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = AutomotrizFront.Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(16, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // frmAltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 14, 2);
            ClientSize = new Size(1101, 510);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAltaCliente";
            Text = "Registrar cliente";
            Load += frmAltaCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAltaClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button btnCancelar;
        private Button btnagregar;
        private Button btnSalir;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtContacto;
        private Label label7;
        private ComboBox cboTipoContacto;
        private DataGridView dgvAltaClientes;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colBarrio;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colRazonSocial;
        private DataGridViewTextBoxColumn colCuil;
        private DataGridViewTextBoxColumn colTipoCli;
        private DataGridViewTextBoxColumn colContacto;
        private DataGridViewButtonColumn colAcciones;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboTipo;
        private ComboBox cboBarrio;
        private TextBox txtCuil;
        private TextBox txtDireccion;
        private TextBox txtRazonSocial;
        private TextBox txtNombre;
        private Panel panel1;
        private Label label9;
        private PictureBox pictureBox1;
    }
}