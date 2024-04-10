using CapaDatos;
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
    public partial class PUnidadMedidas : Form
    {
        private NUnidadMedidas unidadMedidas;
        private NProductos nProductos;
        public PUnidadMedidas()
        {
            InitializeComponent();
            unidadMedidas = new NUnidadMedidas();
            nProductos = new NProductos();
            CargarDatos();
        }
        void CargarDatos()
        {
            dgUnidades.DataSource = unidadMedidas.TodasLasUnidades();
        }

        void LimpiarDatos()
        {
            txtUnidadesId.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }

        private void PUnidadMedidas_Load(object sender, EventArgs e)
        {

        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgUnidades.DataSource = unidadMedidas.UnidadesActivas();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var unidadesId = txtUnidadesId.Text.ToString();
            var codigo = txtCodigo.Text.ToString();
            var descripcion = txtDescripcion.Text.ToString();
            if (string.IsNullOrEmpty(unidadesId) || string.IsNullOrWhiteSpace(unidadesId))
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
                unidadMedidas.AgregarUnidades(new MUnidadMedidas()
                {
                    Codigo = codigo,
                    Descripción = descripcion,
                    Estado = cbEstado.Checked
                });
            }
            else
            {
                unidadMedidas.EditarUnidades(new MUnidadMedidas()
                {
                    UnidadMedidaId = int.Parse(unidadesId),
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
            var UnidadMedidaId = txtUnidadesId.Text.ToString();
            if (string.IsNullOrEmpty(UnidadMedidaId) || string.IsNullOrWhiteSpace(UnidadMedidaId))
            {
                return;
            }
            var ProductosAsociado = nProductos.TodosProductos().Where(c => c.UnidadMedidaId == int.Parse(UnidadMedidaId)).ToList();
            if (ProductosAsociado.Count > 0)
            {
                MessageBox.Show("La Unidad de Medida tiene asociados 'Productos', desvincule para poder eliminar ");
            }
            else
            {
                unidadMedidas.EliminarUnidades(int.Parse(UnidadMedidaId));
                CargarDatos();
                LimpiarDatos();
            }
        }

        private void dgUnidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgUnidades.Rows.Count)
            {
                DataGridViewRow row = dgUnidades.Rows[e.RowIndex];
                txtUnidadesId.Text = row.Cells["UnidadMedidaId"].Value.ToString();
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripción"].Value.ToString();
                cbEstado.Checked = bool.Parse(dgUnidades.CurrentRow.Cells["Estado"].Value.ToString());
            }
        }
    }
}
