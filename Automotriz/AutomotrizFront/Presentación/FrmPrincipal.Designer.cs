namespace AutomotrizFront
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            reporteToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem1 = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            transacciónToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            nuevaToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem2 = new ToolStripMenuItem();
            reporteToolStripMenuItem1 = new ToolStripMenuItem();
            autoplanesPopularesToolStripMenuItem = new ToolStripMenuItem();
            marcasPopularesToolStripMenuItem = new ToolStripMenuItem();
            consultarTotalToolStripMenuItem = new ToolStripMenuItem();
            piezasToolStripMenuItem = new ToolStripMenuItem();
            mejoresClientesToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            nosotrosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, reporteToolStripMenuItem, transacciónToolStripMenuItem, reporteToolStripMenuItem1, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(934, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // reporteToolStripMenuItem
            // 
            reporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, productoToolStripMenuItem });
            reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            reporteToolStripMenuItem.Size = new Size(60, 20);
            reporteToolStripMenuItem.Text = "Soporte";
            reporteToolStripMenuItem.Click += reporteToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, consultarToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(123, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(125, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(125, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem1, consultarToolStripMenuItem1 });
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(123, 22);
            productoToolStripMenuItem.Text = "Producto";
            // 
            // nuevoToolStripMenuItem1
            // 
            nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            nuevoToolStripMenuItem1.Size = new Size(125, 22);
            nuevoToolStripMenuItem1.Text = "Nuevo";
            nuevoToolStripMenuItem1.Click += nuevoToolStripMenuItem1_Click;
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(125, 22);
            consultarToolStripMenuItem1.Text = "Consultar";
            consultarToolStripMenuItem1.Click += consultarToolStripMenuItem1_Click;
            // 
            // transacciónToolStripMenuItem
            // 
            transacciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturaToolStripMenuItem });
            transacciónToolStripMenuItem.Name = "transacciónToolStripMenuItem";
            transacciónToolStripMenuItem.Size = new Size(81, 20);
            transacciónToolStripMenuItem.Text = "Transacción";
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem, consultarToolStripMenuItem2 });
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(113, 22);
            facturaToolStripMenuItem.Text = "Factura";
            facturaToolStripMenuItem.Click += facturaToolStripMenuItem_Click;
            // 
            // nuevaToolStripMenuItem
            // 
            nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            nuevaToolStripMenuItem.Size = new Size(125, 22);
            nuevaToolStripMenuItem.Text = "Nueva";
            nuevaToolStripMenuItem.Click += nuevaToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem2
            // 
            consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            consultarToolStripMenuItem2.Size = new Size(125, 22);
            consultarToolStripMenuItem2.Text = "Consultar";
            consultarToolStripMenuItem2.Click += consultarToolStripMenuItem2_Click;
            // 
            // reporteToolStripMenuItem1
            // 
            reporteToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { autoplanesPopularesToolStripMenuItem, marcasPopularesToolStripMenuItem, consultarTotalToolStripMenuItem, piezasToolStripMenuItem, mejoresClientesToolStripMenuItem });
            reporteToolStripMenuItem1.Name = "reporteToolStripMenuItem1";
            reporteToolStripMenuItem1.Size = new Size(60, 20);
            reporteToolStripMenuItem1.Text = "Reporte";
            // 
            // autoplanesPopularesToolStripMenuItem
            // 
            autoplanesPopularesToolStripMenuItem.Name = "autoplanesPopularesToolStripMenuItem";
            autoplanesPopularesToolStripMenuItem.Size = new Size(189, 22);
            autoplanesPopularesToolStripMenuItem.Text = "Autoplanes Populares";
            autoplanesPopularesToolStripMenuItem.Click += autoplanesPopularesToolStripMenuItem_Click;
            // 
            // marcasPopularesToolStripMenuItem
            // 
            marcasPopularesToolStripMenuItem.Name = "marcasPopularesToolStripMenuItem";
            marcasPopularesToolStripMenuItem.Size = new Size(189, 22);
            marcasPopularesToolStripMenuItem.Text = "Marcas Populares";
            marcasPopularesToolStripMenuItem.Click += marcasPopularesToolStripMenuItem_Click;
            // 
            // consultarTotalToolStripMenuItem
            // 
            consultarTotalToolStripMenuItem.Name = "consultarTotalToolStripMenuItem";
            consultarTotalToolStripMenuItem.Size = new Size(189, 22);
            consultarTotalToolStripMenuItem.Text = "Consultar Total";
            consultarTotalToolStripMenuItem.Click += consultarTotalToolStripMenuItem_Click;
            // 
            // piezasToolStripMenuItem
            // 
            piezasToolStripMenuItem.Name = "piezasToolStripMenuItem";
            piezasToolStripMenuItem.Size = new Size(189, 22);
            piezasToolStripMenuItem.Text = "Piezas";
            piezasToolStripMenuItem.Click += piezasToolStripMenuItem_Click;
            // 
            // mejoresClientesToolStripMenuItem
            // 
            mejoresClientesToolStripMenuItem.Name = "mejoresClientesToolStripMenuItem";
            mejoresClientesToolStripMenuItem.Size = new Size(189, 22);
            mejoresClientesToolStripMenuItem.Text = "Mejores Clientes";
            mejoresClientesToolStripMenuItem.Click += mejoresClientesToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nosotrosToolStripMenuItem });
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(71, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // nosotrosToolStripMenuItem
            // 
            nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            nosotrosToolStripMenuItem.Size = new Size(122, 22);
            nosotrosToolStripMenuItem.Text = "Nosotros";
            nosotrosToolStripMenuItem.Click += nosotrosToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(934, 519);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Automotriz App";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem reporteToolStripMenuItem;
        private ToolStripMenuItem transacciónToolStripMenuItem;
        private ToolStripMenuItem reporteToolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem1;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem nosotrosToolStripMenuItem;
        private ToolStripMenuItem nuevaToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem2;
        private ToolStripMenuItem autoplanesPopularesToolStripMenuItem;
        private ToolStripMenuItem marcasPopularesToolStripMenuItem;
        private ToolStripMenuItem consultarTotalToolStripMenuItem;
        private ToolStripMenuItem piezasToolStripMenuItem;
        private ToolStripMenuItem mejoresClientesToolStripMenuItem;
    }
}

