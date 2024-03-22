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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
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
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // grupoDeDescuentosToolStripMenuItem
            // 
            this.grupoDeDescuentosToolStripMenuItem.Name = "grupoDeDescuentosToolStripMenuItem";
            this.grupoDeDescuentosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.grupoDeDescuentosToolStripMenuItem.Text = "Ver clientes";
            // 
            // condiciónDePagosToolStripMenuItem
            // 
            this.condiciónDePagosToolStripMenuItem.Name = "condiciónDePagosToolStripMenuItem";
            this.condiciónDePagosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.condiciónDePagosToolStripMenuItem.Text = "Grupo de descuentos";
            this.condiciónDePagosToolStripMenuItem.Click += new System.EventHandler(this.condiciónDePagosToolStripMenuItem_Click);
            // 
            // condiciónDePagosToolStripMenuItem1
            // 
            this.condiciónDePagosToolStripMenuItem1.Name = "condiciónDePagosToolStripMenuItem1";
            this.condiciónDePagosToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
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
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Ver productos";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // unidadDeMedidaToolStripMenuItem
            // 
            this.unidadDeMedidaToolStripMenuItem.Name = "unidadDeMedidaToolStripMenuItem";
            this.unidadDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unidadDeMedidaToolStripMenuItem.Text = "Categoria";
            this.unidadDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadDeMedidaToolStripMenuItem_Click);
            // 
            // unidadDeMedidaToolStripMenuItem1
            // 
            this.unidadDeMedidaToolStripMenuItem1.Name = "unidadDeMedidaToolStripMenuItem1";
            this.unidadDeMedidaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.unidadDeMedidaToolStripMenuItem1.Text = "Unidad de medida";
            this.unidadDeMedidaToolStripMenuItem1.Click += new System.EventHandler(this.unidadDeMedidaToolStripMenuItem1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}

