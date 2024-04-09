namespace MARKET
{
    partial class PBuscarProducto
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
            this.checkBprod = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgbuscarProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbuscarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBprod
            // 
            this.checkBprod.AutoSize = true;
            this.checkBprod.Location = new System.Drawing.Point(42, 26);
            this.checkBprod.Name = "checkBprod";
            this.checkBprod.Size = new System.Drawing.Size(110, 17);
            this.checkBprod.TabIndex = 7;
            this.checkBprod.Text = "Filtrar solo activos";
            this.checkBprod.UseVisualStyleBackColor = true;
            this.checkBprod.CheckedChanged += new System.EventHandler(this.checkBprod_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione el Producto que Necesita";
            // 
            // dgbuscarProducto
            // 
            this.dgbuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbuscarProducto.Location = new System.Drawing.Point(33, 49);
            this.dgbuscarProducto.Name = "dgbuscarProducto";
            this.dgbuscarProducto.Size = new System.Drawing.Size(387, 150);
            this.dgbuscarProducto.TabIndex = 5;
            this.dgbuscarProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbuscarProducto_CellClick_1);
            // 
            // PBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.checkBprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgbuscarProducto);
            this.Name = "PBuscarProducto";
            this.Text = "PBuscarProducto";
            this.Load += new System.EventHandler(this.PBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbuscarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgbuscarProducto;
    }
}