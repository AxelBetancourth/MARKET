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
    public partial class PCondicionPagos : Form
    {
        private NCondicionPagos nCondicionPagos;
        public PCondicionPagos()
        {
            InitializeComponent();
            nCondicionPagos = new NCondicionPagos();
            CargarDatos();
        }
        void CargarDatos()
        {
            dgCondiciones.DataSource = nCondicionPagos.TodasLasCondiciones();
        }
        void LimpiarDatos()
        {
            txtCondicionId.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtDias.Text = "";
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }

        private void PCondicionPagos_Load(object sender, EventArgs e)
        {

        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgCondiciones.DataSource = nCondicionPagos.CondicionesActivas();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var condicionId = txtCondicionId.Text.ToString();
            var codigo = txtCodigo.Text.ToString();
            var descripcion = txtDescripcion.Text.ToString();
            var dias = txtDias.Text.ToString();

            if (string.IsNullOrEmpty(condicionId) || string.IsNullOrWhiteSpace(condicionId))
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
            if (string.IsNullOrEmpty(dias) || string.IsNullOrWhiteSpace(dias))
            {
                errorProvider1.SetError(txtDias, "Debe ingresar sus dias correspondientes");
                return;
            }
            if (agregar)
            {
                nCondicionPagos.AgregarCondiciones(new MCondicionPagos()
                {
                    Codigo = codigo,
                    Descripción = descripcion,
                    Dias = int.Parse(dias),
                    Estado = cbEstado.Checked
                });
            }
            else
            {
                nCondicionPagos.EditarCondiciones(new MCondicionPagos()
                {
                    CodigoPagoId = int.Parse(condicionId),
                    Codigo = codigo,
                    Descripción = descripcion,
                    Dias = int.Parse(dias),
                    Estado = cbEstado.Checked
                });
            }

            CargarDatos();
            LimpiarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var CondicionId = txtCondicionId.Text.ToString();
            if (string.IsNullOrEmpty(CondicionId) || string.IsNullOrWhiteSpace(CondicionId))
            {
                return;
            }
            nCondicionPagos.EliminarCondiciones(int.Parse(CondicionId));
            CargarDatos();
            LimpiarDatos();
        }

       

        private void txtDias_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgCondiciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgCondiciones.Rows.Count)
            {
                DataGridViewRow row = dgCondiciones.Rows[e.RowIndex];
                txtCondicionId.Text = row.Cells["CodigoPagoId"].Value.ToString();
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripción"].Value.ToString();
                txtDias.Text = row.Cells["Dias"].Value.ToString();
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}
