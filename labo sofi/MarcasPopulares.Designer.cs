namespace AutomotrizFront.Presentación
{
    partial class MarcasPopulares
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
            dvgMarcasPopulares = new DataGridView();
            btnAtras = new Button();
            btnConsultar = new Button();
            cboTipoCliente = new ComboBox();
            label3 = new Label();
            btnAyuda = new Button();
            label1 = new Label();
            Marca = new DataGridViewTextBoxColumn();
            Total_vendido = new DataGridViewTextBoxColumn();
            Tipo_Cliente = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dvgMarcasPopulares).BeginInit();
            SuspendLayout();
            // 
            // dvgMarcasPopulares
            // 
            dvgMarcasPopulares.AllowUserToAddRows = false;
            dvgMarcasPopulares.AllowUserToDeleteRows = false;
            dvgMarcasPopulares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMarcasPopulares.Columns.AddRange(new DataGridViewColumn[] { Marca, Total_vendido, Tipo_Cliente });
            dvgMarcasPopulares.Location = new Point(38, 60);
            dvgMarcasPopulares.Name = "dvgMarcasPopulares";
            dvgMarcasPopulares.ReadOnly = true;
            dvgMarcasPopulares.RowTemplate.Height = 25;
            dvgMarcasPopulares.Size = new Size(305, 350);
            dvgMarcasPopulares.TabIndex = 0;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(12, 416);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(404, 155);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(86, 43);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button1_Click;
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Location = new Point(381, 75);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(131, 23);
            cboTipoCliente.TabIndex = 3;
            cboTipoCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 9);
            label3.Name = "label3";
            label3.Size = new Size(179, 26);
            label3.TabIndex = 20;
            label3.Text = "Marcas Populares";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(404, 363);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(86, 27);
            btnAyuda.TabIndex = 21;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 32);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 22;
            label1.Text = "Tipo de cliente";
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Total_vendido
            // 
            Total_vendido.FillWeight = 300F;
            Total_vendido.HeaderText = "Total vendido";
            Total_vendido.Name = "Total_vendido";
            Total_vendido.ReadOnly = true;
            Total_vendido.Width = 60;
            // 
            // Tipo_Cliente
            // 
            Tipo_Cliente.HeaderText = "Tipo Cliente";
            Tipo_Cliente.Name = "Tipo_Cliente";
            Tipo_Cliente.ReadOnly = true;
            // 
            // MarcasPopulares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 451);
            Controls.Add(label1);
            Controls.Add(btnAyuda);
            Controls.Add(label3);
            Controls.Add(cboTipoCliente);
            Controls.Add(btnConsultar);
            Controls.Add(btnAtras);
            Controls.Add(dvgMarcasPopulares);
            Name = "MarcasPopulares";
            Text = "Marcas Populares";
            Load += MarcasPopulares_Load;
            ((System.ComponentModel.ISupportInitialize)dvgMarcasPopulares).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgMarcasPopulares;
        private Button btnAtras;
        private Button btnConsultar;
        private ComboBox cboTipoCliente;
        private Label label3;
        private Button btnAyuda;
        private Label label1;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Total_vendido;
        private DataGridViewTextBoxColumn Tipo_Cliente;
    }
}