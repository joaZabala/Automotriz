namespace AutomotrizFront.Presentación
{
    partial class FrmAutoplanes
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
            btnConsultar = new Button();
            btnAtras = new Button();
            btnAyuda = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(411, 14);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(10, 353);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(411, 353);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(66, 23);
            btnAyuda.TabIndex = 3;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(121, 18);
            label1.Name = "label1";
            label1.Size = new Size(237, 17);
            label1.TabIndex = 4;
            label1.Text = "Consular Autoplanes Populares";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnConsultar);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 62);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(18, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(150, 100);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(200, 246);
            reportViewer1.TabIndex = 0;
            // 
            // FrmAutoplanes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 14, 2);
            ClientSize = new Size(497, 386);
            Controls.Add(panel1);
            Controls.Add(btnAyuda);
            Controls.Add(btnAtras);
            Controls.Add(reportViewer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAutoplanes";
            Text = "FrmAutoplanes";
            Load += FrmAutoplanes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnConsultar;
        private Button btnAtras;
        private Button btnAyuda;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}