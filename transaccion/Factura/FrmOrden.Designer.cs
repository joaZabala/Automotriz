namespace Factura
{
    partial class FrmOrden
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
            this.grpMaestro = new System.Windows.Forms.GroupBox();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.lblOrdendePedido = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtEspecificaciones = new System.Windows.Forms.TextBox();
            this.lblEspecificaciones = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.grpMaestro.SuspendLayout();
            this.grpDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaestro
            // 
            this.grpMaestro.Controls.Add(this.txtEspecificaciones);
            this.grpMaestro.Controls.Add(this.lblEspecificaciones);
            this.grpMaestro.Location = new System.Drawing.Point(12, 63);
            this.grpMaestro.Name = "grpMaestro";
            this.grpMaestro.Size = new System.Drawing.Size(776, 73);
            this.grpMaestro.TabIndex = 0;
            this.grpMaestro.TabStop = false;
            this.grpMaestro.Text = "Maestro";
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.lblMoneda);
            this.grpDetalles.Controls.Add(this.lblCantidad);
            this.grpDetalles.Controls.Add(this.lblPrecio);
            this.grpDetalles.Controls.Add(this.txtPrecio);
            this.grpDetalles.Controls.Add(this.txtCantidad);
            this.grpDetalles.Controls.Add(this.txtProducto);
            this.grpDetalles.Controls.Add(this.dtpFechaEntrega);
            this.grpDetalles.Controls.Add(this.lblEntrega);
            this.grpDetalles.Controls.Add(this.lblProducto);
            this.grpDetalles.Location = new System.Drawing.Point(12, 151);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(776, 135);
            this.grpDetalles.TabIndex = 1;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles";
            // 
            // lblOrdendePedido
            // 
            this.lblOrdendePedido.AutoSize = true;
            this.lblOrdendePedido.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdendePedido.Location = new System.Drawing.Point(303, 9);
            this.lblOrdendePedido.Name = "lblOrdendePedido";
            this.lblOrdendePedido.Size = new System.Drawing.Size(216, 28);
            this.lblOrdendePedido.TabIndex = 2;
            this.lblOrdendePedido.Text = "ÓRDEN DE PEDIDO";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(371, 292);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtEspecificaciones
            // 
            this.txtEspecificaciones.Location = new System.Drawing.Point(281, 32);
            this.txtEspecificaciones.Name = "txtEspecificaciones";
            this.txtEspecificaciones.Size = new System.Drawing.Size(206, 20);
            this.txtEspecificaciones.TabIndex = 0;
            // 
            // lblEspecificaciones
            // 
            this.lblEspecificaciones.AutoSize = true;
            this.lblEspecificaciones.Location = new System.Drawing.Point(338, 16);
            this.lblEspecificaciones.Name = "lblEspecificaciones";
            this.lblEspecificaciones.Size = new System.Drawing.Size(87, 13);
            this.lblEspecificaciones.TabIndex = 4;
            this.lblEspecificaciones.Text = "Especificaciones";
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Location = new System.Drawing.Point(64, 28);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(80, 13);
            this.lblEntrega.TabIndex = 5;
            this.lblEntrega.Text = "Definir Entrega:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(372, 28);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 7;
            this.lblProducto.Text = "Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(681, 28);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(659, 50);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(13, 13);
            this.lblMoneda.TabIndex = 10;
            this.lblMoneda.Text = "$";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(582, 28);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(6, 44);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEntrega.TabIndex = 0;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(246, 47);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(313, 20);
            this.txtProducto.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(581, 47);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(53, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(678, 47);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(43, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // FrmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblOrdendePedido);
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.grpMaestro);
            this.Name = "FrmOrden";
            this.Text = "FrmOrden";
            this.Load += new System.EventHandler(this.FrmOrden_Load);
            this.grpMaestro.ResumeLayout(false);
            this.grpMaestro.PerformLayout();
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaestro;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.Label lblOrdendePedido;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtEspecificaciones;
        private System.Windows.Forms.Label lblEspecificaciones;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}