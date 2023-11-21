namespace AutomotrizFront.Presentación
{
    partial class FrmDetalleFacturas
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
            dgvDetalles = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            btSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colProducto, colPrecio, colCantidad });
            dgvDetalles.Location = new Point(39, 24);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.Size = new Size(531, 241);
            dgvDetalles.TabIndex = 0;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "PRODUCTOS";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            colProducto.Width = 350;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "PRECIO";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 125;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "CANTIDAD";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 125;
            // 
            // btSalir
            // 
            btSalir.Location = new Point(284, 278);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(75, 23);
            btSalir.TabIndex = 1;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // FrmDetalleFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 14, 2);
            ClientSize = new Size(620, 310);
            Controls.Add(btSalir);
            Controls.Add(dgvDetalles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDetalleFacturas";
            Text = "FrmDetalleFacturas";
            Load += FrmDetalleFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantidad;
        private Button btSalir;
    }
}