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
    public partial class PGrupoDescuentos : Form
    {
        private NGrupoDescuentos nGrupoDescuentos;
        public PGrupoDescuentos()
        {
            InitializeComponent();
            nGrupoDescuentos = new NGrupoDescuentos();
            CargarDatos();
        }
        void CargarDatos()
        {
            dgDescuentos.DataSource = nGrupoDescuentos.TodasLosDescuentos();
        }

        void LimpiarDatos()
        {
            txtDescuentosId.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPorcentaje.Text = "";
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }

        private void PGrupoDescuentos_Load(object sender, EventArgs e)
        {

        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgDescuentos.DataSource = nGrupoDescuentos.DescuentosActivos();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var unidadesId = txtDescuentosId.Text.ToString();
            var codigo = txtCodigo.Text.ToString();
            var descripcion = txtDescripcion.Text.ToString();
            var porcentaje = txtPorcentaje.Text.ToString();

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
            if (string.IsNullOrEmpty(porcentaje) || string.IsNullOrWhiteSpace(porcentaje))
            {
                errorProvider1.SetError(txtPorcentaje, "Debe ingresar un porcentaje");
                return;
            }
            if (agregar)
            {
                nGrupoDescuentos.AgregarDescuentos(new MGrupoDescuentos()
                {
                    Codigo = codigo,
                    Descripción = descripcion,
                    Porcentaje = int.Parse(porcentaje),
                    Estado = cbEstado.Checked
                });
            }
            else
            {
                nGrupoDescuentos.EditarDescuentos(new MGrupoDescuentos()
                {
                    GrupoDescuentoId = int.Parse(unidadesId),
                    Codigo = codigo,
                    Descripción = descripcion,
                    Porcentaje = int.Parse(porcentaje),
                    Estado = cbEstado.Checked
                });
            }

            CargarDatos();
            LimpiarDatos();
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var GrupoDescuentoId = txtDescuentosId.Text.ToString();
            if (string.IsNullOrEmpty(GrupoDescuentoId) || string.IsNullOrWhiteSpace(GrupoDescuentoId))
            {
                return;
            }
            nGrupoDescuentos.EliminarDescuentos(int.Parse(GrupoDescuentoId));
            CargarDatos();
            LimpiarDatos();
        }

        private void dgDescuentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgDescuentos.Rows.Count)
            {
                DataGridViewRow row = dgDescuentos.Rows[e.RowIndex];
                txtDescuentosId.Text = row.Cells["GrupoDescuentoId"].Value.ToString();
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripción"].Value.ToString();
                cbEstado.Checked = bool.Parse(dgDescuentos.CurrentRow.Cells["Estado"].Value.ToString());
                txtPorcentaje.Text = row.Cells["Porcentaje"].Value.ToString();
            }
        }

    }
}
