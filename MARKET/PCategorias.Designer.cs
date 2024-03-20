namespace MARKET
{
    partial class PCategorias
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCategoriaId = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(356, 294);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 48);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(243, 294);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(96, 48);
            this.BtnGuardar.TabIndex = 22;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(161, 201);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(389, 26);
            this.txtDescripcion.TabIndex = 21;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(161, 146);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(112, 26);
            this.txtCodigo.TabIndex = 20;
            // 
            // txtCategoriaId
            // 
            this.txtCategoriaId.Location = new System.Drawing.Point(161, 89);
            this.txtCategoriaId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoriaId.Name = "txtCategoriaId";
            this.txtCategoriaId.ReadOnly = true;
            this.txtCategoriaId.Size = new System.Drawing.Size(112, 26);
            this.txtCategoriaId.TabIndex = 19;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.Location = new System.Drawing.Point(18, 261);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(84, 24);
            this.cbEstado.TabIndex = 18;
            this.cbEstado.Text = "Activo";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Categoria Id";
            // 
            // cbActivos
            // 
            this.cbActivos.AutoSize = true;
            this.cbActivos.Location = new System.Drawing.Point(14, 315);
            this.cbActivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Size = new System.Drawing.Size(175, 24);
            this.cbActivos.TabIndex = 14;
            this.cbActivos.Text = "Mostrar solo activas";
            this.cbActivos.UseVisualStyleBackColor = true;
            this.cbActivos.CheckedChanged += new System.EventHandler(this.cbActivos_CheckedChanged);
            // 
            // dgCategorias
            // 
            this.dgCategorias.AllowUserToAddRows = false;
            this.dgCategorias.AllowUserToDeleteRows = false;
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Location = new System.Drawing.Point(14, 355);
            this.dgCategorias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.ReadOnly = true;
            this.dgCategorias.RowHeadersWidth = 51;
            this.dgCategorias.RowTemplate.Height = 24;
            this.dgCategorias.Size = new System.Drawing.Size(1006, 354);
            this.dgCategorias.TabIndex = 13;
            this.dgCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategorias_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Todas las categorias de proveedores";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 722);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCategoriaId);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbActivos);
            this.Controls.Add(this.dgCategorias);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCategorias";
            this.Load += new System.EventHandler(this.PCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCategoriaId;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbActivos;
        private System.Windows.Forms.DataGridView dgCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}