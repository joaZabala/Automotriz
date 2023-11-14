﻿namespace AutomotriszFront.Presentacion
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
            colAcciones = new DataGridViewButtonColumn();
            btnConsultar = new Button();
            btnSalir = new Button();
            label3 = new Label();
            btnEliminar = new Button();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 82);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 87);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(426, 82);
            cboTipo.Margin = new Padding(3, 2, 3, 2);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 23);
            cboTipo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 87);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Tipo cliente";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ColID, colNombre, colDireccion, colRazonSocial, colCuil, colTipoCli, colAcciones });
            dgvClientes.Location = new Point(79, 119);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(705, 134);
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
            btnConsultar.Location = new Point(602, 80);
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
            btnSalir.Location = new Point(702, 272);
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
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(353, 16);
            label3.Name = "label3";
            label3.Size = new Size(87, 26);
            label3.TabIndex = 18;
            label3.Text = "Clientes";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(702, 80);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(602, 272);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(82, 22);
            btnAtras.TabIndex = 20;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // frmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 316);
            Controls.Add(btnAtras);
            Controls.Add(btnEliminar);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(dgvClientes);
            Controls.Add(label2);
            Controls.Add(cboTipo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmConsulta";
            Text = "Consultar";
            Load += frmConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
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
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colRazonSocial;
        private DataGridViewTextBoxColumn colCuil;
        private DataGridViewTextBoxColumn colTipoCli;
        private DataGridViewButtonColumn colAcciones;
        private Button btnAtras;
    }
}