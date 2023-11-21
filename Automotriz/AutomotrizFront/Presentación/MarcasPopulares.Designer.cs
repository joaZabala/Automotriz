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
            Marca = new DataGridViewTextBoxColumn();
            Total_vendido = new DataGridViewTextBoxColumn();
            Tipo_Cliente = new DataGridViewTextBoxColumn();
            btnAtras = new Button();
            btnConsultar = new Button();
            cboTipoCliente = new ComboBox();
            label3 = new Label();
            btnAyuda = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dvgMarcasPopulares).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dvgMarcasPopulares
            // 
            dvgMarcasPopulares.AllowUserToAddRows = false;
            dvgMarcasPopulares.AllowUserToDeleteRows = false;
            dvgMarcasPopulares.BackgroundColor = SystemColors.ActiveCaptionText;
            dvgMarcasPopulares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMarcasPopulares.Columns.AddRange(new DataGridViewColumn[] { Marca, Total_vendido, Tipo_Cliente });
            dvgMarcasPopulares.Location = new Point(179, 152);
            dvgMarcasPopulares.Name = "dvgMarcasPopulares";
            dvgMarcasPopulares.ReadOnly = true;
            dvgMarcasPopulares.RowHeadersWidth = 51;
            dvgMarcasPopulares.RowTemplate.Height = 25;
            dvgMarcasPopulares.Size = new Size(344, 298);
            dvgMarcasPopulares.TabIndex = 0;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 125;
            // 
            // Total_vendido
            // 
            Total_vendido.FillWeight = 300F;
            Total_vendido.HeaderText = "Total vendido";
            Total_vendido.MinimumWidth = 6;
            Total_vendido.Name = "Total_vendido";
            Total_vendido.ReadOnly = true;
            Total_vendido.Width = 65;
            // 
            // Tipo_Cliente
            // 
            Tipo_Cliente.HeaderText = "Tipo Cliente";
            Tipo_Cliente.MinimumWidth = 6;
            Tipo_Cliente.Name = "Tipo_Cliente";
            Tipo_Cliente.ReadOnly = true;
            Tipo_Cliente.Width = 150;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(10, 471);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(438, 110);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(86, 28);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button1_Click;
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Location = new Point(186, 114);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(230, 23);
            cboTipoCliente.TabIndex = 3;
            cboTipoCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Cursor = Cursors.No;
            label3.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(259, 31);
            label3.Name = "label3";
            label3.Size = new Size(188, 25);
            label3.TabIndex = 20;
            label3.Text = "Marcas Populares";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(570, 471);
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
            label1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(214, 92);
            label1.Name = "label1";
            label1.Size = new Size(98, 17);
            label1.TabIndex = 22;
            label1.Text = "Tipo Cliente";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-10, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 80);
            panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(20, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // MarcasPopulares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 14, 2);
            ClientSize = new Size(661, 508);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnAyuda);
            Controls.Add(cboTipoCliente);
            Controls.Add(btnConsultar);
            Controls.Add(btnAtras);
            Controls.Add(dvgMarcasPopulares);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MarcasPopulares";
            Text = "Marcas Populares";
            Load += MarcasPopulares_Load;
            ((System.ComponentModel.ISupportInitialize)dvgMarcasPopulares).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}