namespace MARKET
{
    partial class PFacturaDetalle
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalleFacturaId = new System.Windows.Forms.TextBox();
            this.bbuscarproduc = new System.Windows.Forms.Button();
            this.bbuscarfactu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DgDetalleFactura = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPrecios = new System.Windows.Forms.TextBox();
            this.txtFacturaaId = new System.Windows.Forms.TextBox();
            this.txtProductooId = new System.Windows.Forms.TextBox();
            this.txtSubto = new System.Windows.Forms.TextBox();
            this.txtDescuentoo = new System.Windows.Forms.TextBox();
            this.txtTotaal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 26);
            this.label4.TabIndex = 38;
            this.label4.Text = "Gestion de Detalles de Facturas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Factura Detalle Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Busque Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Busque Producto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDetalleFacturaId
            // 
            this.txtDetalleFacturaId.Location = new System.Drawing.Point(248, 97);
            this.txtDetalleFacturaId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDetalleFacturaId.Name = "txtDetalleFacturaId";
            this.txtDetalleFacturaId.ReadOnly = true;
            this.txtDetalleFacturaId.Size = new System.Drawing.Size(174, 26);
            this.txtDetalleFacturaId.TabIndex = 51;
            // 
            // bbuscarproduc
            // 
            this.bbuscarproduc.Location = new System.Drawing.Point(248, 151);
            this.bbuscarproduc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bbuscarproduc.Name = "bbuscarproduc";
            this.bbuscarproduc.Size = new System.Drawing.Size(176, 35);
            this.bbuscarproduc.TabIndex = 60;
            this.bbuscarproduc.Text = "Buscar";
            this.bbuscarproduc.UseVisualStyleBackColor = true;
            this.bbuscarproduc.Click += new System.EventHandler(this.bbuscarproducto_Click);
            // 
            // bbuscarfactu
            // 
            this.bbuscarfactu.Location = new System.Drawing.Point(248, 209);
            this.bbuscarfactu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bbuscarfactu.Name = "bbuscarfactu";
            this.bbuscarfactu.Size = new System.Drawing.Size(176, 35);
            this.bbuscarfactu.TabIndex = 61;
            this.bbuscarfactu.Text = "Buscar";
            this.bbuscarfactu.UseVisualStyleBackColor = true;
            this.bbuscarfactu.Click += new System.EventHandler(this.bbuscarfactu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(699, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 62;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(675, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 63;
            this.label6.Text = "SubTotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(661, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 64;
            this.label7.Text = "Descuento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(710, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 65;
            this.label8.Text = "Total";
            // 
            // DgDetalleFactura
            // 
            this.DgDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDetalleFactura.Location = new System.Drawing.Point(12, 371);
            this.DgDetalleFactura.Name = "DgDetalleFactura";
            this.DgDetalleFactura.RowHeadersWidth = 62;
            this.DgDetalleFactura.RowTemplate.Height = 28;
            this.DgDetalleFactura.Size = new System.Drawing.Size(1092, 309);
            this.DgDetalleFactura.TabIndex = 70;
            this.DgDetalleFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDetalleFactura_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(660, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 22);
            this.label9.TabIndex = 71;
            this.label9.Text = "Nº Factura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(850, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 72;
            this.label10.Text = "Nº Producto";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(112, 311);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(141, 35);
            this.btnguardar.TabIndex = 75;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(315, 311);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(141, 35);
            this.btneliminar.TabIndex = 76;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtPrecios
            // 
            this.txtPrecios.Location = new System.Drawing.Point(774, 137);
            this.txtPrecios.Name = "txtPrecios";
            this.txtPrecios.ReadOnly = true;
            this.txtPrecios.Size = new System.Drawing.Size(172, 26);
            this.txtPrecios.TabIndex = 77;
            // 
            // txtFacturaaId
            // 
            this.txtFacturaaId.Location = new System.Drawing.Point(774, 87);
            this.txtFacturaaId.Name = "txtFacturaaId";
            this.txtFacturaaId.ReadOnly = true;
            this.txtFacturaaId.Size = new System.Drawing.Size(63, 26);
            this.txtFacturaaId.TabIndex = 78;
            // 
            // txtProductooId
            // 
            this.txtProductooId.Location = new System.Drawing.Point(974, 87);
            this.txtProductooId.Name = "txtProductooId";
            this.txtProductooId.ReadOnly = true;
            this.txtProductooId.Size = new System.Drawing.Size(63, 26);
            this.txtProductooId.TabIndex = 79;
            // 
            // txtSubto
            // 
            this.txtSubto.Location = new System.Drawing.Point(774, 183);
            this.txtSubto.Name = "txtSubto";
            this.txtSubto.ReadOnly = true;
            this.txtSubto.Size = new System.Drawing.Size(172, 26);
            this.txtSubto.TabIndex = 80;
            // 
            // txtDescuentoo
            // 
            this.txtDescuentoo.Location = new System.Drawing.Point(774, 229);
            this.txtDescuentoo.Name = "txtDescuentoo";
            this.txtDescuentoo.ReadOnly = true;
            this.txtDescuentoo.Size = new System.Drawing.Size(172, 26);
            this.txtDescuentoo.TabIndex = 81;
            // 
            // txtTotaal
            // 
            this.txtTotaal.Location = new System.Drawing.Point(774, 276);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.ReadOnly = true;
            this.txtTotaal.Size = new System.Drawing.Size(172, 26);
            this.txtTotaal.TabIndex = 82;
            // 
            // PFacturaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 692);
            this.Controls.Add(this.txtTotaal);
            this.Controls.Add(this.txtDescuentoo);
            this.Controls.Add(this.txtSubto);
            this.Controls.Add(this.txtProductooId);
            this.Controls.Add(this.txtFacturaaId);
            this.Controls.Add(this.txtPrecios);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DgDetalleFactura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bbuscarfactu);
            this.Controls.Add(this.bbuscarproduc);
            this.Controls.Add(this.txtDetalleFacturaId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "PFacturaDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PFacturaDetalle";
            this.Load += new System.EventHandler(this.PFacturaDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalleFacturaId;
        private System.Windows.Forms.Button bbuscarproduc;
        private System.Windows.Forms.Button bbuscarfactu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DgDetalleFactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtProductooId;
        private System.Windows.Forms.TextBox txtFacturaaId;
        private System.Windows.Forms.TextBox txtPrecios;
        private System.Windows.Forms.TextBox txtTotaal;
        private System.Windows.Forms.TextBox txtDescuentoo;
        private System.Windows.Forms.TextBox txtSubto;
    }
}