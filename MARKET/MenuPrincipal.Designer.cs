namespace MARKET
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoDeDescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condiciónDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condiciónDePagosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadDeMedidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.facturasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grupoDeDescuentosToolStripMenuItem,
            this.condiciónDePagosToolStripMenuItem,
            this.condiciónDePagosToolStripMenuItem1});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // grupoDeDescuentosToolStripMenuItem
            // 
            this.grupoDeDescuentosToolStripMenuItem.Name = "grupoDeDescuentosToolStripMenuItem";
            this.grupoDeDescuentosToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.grupoDeDescuentosToolStripMenuItem.Text = "Agregar";
            this.grupoDeDescuentosToolStripMenuItem.Click += new System.EventHandler(this.grupoDeDescuentosToolStripMenuItem_Click_1);
            // 
            // condiciónDePagosToolStripMenuItem
            // 
            this.condiciónDePagosToolStripMenuItem.Name = "condiciónDePagosToolStripMenuItem";
            this.condiciónDePagosToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.condiciónDePagosToolStripMenuItem.Text = "Grupo de descuentos";
            this.condiciónDePagosToolStripMenuItem.Click += new System.EventHandler(this.condiciónDePagosToolStripMenuItem_Click);
            // 
            // condiciónDePagosToolStripMenuItem1
            // 
            this.condiciónDePagosToolStripMenuItem1.Name = "condiciónDePagosToolStripMenuItem1";
            this.condiciónDePagosToolStripMenuItem1.Size = new System.Drawing.Size(284, 34);
            this.condiciónDePagosToolStripMenuItem1.Text = "Condición de pagos";
            this.condiciónDePagosToolStripMenuItem1.Click += new System.EventHandler(this.condiciónDePagosToolStripMenuItem1_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.unidadDeMedidaToolStripMenuItem,
            this.unidadDeMedidaToolStripMenuItem1});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.categoriaToolStripMenuItem.Text = "Agregar";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // unidadDeMedidaToolStripMenuItem
            // 
            this.unidadDeMedidaToolStripMenuItem.Name = "unidadDeMedidaToolStripMenuItem";
            this.unidadDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.unidadDeMedidaToolStripMenuItem.Text = "Categoria";
            this.unidadDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadDeMedidaToolStripMenuItem_Click);
            // 
            // unidadDeMedidaToolStripMenuItem1
            // 
            this.unidadDeMedidaToolStripMenuItem1.Name = "unidadDeMedidaToolStripMenuItem1";
            this.unidadDeMedidaToolStripMenuItem1.Size = new System.Drawing.Size(261, 34);
            this.unidadDeMedidaToolStripMenuItem1.Text = "Unidad de medida";
            this.unidadDeMedidaToolStripMenuItem1.Click += new System.EventHandler(this.unidadDeMedidaToolStripMenuItem1_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPedidosToolStripMenuItem,
            this.detalleDePedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.verPedidosToolStripMenuItem.Text = "Agregar";
            this.verPedidosToolStripMenuItem.Click += new System.EventHandler(this.verPedidosToolStripMenuItem_Click);
            // 
            // detalleDePedidosToolStripMenuItem
            // 
            this.detalleDePedidosToolStripMenuItem.Name = "detalleDePedidosToolStripMenuItem";
            this.detalleDePedidosToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.detalleDePedidosToolStripMenuItem.Text = "Detalles";
            this.detalleDePedidosToolStripMenuItem.Click += new System.EventHandler(this.detalleDePedidosToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFacturasToolStripMenuItem,
            this.detalleDeFacturasToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // verFacturasToolStripMenuItem
            // 
            this.verFacturasToolStripMenuItem.Name = "verFacturasToolStripMenuItem";
            this.verFacturasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verFacturasToolStripMenuItem.Text = "Agregar";
            this.verFacturasToolStripMenuItem.Click += new System.EventHandler(this.verFacturasToolStripMenuItem_Click);
            // 
            // detalleDeFacturasToolStripMenuItem
            // 
            this.detalleDeFacturasToolStripMenuItem.Name = "detalleDeFacturasToolStripMenuItem";
            this.detalleDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.detalleDeFacturasToolStripMenuItem.Text = "Detalles";
            this.detalleDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.detalleDeFacturasToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoDeDescuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condiciónDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condiciónDePagosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unidadDeMedidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDeFacturasToolStripMenuItem;
    }
}

