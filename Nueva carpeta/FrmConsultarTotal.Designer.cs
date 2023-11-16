namespace AutomotrizFront.Presentación
{
    partial class FrmConsultarTotal
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
            groupBox1 = new GroupBox();
            btnConsultar = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            label3 = new Label();
            dgvTotal = new DataGridView();
            ColTotal = new DataGridViewTextBoxColumn();
            ColPromedio = new DataGridViewTextBoxColumn();
            ColCantidadFac = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotal).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpHasta);
            groupBox1.Controls.Add(dtpDesde);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(88, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(823, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametros";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(719, 106);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 56);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 7;
            label2.Text = "Fecha hasta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 56);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 6;
            label1.Text = "Fecha Desde:";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(507, 51);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(219, 27);
            dtpHasta.TabIndex = 5;
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(120, 51);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(200, 27);
            dtpDesde.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(374, 22);
            label3.Name = "label3";
            label3.Size = new Size(201, 31);
            label3.TabIndex = 2;
            label3.Text = "Montos Totales";
            // 
            // dgvTotal
            // 
            dgvTotal.AllowUserToAddRows = false;
            dgvTotal.AllowUserToDeleteRows = false;
            dgvTotal.BackgroundColor = Color.LightGray;
            dgvTotal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotal.Columns.AddRange(new DataGridViewColumn[] { ColTotal, ColPromedio, ColCantidadFac });
            dgvTotal.Location = new Point(268, 258);
            dgvTotal.Name = "dgvTotal";
            dgvTotal.ReadOnly = true;
            dgvTotal.RowHeadersWidth = 51;
            dgvTotal.RowTemplate.Height = 29;
            dgvTotal.Size = new Size(428, 188);
            dgvTotal.TabIndex = 0;
            // 
            // ColTotal
            // 
            ColTotal.FillWeight = 250F;
            ColTotal.HeaderText = "Total";
            ColTotal.MinimumWidth = 6;
            ColTotal.Name = "ColTotal";
            ColTotal.ReadOnly = true;
            ColTotal.Width = 125;
            // 
            // ColPromedio
            // 
            ColPromedio.FillWeight = 250F;
            ColPromedio.HeaderText = "Promedio";
            ColPromedio.MinimumWidth = 6;
            ColPromedio.Name = "ColPromedio";
            ColPromedio.ReadOnly = true;
            ColPromedio.Width = 125;
            // 
            // ColCantidadFac
            // 
            ColCantidadFac.FillWeight = 250F;
            ColCantidadFac.HeaderText = "Cantidad de facturas";
            ColCantidadFac.MinimumWidth = 6;
            ColCantidadFac.Name = "ColCantidadFac";
            ColCantidadFac.ReadOnly = true;
            ColCantidadFac.Width = 125;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(830, 468);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 468);
            button1.Name = "button1";
            button1.Size = new Size(65, 28);
            button1.TabIndex = 5;
            button1.Text = "Ayuda";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmConsultarTotal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(945, 509);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(dgvTotal);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FrmConsultarTotal";
            Text = "FrmConsultarTotal";
            Load += FrmConsultarTotal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Label label3;
        private Button btnConsultar;
        private DataGridView dgvTotal;
        private DataGridViewTextBoxColumn ColTotal;
        private DataGridViewTextBoxColumn ColPromedio;
        private DataGridViewTextBoxColumn ColCantidadFac;
        private Button btnSalir;
        private Button button1;
    }
}