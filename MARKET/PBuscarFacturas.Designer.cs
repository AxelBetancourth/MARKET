namespace MARKET
{
    partial class PBuscarFacturas
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
            this.dgbuscarFactura = new System.Windows.Forms.DataGridView();
            this.checkBfacturas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbuscarFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbuscarFactura
            // 
            this.dgbuscarFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbuscarFactura.Location = new System.Drawing.Point(15, 132);
            this.dgbuscarFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgbuscarFactura.Name = "dgbuscarFactura";
            this.dgbuscarFactura.RowHeadersWidth = 51;
            this.dgbuscarFactura.Size = new System.Drawing.Size(790, 636);
            this.dgbuscarFactura.TabIndex = 4;
            this.dgbuscarFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbuscarFactura_CellContentClick);
            this.dgbuscarFactura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbuscarFactura_CellDoubleClick);
            // 
            // checkBfacturas
            // 
            this.checkBfacturas.AutoSize = true;
            this.checkBfacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBfacturas.Location = new System.Drawing.Point(15, 96);
            this.checkBfacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBfacturas.Name = "checkBfacturas";
            this.checkBfacturas.Size = new System.Drawing.Size(201, 26);
            this.checkBfacturas.TabIndex = 6;
            this.checkBfacturas.Text = "Filtrar solo activos";
            this.checkBfacturas.UseVisualStyleBackColor = true;
            this.checkBfacturas.CheckedChanged += new System.EventHandler(this.checkBfacturas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "Todas las Facturas";
            // 
            // PBuscarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 792);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBfacturas);
            this.Controls.Add(this.dgbuscarFactura);
            this.Name = "PBuscarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBuscarFacturacs";
            this.Load += new System.EventHandler(this.PBuscarFacturacs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbuscarFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbuscarFactura;
        private System.Windows.Forms.CheckBox checkBfacturas;
        private System.Windows.Forms.Label label4;
    }
}