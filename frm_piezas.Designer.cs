namespace AutomotrizFront.Presentación
{
    partial class frm_piezas
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
            dgv_piezas = new DataGridView();
            c_año = new DataGridViewTextBoxColumn();
            c_producto = new DataGridViewTextBoxColumn();
            c_cantidad = new DataGridViewTextBoxColumn();
            c_ubicacion = new DataGridViewTextBoxColumn();
            btn_consultar = new Button();
            btn_salir = new Button();
            cbo_zona = new ComboBox();
            nud_cantidad = new NumericUpDown();
            lbl_zona = new Label();
            lbl_cantidad = new Label();
            btn_help = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_piezas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).BeginInit();
            SuspendLayout();
            // 
            // dgv_piezas
            // 
            dgv_piezas.AllowUserToAddRows = false;
            dgv_piezas.AllowUserToDeleteRows = false;
            dgv_piezas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_piezas.Columns.AddRange(new DataGridViewColumn[] { c_año, c_producto, c_cantidad, c_ubicacion });
            dgv_piezas.Location = new Point(12, 180);
            dgv_piezas.Name = "dgv_piezas";
            dgv_piezas.ReadOnly = true;
            dgv_piezas.RowTemplate.Height = 25;
            dgv_piezas.Size = new Size(546, 150);
            dgv_piezas.TabIndex = 0;
            dgv_piezas.CellContentClick += dgv_piezas_CellContentClick;
            // 
            // c_año
            // 
            c_año.HeaderText = "Año y Mes de Fabricacion";
            c_año.Name = "c_año";
            c_año.ReadOnly = true;
            c_año.Width = 200;
            // 
            // c_producto
            // 
            c_producto.HeaderText = "Producto";
            c_producto.Name = "c_producto";
            c_producto.ReadOnly = true;
            // 
            // c_cantidad
            // 
            c_cantidad.HeaderText = "Cantidad";
            c_cantidad.Name = "c_cantidad";
            c_cantidad.ReadOnly = true;
            // 
            // c_ubicacion
            // 
            c_ubicacion.HeaderText = "Ubicacion";
            c_ubicacion.Name = "c_ubicacion";
            c_ubicacion.ReadOnly = true;
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(483, 106);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(75, 23);
            btn_consultar.TabIndex = 1;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(483, 356);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 2;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // cbo_zona
            // 
            cbo_zona.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_zona.FormattingEnabled = true;
            cbo_zona.Location = new Point(12, 38);
            cbo_zona.Name = "cbo_zona";
            cbo_zona.Size = new Size(216, 23);
            cbo_zona.TabIndex = 3;
            // 
            // nud_cantidad
            // 
            nud_cantidad.Location = new Point(13, 106);
            nud_cantidad.Name = "nud_cantidad";
            nud_cantidad.Size = new Size(215, 23);
            nud_cantidad.TabIndex = 4;
            // 
            // lbl_zona
            // 
            lbl_zona.AutoSize = true;
            lbl_zona.Location = new Point(12, 20);
            lbl_zona.Name = "lbl_zona";
            lbl_zona.Size = new Size(34, 15);
            lbl_zona.TabIndex = 5;
            lbl_zona.Text = "Zona";
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(13, 88);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(99, 15);
            lbl_cantidad.TabIndex = 6;
            lbl_cantidad.Text = "Cantidad Minima";
            lbl_cantidad.Click += label2_Click;
            // 
            // btn_help
            // 
            btn_help.Location = new Point(483, 38);
            btn_help.Name = "btn_help";
            btn_help.Size = new Size(75, 23);
            btn_help.TabIndex = 7;
            btn_help.Text = "Ayuda";
            btn_help.UseVisualStyleBackColor = true;
            btn_help.Click += btn_help_Click;
            // 
            // frm_piezas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 401);
            Controls.Add(btn_help);
            Controls.Add(lbl_cantidad);
            Controls.Add(lbl_zona);
            Controls.Add(nud_cantidad);
            Controls.Add(cbo_zona);
            Controls.Add(btn_salir);
            Controls.Add(btn_consultar);
            Controls.Add(dgv_piezas);
            Name = "frm_piezas";
            Text = "Ubicador de Piezas en la Compania";
            Load += frm_piezas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_piezas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_piezas;
        private DataGridViewTextBoxColumn c_año;
        private DataGridViewTextBoxColumn c_producto;
        private DataGridViewTextBoxColumn c_cantidad;
        private DataGridViewTextBoxColumn c_ubicacion;
        private Button btn_consultar;
        private Button btn_salir;
        private ComboBox cbo_zona;
        private NumericUpDown nud_cantidad;
        private Label lbl_zona;
        private Label lbl_cantidad;
        private Button btn_help;
    }
}