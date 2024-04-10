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
            this.checkBpedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBpedidos.Location = new System.Drawing.Point(13, 74);
            this.checkBpedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBpedidos.Name = "checkBpedidos";
            this.checkBpedidos.Size = new System.Drawing.Size(151, 22);
            this.checkBpedidos.TabIndex = 5;
            this.checkBpedidos.Text = "Filtrar solo activos";
            this.checkBpedidos.UseVisualStyleBackColor = true;
            this.checkBpedidos.CheckedChanged += new System.EventHandler(this.checkBpedidos_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el Pedido que Necesita";
            // 
            // dgbuscarPedido
            // 
            this.dgbuscarPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbuscarPedido.Location = new System.Drawing.Point(13, 104);
            this.dgbuscarPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgbuscarPedido.Name = "dgbuscarPedido";
            this.dgbuscarPedido.RowHeadersWidth = 51;
            this.dgbuscarPedido.Size = new System.Drawing.Size(702, 517);
            this.dgbuscarPedido.TabIndex = 3;
            this.dgbuscarPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbuscarPedido_CellClick_1);
            this.dgbuscarPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbuscarPedido_CellDoubleClick);
            // 
            // PBuscarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 634);
            this.Controls.Add(this.checkBpedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgbuscarPedido);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PBuscarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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