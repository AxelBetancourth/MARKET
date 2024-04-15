namespace MARKET
{
    partial class PPedidoDetalles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPedidoDetalles));
            this.txtproductoid = new System.Windows.Forms.TextBox();
            this.txtpedidoid = new System.Windows.Forms.TextBox();
            this.DgDetallesPedido = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDetallePedidoId = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtotal = new System.Windows.Forms.TextBox();
            this.txtsubt = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.buscarpdido = new System.Windows.Forms.Button();
            this.bbuscarproducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetallesPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtproductoid
            // 
            this.txtproductoid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtproductoid.Location = new System.Drawing.Point(1018, 20);
            this.txtproductoid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtproductoid.Name = "txtproductoid";
            this.txtproductoid.ReadOnly = true;
            this.txtproductoid.Size = new System.Drawing.Size(61, 26);
            this.txtproductoid.TabIndex = 61;
            this.txtproductoid.Visible = false;
            // 
            // txtpedidoid
            // 
            this.txtpedidoid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpedidoid.Location = new System.Drawing.Point(1118, 20);
            this.txtpedidoid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpedidoid.Name = "txtpedidoid";
            this.txtpedidoid.ReadOnly = true;
            this.txtpedidoid.Size = new System.Drawing.Size(66, 26);
            this.txtpedidoid.TabIndex = 60;
            this.txtpedidoid.Visible = false;
            // 
            // DgDetallesPedido
            // 
            this.DgDetallesPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgDetallesPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgDetallesPedido.BackgroundColor = System.Drawing.Color.White;
            this.DgDetallesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDetallesPedido.Location = new System.Drawing.Point(20, 297);
            this.DgDetallesPedido.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgDetallesPedido.Name = "DgDetallesPedido";
            this.DgDetallesPedido.RowHeadersWidth = 51;
            this.DgDetallesPedido.Size = new System.Drawing.Size(1178, 375);
            this.DgDetallesPedido.TabIndex = 57;
            this.DgDetallesPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDetallesPedido_CellDoubleClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminar.BackColor = System.Drawing.Color.Red;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = global::MARKET.Properties.Resources.eliminar;
            this.btneliminar.Location = new System.Drawing.Point(612, 229);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(182, 50);
            this.btneliminar.TabIndex = 56;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(17)))));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = global::MARKET.Properties.Resources.Guardar;
            this.btnguardar.Location = new System.Drawing.Point(420, 229);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(182, 50);
            this.btnguardar.TabIndex = 55;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "Gestion de Detalles de Pedido";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Detalle Pedido Id\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Busque el Pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Busque el Producto";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(880, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(880, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 47;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(880, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 48;
            this.label8.Text = "SubTotal";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(880, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 49;
            this.label9.Text = "Descuento";
            // 
            // txtDetallePedidoId
            // 
            this.txtDetallePedidoId.Enabled = false;
            this.txtDetallePedidoId.Location = new System.Drawing.Point(230, 86);
            this.txtDetallePedidoId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDetallePedidoId.Name = "txtDetallePedidoId";
            this.txtDetallePedidoId.ReadOnly = true;
            this.txtDetallePedidoId.Size = new System.Drawing.Size(192, 26);
            this.txtDetallePedidoId.TabIndex = 50;
            // 
            // txtprecio
            // 
            this.txtprecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtprecio.Enabled = false;
            this.txtprecio.Location = new System.Drawing.Point(1018, 80);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(166, 26);
            this.txtprecio.TabIndex = 51;
            // 
            // txtotal
            // 
            this.txtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtotal.Enabled = false;
            this.txtotal.Location = new System.Drawing.Point(1018, 194);
            this.txtotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtotal.Name = "txtotal";
            this.txtotal.ReadOnly = true;
            this.txtotal.Size = new System.Drawing.Size(166, 26);
            this.txtotal.TabIndex = 52;
            // 
            // txtsubt
            // 
            this.txtsubt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsubt.Enabled = false;
            this.txtsubt.Location = new System.Drawing.Point(1018, 118);
            this.txtsubt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsubt.Name = "txtsubt";
            this.txtsubt.ReadOnly = true;
            this.txtsubt.Size = new System.Drawing.Size(166, 26);
            this.txtsubt.TabIndex = 53;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(1018, 156);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(166, 26);
            this.txtDescuento.TabIndex = 54;
            // 
            // buscarpdido
            // 
            this.buscarpdido.Image = global::MARKET.Properties.Resources.lupa;
            this.buscarpdido.Location = new System.Drawing.Point(230, 167);
            this.buscarpdido.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buscarpdido.Name = "buscarpdido";
            this.buscarpdido.Size = new System.Drawing.Size(195, 34);
            this.buscarpdido.TabIndex = 58;
            this.buscarpdido.Text = "Buscar";
            this.buscarpdido.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buscarpdido.UseVisualStyleBackColor = true;
            this.buscarpdido.Click += new System.EventHandler(this.buscarpdido_Click);
            // 
            // bbuscarproducto
            // 
            this.bbuscarproducto.Image = global::MARKET.Properties.Resources.lupa;
            this.bbuscarproducto.Location = new System.Drawing.Point(230, 127);
            this.bbuscarproducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bbuscarproducto.Name = "bbuscarproducto";
            this.bbuscarproducto.Size = new System.Drawing.Size(195, 34);
            this.bbuscarproducto.TabIndex = 59;
            this.bbuscarproducto.Text = "Buscar";
            this.bbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bbuscarproducto.UseVisualStyleBackColor = true;
            this.bbuscarproducto.Click += new System.EventHandler(this.bbuscarproducto_Click);
            // 
            // PPedidoDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 685);
            this.Controls.Add(this.txtproductoid);
            this.Controls.Add(this.txtpedidoid);
            this.Controls.Add(this.bbuscarproducto);
            this.Controls.Add(this.buscarpdido);
            this.Controls.Add(this.DgDetallesPedido);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtsubt);
            this.Controls.Add(this.txtotal);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtDetallePedidoId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(1109, 100);
            this.Name = "PPedidoDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Pedidos";
            this.Load += new System.EventHandler(this.PPedidoDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgDetallesPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtproductoid;
        private System.Windows.Forms.TextBox txtpedidoid;
        private System.Windows.Forms.DataGridView DgDetallesPedido;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bbuscarproducto;
        private System.Windows.Forms.Button buscarpdido;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtsubt;
        private System.Windows.Forms.TextBox txtotal;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtDetallePedidoId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}