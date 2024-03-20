using CapaDatos.BaseDatos.Modelos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARKET
{
    public partial class PCategorias : Form
    {
        private NCategorias nCategorias;
        public PCategorias()
        {
            InitializeComponent();
            nCategorias = new NCategorias();
            CargarDatos();
        }

        void CargarDatos()
        {
            dgCategorias.DataSource = nCategorias.TodasLasCategorias();
        }

        void LimpiarDatos()
        {
            txtCategoriaId.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgCategorias.DataSource = nCategorias.CategoriasActivas();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var categoriaId = txtCategoriaId.Text.ToString();
            var codigo = txtCodigo.Text.ToString();
            var descripcion = txtDescripcion.Text.ToString();
            if (string.IsNullOrEmpty(categoriaId) || string.IsNullOrWhiteSpace(categoriaId))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrWhiteSpace(codigo))
            {
                errorProvider1.SetError(txtCodigo, "Debe ingresar el codigo");
                return;
            }
            if (string.IsNullOrEmpty(descripcion) || string.IsNullOrWhiteSpace(descripcion))
            {
                errorProvider1.SetError(txtDescripcion, "Debe ingresar una descripcion");
                return;
            }

            if (agregar)
            {
                nCategorias.AgregarCategoria(new MCategorias()
                {
                    Codigo = codigo,
                    Descripción = descripcion,
                    Estado = cbEstado.Checked
                });
            }
            else
            {
                nCategorias.EditarCategoria(new MCategorias()
                {
                    CategoriaId = int.Parse(categoriaId),
                    Codigo = codigo,
                    Descripción = descripcion,
                    Estado = cbEstado.Checked
                });
            }

            CargarDatos();
            LimpiarDatos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var categoriaId = txtCategoriaId.Text.ToString();
            if (string.IsNullOrEmpty(categoriaId) || string.IsNullOrWhiteSpace(categoriaId))
            {
                return;
            }
            nCategorias.EliminarCategoria(int.Parse(categoriaId));
            CargarDatos();
            LimpiarDatos();
        }

        private void dgCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgCategorias.Rows.Count)
            {
                DataGridViewRow row = dgCategorias.Rows[e.RowIndex];
                txtCategoriaId.Text = row.Cells["CategoriaId"].Value.ToString();
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripción"].Value.ToString();
            }
        }

    }
}
