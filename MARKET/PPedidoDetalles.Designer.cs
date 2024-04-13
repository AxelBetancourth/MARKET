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
            this.txtproductoid.Location = new System.Drawing.Point(815, 17);
            this.txtproductoid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtproductoid.Name = "txtproductoid";
            this.txtproductoid.ReadOnly = true;
            this.txtproductoid.Size = new System.Drawing.Size(49, 22);
            this.txtproductoid.TabIndex = 61;
            this.txtproductoid.Visible = false;
            // 
            // txtpedidoid
            // 
            this.txtpedidoid.Location = new System.Drawing.Point(895, 17);
            this.txtpedidoid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpedidoid.Name = "txtpedidoid";
            this.txtpedidoid.ReadOnly = true;
            this.txtpedidoid.Size = new System.Drawing.Size(53, 22);
            this.txtpedidoid.TabIndex = 60;
            this.txtpedidoid.Visible = false;
            // 
            // DgDetallesPedido
            // 
            this.DgDetallesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDetallesPedido.Location = new System.Drawing.Point(16, 250);
            this.DgDetallesPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgDetallesPedido.Name = "DgDetallesPedido";
            this.DgDetallesPedido.RowHeadersWidth = 51;
            this.DgDetallesPedido.Size = new System.Drawing.Size(933, 289);
            this.DgDetallesPedido.TabIndex = 57;
            this.DgDetallesPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDetallesPedido_CellDoubleClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(521, 196);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(125, 28);
            this.btneliminar.TabIndex = 56;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(361, 196);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(125, 28);
            this.btnguardar.TabIndex = 55;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 29);
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
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Detalle Pedido Id\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Busque el Pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Busque el Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(704, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(704, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "SubTotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(704, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Descuento";
            // 
            // txtDetallePedidoId
            // 
            this.txtDetallePedidoId.Enabled = false;
            this.txtDetallePedidoId.Location = new System.Drawing.Point(184, 73);
            this.txtDetallePedidoId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetallePedidoId.Name = "txtDetallePedidoId";
            this.txtDetallePedidoId.ReadOnly = true;
            this.txtDetallePedidoId.Size = new System.Drawing.Size(155, 22);
            this.txtDetallePedidoId.TabIndex = 50;
            // 
            // txtprecio
            // 
            this.txtprecio.Enabled = false;
            this.txtprecio.Location = new System.Drawing.Point(815, 68);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(133, 22);
            this.txtprecio.TabIndex = 51;
            // 
            // txtotal
            // 
            this.txtotal.Enabled = false;
            this.txtotal.Location = new System.Drawing.Point(815, 164);
            this.txtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtotal.Name = "txtotal";
            this.txtotal.ReadOnly = true;
            this.txtotal.Size = new System.Drawing.Size(133, 22);
            this.txtotal.TabIndex = 52;
            // 
            // txtsubt
            // 
            this.txtsubt.Enabled = false;
            this.txtsubt.Location = new System.Drawing.Point(815, 100);
            this.txtsubt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubt.Name = "txtsubt";
            this.txtsubt.ReadOnly = true;
            this.txtsubt.Size = new System.Drawing.Size(133, 22);
            this.txtsubt.TabIndex = 53;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(815, 132);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(133, 22);
            this.txtDescuento.TabIndex = 54;
            // 
            // buscarpdido
            // 
            this.buscarpdido.Location = new System.Drawing.Point(184, 140);
            this.buscarpdido.Margin = new System.Windows.Forms.Padding(4);
            this.buscarpdido.Name = "buscarpdido";
            this.buscarpdido.Size = new System.Drawing.Size(156, 28);
            this.buscarpdido.TabIndex = 58;
            this.buscarpdido.Text = "Buscar";
            this.buscarpdido.UseVisualStyleBackColor = true;
            this.buscarpdido.Click += new System.EventHandler(this.buscarpdido_Click);
            // 
            // bbuscarproducto
            // 
            this.bbuscarproducto.Location = new System.Drawing.Point(184, 107);
            this.bbuscarproducto.Margin = new System.Windows.Forms.Padding(4);
            this.bbuscarproducto.Name = "bbuscarproducto";
            this.bbuscarproducto.Size = new System.Drawing.Size(156, 28);
            this.bbuscarproducto.TabIndex = 59;
            this.bbuscarproducto.Text = "Buscar";
            this.bbuscarproducto.UseVisualStyleBackColor = true;
            this.bbuscarproducto.Click += new System.EventHandler(this.bbuscarproducto_Click);
            // 
            // PPedidoDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PPedidoDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPedidoDetalles";
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