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
    public partial class PPedidos : Form
    {
        private NPedidos nPedidos;
        private NClientes nClientes;
        private NPedidoDetalles nPedidoDetalles;
        private NFacturas nFacturas;
        public PPedidos()
        {
            InitializeComponent();
            nPedidos = new NPedidos();
            nClientes = new NClientes();
            nPedidoDetalles = new NPedidoDetalles();
            nFacturas = new NFacturas();
            CargarDatos();
            CargaCombo();
            txtDescuento.ReadOnly = true;
        }

        private void PPedidos_Load(object sender, EventArgs e)
        {

        }

        void CargarDatos()
        {
            var datos = nPedidos.obtenerPedidosGrid();
            dgPedidos.DataSource = datos;
        }

        private void CargaCombo()
        {
            cbxClienteid.DataSource = nClientes.CargaCombo();
            cbxClienteid.ValueMember = "Valor";
            cbxClienteid.DisplayMember = "Descripcion";
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgPedidos.DataSource = nPedidos.obtenerPedidosActivosGrid();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        void LimpiarCampos()
        {
            txtpedidoID.Text = "";
            cbxClienteid.SelectedValue = "";
            dtpfechapedido.Value = DateTime.Now;
            txtSubTotal.Text = "";
            txtDescuento.Text = "";
            txtTotal.Text = "";
            cbEstado.Checked = false;
            errorpedidos.Clear();
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(cbxClienteid.Text.ToString()) || string.IsNullOrWhiteSpace(cbxClienteid.Text.ToString()))
            {
                FormularioValido = false;
                errorpedidos.SetError(cbxClienteid, "Debe seleccionar un Cliente");
                return FormularioValido;
            }

            if (string.IsNullOrEmpty(txtTotal.Text.ToString()) || string.IsNullOrWhiteSpace(txtTotal.Text.ToString()))
            {
                FormularioValido = false;
                errorpedidos.SetError(txtTotal, "Debe ingresar el Total.");
                return FormularioValido;
            }

            if (string.IsNullOrEmpty(txtSubTotal.Text.ToString()) || string.IsNullOrWhiteSpace(txtSubTotal.Text.ToString()))
            {
                FormularioValido = false;
                errorpedidos.SetError(txtSubTotal, "Debe ingresar el Subtotal.");
                return FormularioValido;
            }

            if (string.IsNullOrEmpty(txtDescuento.Text.ToString()) || string.IsNullOrWhiteSpace(txtDescuento.Text.ToString()))
            {
                FormularioValido = false;
                errorpedidos.SetError(txtDescuento, "Debe ingresar el Descuento.");
                return FormularioValido;
            }

            return FormularioValido;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var fecha = dtpfechapedido.Value.ToString();
            DateTime fechaeditarpedido = DateTime.Parse(fecha);

            if (ValidarDatos())
            {
                MPedidos Pedidos = new MPedidos()
                {
                    ClienteID = int.Parse(cbxClienteid.SelectedValue.ToString()),
                    FechaPedido = fechaeditarpedido,
                    Estado = cbEstado.Checked,
                    Total = decimal.Parse(txtTotal.Text.ToString()),
                    SubTotal = decimal.Parse(txtSubTotal.Text.ToString()),
                    Descuento = decimal.Parse(txtDescuento.Text.ToString()),
                };
                if (!string.IsNullOrEmpty(txtpedidoID.Text) && int.TryParse(txtpedidoID.Text.ToString(), out int productoId) && productoId != 0)
                {
                    Pedidos.PedidoID = productoId;
                    nPedidos.EditarPedidos(Pedidos);
                }
                else
                {
                    nPedidos.AgregarPedidos(Pedidos);
                }
                LimpiarCampos();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var PedidoId = txtpedidoID.Text.ToString();
            if (string.IsNullOrEmpty(PedidoId) || string.IsNullOrWhiteSpace(PedidoId))
            {
                return;
            }
            var PedidosDetallesAsociados = nPedidoDetalles.TodosDetallesPedidos().Where(c => c.PedidoID == int.Parse(PedidoId)).ToList();
            if (PedidosDetallesAsociados.Count > 0)
            {
                MessageBox.Show("El pedido tiene asociados 'Pedidos Detalles', desvincule para poder eliminar ");
                return;
            }
            var FacturasAsociadas = nFacturas.TodasFacturas().Where(c => c.PedidoID == int.Parse(PedidoId)).ToList();
            if (FacturasAsociadas.Count > 0)
            {
                MessageBox.Show("El pedido tiene asociadas 'Facturas', desvincule para poder eliminar ");
                return;
            }
            nPedidos.Eliminar(int.Parse(PedidoId));
            CargarDatos();
            LimpiarCampos();
        }

        private void dgPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgPedidos.Rows.Count)
            {
                DataGridViewRow row = dgPedidos.Rows[e.RowIndex];
                txtpedidoID.Text = row.Cells["PedidoID"].Value.ToString();
                var Productos = dgPedidos.CurrentRow.Cells["ClienteNombreCompleto"].Value.ToString();
                cbxClienteid.SelectedIndex = cbxClienteid.FindStringExact(Productos);
                if (DateTime.TryParse(dgPedidos.CurrentRow.Cells["FechaPedido"].Value.ToString(), out DateTime FechaPedidos))
                {
                    dtpfechapedido.Value = FechaPedidos;
                }
                cbEstado.Checked = bool.Parse(dgPedidos.CurrentRow.Cells["Estado"].Value.ToString());
                txtTotal.Text = row.Cells["Total"].Value.ToString();
                txtSubTotal.Text = row.Cells["SubTotal"].Value.ToString();
                txtDescuento.Text = row.Cells["Descuento"].Value.ToString();
            }
        }

        private void txtSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != ','))
            {
                e.Handled = true;
            }

        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != ','))
            {
                e.Handled = true;
            }

        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            txtDescuento.ReadOnly = string.IsNullOrEmpty(txtSubTotal.Text);
        }

        private void CalcularTotal()
        {
            if (!string.IsNullOrEmpty(txtSubTotal.Text) && !string.IsNullOrEmpty(txtDescuento.Text))
            {
                decimal subTotal = decimal.Parse(txtSubTotal.Text);
                decimal descuento = decimal.Parse(txtDescuento.Text);
                decimal total = subTotal - descuento;
                txtTotal.Text = total.ToString();
            }
        }
        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescuento.Text))
            {
                decimal descuento = decimal.Parse(txtDescuento.Text);

                if (descuento > 100)
                {
                    errorpedidos.SetError(txtDescuento, "El descuento no puede ser mayor al 100%.");
                    txtTotal.Text = "";
                }
                else
                {
                    errorpedidos.Clear();
                    CalcularTotal();
                }
            }
            else
            {
                errorpedidos.Clear();
                CalcularTotal();
            }
        }
    }
}
