namespace AutomotrizFront.Presentacion
{
    partial class FrmModificarCliente
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
            btnagregar = new Button();
            dgvAltaClientes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colRazonSocial = new DataGridViewTextBoxColumn();
            colCuil = new DataGridViewTextBoxColumn();
            colTipoCli = new DataGridViewTextBoxColumn();
            colContacto = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            btnCancelar = new Button();
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
            btnAceptar = new Button();
            btnAtras = new Button();
            label7 = new Label();
            label8 = new Label();
            txtContacto = new TextBox();
            label9 = new Label();
            cboTipoContacto = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAltaClientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.LightGray;
            btnagregar.Location = new Point(993, 195);
            btnagregar.Margin = new Padding(3, 2, 3, 2);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(106, 24);
            btnagregar.TabIndex = 31;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // dgvAltaClientes
            // 
            dgvAltaClientes.AllowUserToAddRows = false;
            dgvAltaClientes.AllowUserToDeleteRows = false;
            dgvAltaClientes.BackgroundColor = Color.FromArgb(101, 14, 2);
            dgvAltaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAltaClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colDireccion, colRazonSocial, colCuil, colTipoCli, colContacto, colAcciones });
            dgvAltaClientes.GridColor = SystemColors.ControlText;
            dgvAltaClientes.Location = new Point(144, 237);
            dgvAltaClientes.Margin = new Padding(3, 2, 3, 2);
            dgvAltaClientes.Name = "dgvAltaClientes";
            dgvAltaClientes.ReadOnly = true;
            dgvAltaClientes.RowHeadersWidth = 51;
            dgvAltaClientes.RowTemplate.Height = 29;
            dgvAltaClientes.Size = new Size(814, 134);
            dgvAltaClientes.TabIndex = 30;
            dgvAltaClientes.CellContentClick += dgvAltaClientes_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "Column1";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.Width = 125;
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
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.Location = new Point(592, 386);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 22);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(592, 171);
            label6.Name = "label6";
            label6.Size = new Size(98, 17);
            label6.TabIndex = 27;
            label6.Text = "Tipo Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(374, 170);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 26;
            label5.Text = "Barrio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(135, 170);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 25;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(605, 105);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 24;
            label3.Text = "Cuil-cuit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(345, 102);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 23;
            label2.Text = "Razon Social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(135, 104);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 22;
            label1.Text = "Nombre";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(534, 194);
            cboTipo.Margin = new Padding(3, 2, 3, 2);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(209, 23);
            cboTipo.TabIndex = 21;
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(312, 193);
            cboBarrio.Margin = new Padding(3, 2, 3, 2);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(187, 23);
            cboBarrio.TabIndex = 20;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(534, 130);
            txtCuil.Margin = new Padding(3, 2, 3, 2);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(209, 23);
            txtCuil.TabIndex = 19;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(85, 190);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(172, 23);
            txtDireccion.TabIndex = 18;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(312, 128);
            txtRazonSocial.Margin = new Padding(3, 2, 3, 2);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(187, 23);
            txtRazonSocial.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 128);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(172, 23);
            txtNombre.TabIndex = 16;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.LightGray;
            btnAceptar.Location = new Point(361, 386);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(146, 22);
            btnAceptar.TabIndex = 32;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.LightGray;
            btnAtras.Location = new Point(10, 436);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(54, 22);
            btnAtras.TabIndex = 33;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(505, 23);
            label7.Name = "label7";
            label7.Size = new Size(214, 29);
            label7.TabIndex = 34;
            label7.Text = "Modificar Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(836, 171);
            label8.Name = "label8";
            label8.Size = new Size(74, 17);
            label8.TabIndex = 38;
            label8.Text = "Contacto";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(765, 195);
            txtContacto.Margin = new Padding(3, 2, 3, 2);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(209, 23);
            txtContacto.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(821, 105);
            label9.Name = "label9";
            label9.Size = new Size(112, 17);
            label9.TabIndex = 36;
            label9.Text = "Tipo Contacto";
            // 
            // cboTipoContacto
            // 
            cboTipoContacto.FormattingEnabled = true;
            cboTipoContacto.Location = new Point(765, 130);
            cboTipoContacto.Margin = new Padding(3, 2, 3, 2);
            cboTipoContacto.Name = "cboTipoContacto";
            cboTipoContacto.Size = new Size(202, 23);
            cboTipoContacto.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-1, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 80);
            panel1.TabIndex = 71;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(36, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // FrmModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 14, 2);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1127, 466);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(txtContacto);
            Controls.Add(label9);
            Controls.Add(cboTipoContacto);
            Controls.Add(btnAtras);
            Controls.Add(btnAceptar);
            Controls.Add(btnagregar);
            Controls.Add(dgvAltaClientes);
            Controls.Add(btnCancelar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboTipo);
            Controls.Add(cboBarrio);
            Controls.Add(txtCuil);
            Controls.Add(txtDireccion);
            Controls.Add(txtRazonSocial);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmModificarCliente";
            Text = "Modificar";
            Load += FrmModificarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAltaClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnagregar;
        private DataGridView dgvAltaClientes;
        private Button btnCancelar;
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
        private DataGridViewTextBoxColumn Column1;
        private Button btnAceptar;
        private Button btnAtras;
        private Label label7;
        private Label label8;
        private TextBox txtContacto;
        private Label label9;
        private ComboBox cboTipoContacto;
        private DataGridViewTextBoxColumn colId;
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