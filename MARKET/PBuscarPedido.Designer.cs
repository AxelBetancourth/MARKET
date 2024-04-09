namespace MARKET
{
    partial class PBuscarPedido
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
            this.checkBpedidos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgbuscarPedido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbuscarPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBpedidos
            // 
            this.checkBpedidos.AutoSize = true;
            this.checkBpedidos.Location = new System.Drawing.Point(48, 35);
            this.checkBpedidos.Name = "checkBpedidos";
            this.checkBpedidos.Size = new System.Drawing.Size(110, 17);
            this.checkBpedidos.TabIndex = 5;
            this.checkBpedidos.Text = "Filtrar solo activos";
            this.checkBpedidos.UseVisualStyleBackColor = true;
            this.checkBpedidos.CheckedChanged += new System.EventHandler(this.checkBpedidos_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el Pedido que Necesita";
            // 
            // dgbuscarPedido
            // 
            this.dgbuscarPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbuscarPedido.Location = new System.Drawing.Point(48, 58);
            this.dgbuscarPedido.Name = "dgbuscarPedido";
            this.dgbuscarPedido.Size = new System.Drawing.Size(347, 150);
            this.dgbuscarPedido.TabIndex = 3;
            this.dgbuscarPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbuscarPedido_CellClick_1);
            // 
            // PBuscarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.checkBpedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgbuscarPedido);
            this.Name = "PBuscarPedido";
            this.Text = "PBuscarPedido";
            this.Load += new System.EventHandler(this.PBuscarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbuscarPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBpedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgbuscarPedido;
    }
}