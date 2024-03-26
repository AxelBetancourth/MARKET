
namespace MARKET
{
    partial class PClientes
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
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescuentoid = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpagoid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbActivos
            // 
            this.cbActivos.AutoSize = true;
            this.cbActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivos.Location = new System.Drawing.Point(18, 466);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Size = new System.Drawing.Size(215, 26);
            this.cbActivos.TabIndex = 23;
            this.cbActivos.Text = "Mostrar solo activas";
            this.cbActivos.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(583, 452);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 40);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(390, 452);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 40);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(18, 501);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.RowHeadersWidth = 62;
            this.dgClientes.RowTemplate.Height = 28;
            this.dgClientes.Size = new System.Drawing.Size(1066, 301);
            this.dgClientes.TabIndex = 20;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(156, 280);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(365, 26);
            this.txtnombres.TabIndex = 19;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(156, 230);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(365, 26);
            this.txtcodigo.TabIndex = 18;
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(156, 184);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(100, 26);
            this.txtClienteId.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Todos los clientes";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.Location = new System.Drawing.Point(305, 184);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(91, 26);
            this.cbEstado.TabIndex = 15;
            this.cbEstado.Text = "Activo";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "ClienteId";
            // 
            // txtdescuentoid
            // 
            this.txtdescuentoid.Location = new System.Drawing.Point(159, 370);
            this.txtdescuentoid.Name = "txtdescuentoid";
            this.txtdescuentoid.Size = new System.Drawing.Size(365, 26);
            this.txtdescuentoid.TabIndex = 27;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(159, 320);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(365, 26);
            this.txtapellidos.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "DescuentoID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Apellidos";
            // 
            // txtpagoid
            // 
            this.txtpagoid.Location = new System.Drawing.Point(655, 222);
            this.txtpagoid.Name = "txtpagoid";
            this.txtpagoid.Size = new System.Drawing.Size(365, 26);
            this.txtpagoid.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(552, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(552, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "PagoID";
            // 
            // PClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 883);
            this.Controls.Add(this.txtpagoid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdescuentoid);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbActivos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PClientes";
            this.Text = "PClientes";
 
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbActivos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescuentoid;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpagoid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}