namespace MARKET
{
    partial class PFacturas
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
            this.cbxclientes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgFacturas = new System.Windows.Forms.DataGridView();
            this.txtFacturaId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechafactura = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bbuscarpedido = new System.Windows.Forms.Button();
            this.txtpedidoid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxclientes
            // 
            this.cbxclientes.FormattingEnabled = true;
            this.cbxclientes.Location = new System.Drawing.Point(186, 116);
            this.cbxclientes.Margin = new System.Windows.Forms.Padding(4);
            this.cbxclientes.Name = "cbxclientes";
            this.cbxclientes.Size = new System.Drawing.Size(286, 24);
            this.cbxclientes.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(491, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 49;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(919, 215);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(142, 22);
            this.txttotal.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(797, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Total";
            // 
            // cbActivos
            // 
            this.cbActivos.AutoSize = true;
            this.cbActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivos.Location = new System.Drawing.Point(16, 295);
            this.cbActivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Size = new System.Drawing.Size(185, 22);
            this.cbActivos.TabIndex = 44;
            this.cbActivos.Text = "Mostrar solo activas";
            this.cbActivos.UseVisualStyleBackColor = true;
            this.cbActivos.CheckedChanged += new System.EventHandler(this.cbActivos_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(584, 285);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 32);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(413, 285);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 32);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgFacturas
            // 
            this.dgFacturas.AllowUserToAddRows = false;
            this.dgFacturas.AllowUserToDeleteRows = false;
            this.dgFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturas.Location = new System.Drawing.Point(16, 323);
            this.dgFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.ReadOnly = true;
            this.dgFacturas.RowHeadersWidth = 62;
            this.dgFacturas.RowTemplate.Height = 28;
            this.dgFacturas.Size = new System.Drawing.Size(1045, 271);
            this.dgFacturas.TabIndex = 41;
            this.dgFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturas_CellDoubleClick);
            // 
            // txtFacturaId
            // 
            this.txtFacturaId.Location = new System.Drawing.Point(186, 69);
            this.txtFacturaId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFacturaId.Name = "txtFacturaId";
            this.txtFacturaId.ReadOnly = true;
            this.txtFacturaId.Size = new System.Drawing.Size(89, 22);
            this.txtFacturaId.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Facturas";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.Location = new System.Drawing.Point(985, 69);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(76, 22);
            this.cbEstado.TabIndex = 36;
            this.cbEstado.Text = "Activo";
            this.cbEstado.UseVisualStyleBackColor = true;
            this.cbEstado.CheckedChanged += new System.EventHandler(this.cbEstado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "FacturaId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Pedido";
            // 
            // fechafactura
            // 
            this.fechafactura.Location = new System.Drawing.Point(186, 213);
            this.fechafactura.Name = "fechafactura";
            this.fechafactura.Size = new System.Drawing.Size(286, 22);
            this.fechafactura.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Fecha de factura";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(919, 112);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(142, 22);
            this.txtsubtotal.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(797, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 56;
            this.label7.Text = "Subtotal";
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(919, 164);
            this.txtdescuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.ReadOnly = true;
            this.txtdescuento.Size = new System.Drawing.Size(142, 22);
            this.txtdescuento.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(797, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 58;
            this.label8.Text = "Descuento";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bbuscarpedido
            // 
            this.bbuscarpedido.Location = new System.Drawing.Point(186, 158);
            this.bbuscarpedido.Margin = new System.Windows.Forms.Padding(4);
            this.bbuscarpedido.Name = "bbuscarpedido";
            this.bbuscarpedido.Size = new System.Drawing.Size(155, 28);
            this.bbuscarpedido.TabIndex = 60;
            this.bbuscarpedido.Text = "Buscar";
            this.bbuscarpedido.UseVisualStyleBackColor = true;
            this.bbuscarpedido.Click += new System.EventHandler(this.bbuscarpedido_Click);
            // 
            // txtpedidoid
            // 
            this.txtpedidoid.Location = new System.Drawing.Point(800, 21);
            this.txtpedidoid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpedidoid.Name = "txtpedidoid";
            this.txtpedidoid.ReadOnly = true;
            this.txtpedidoid.Size = new System.Drawing.Size(45, 22);
            this.txtpedidoid.TabIndex = 61;
            this.txtpedidoid.Visible = false;
            // 
            // PFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 609);
            this.Controls.Add(this.txtpedidoid);
            this.Controls.Add(this.bbuscarpedido);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechafactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxclientes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbActivos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgFacturas);
            this.Controls.Add(this.txtFacturaId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label1);
            this.Name = "PFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PFacturas";
            this.Load += new System.EventHandler(this.PFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxclientes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbActivos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgFacturas;
        private System.Windows.Forms.TextBox txtFacturaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechafactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bbuscarpedido;
        private System.Windows.Forms.TextBox txtpedidoid;
    }
}