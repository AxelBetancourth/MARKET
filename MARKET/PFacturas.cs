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
    public partial class PFacturas : Form
    {
        private NFacturas nFacturas;
        private NClientes nClientes;
        private NPedidos nPedidos;

        public PFacturas()
        {
            InitializeComponent();
            nFacturas = new NFacturas();
            nClientes = new NClientes();
            nPedidos = new NPedidos();
            CargarDatos();
            CargarCombos();
        }

        private void PFacturas_Load(object sender, EventArgs e)
        {

        }

        void CargarDatos()
        {
            var datos = nFacturas.obtenerFacturasGrid();
            dgFacturas.DataSource = datos;
        }

        private void CargarCombos()
        {
            cbxclientes.DataSource = nClientes.CargaCombo();
            cbxclientes.ValueMember = "Valor";
            cbxclientes.DisplayMember = "Descripcion";

            cbxpedidos.DataSource = nPedidos.CargaCombo();
            cbxpedidos.ValueMember = "Valor";
            cbxpedidos.DisplayMember = "Descripcion";
        }

        void LimpiarDatos()
        {
            txtFacturaId.Text = "";
            cbxclientes.SelectedValue = "";
            cbxpedidos.Text = "";
            fechafactura.Value = DateTime.Now;
            cbEstado.Checked = false;
            txttotal.Text = "";
            txtsubtotal.Text = "";
            txtdescuento.Text = "";
            errorProvider1.Clear();
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(cbxclientes.Text.ToString()) || string.IsNullOrWhiteSpace(cbxclientes.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(cbxclientes, "Debe ingrear un Cliente");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(cbxpedidos.Text.ToString()) || string.IsNullOrWhiteSpace(cbxpedidos.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(cbxpedidos, "Debe de ingresar un pedido");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txttotal.Text.ToString()) || string.IsNullOrWhiteSpace(txttotal.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txttotal, "Debe ingresar un monto total");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtsubtotal.Text.ToString()) || string.IsNullOrWhiteSpace(txtsubtotal.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtsubtotal, "Debe ingresar un monto subtotal");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtdescuento.Text.ToString()) || string.IsNullOrWhiteSpace(txtdescuento.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtdescuento, "Debe ingresar un descuento");
                return FormularioValido;
            }
            return FormularioValido;
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            dgFacturas.DataSource = nFacturas.obtenerFacturasActivasGrid();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MFacturas facturas = new MFacturas()

                {
                    ClienteID = int.Parse(cbxclientes.SelectedValue.ToString()),
                    PedidoID = int.Parse(cbxpedidos.SelectedValue.ToString()),
                    FechaFactura = fechafactura.Value,
                    Estado = cbEstado.Checked,
                    Total = decimal.Parse(txttotal.Text.ToString()),
                    SubTotal = decimal.Parse(txtsubtotal.Text.ToString()),
                    Descuento = decimal.Parse(txtdescuento.Text.ToString()),

                };
                if (!string.IsNullOrEmpty(txtFacturaId.Text) || !string.IsNullOrWhiteSpace(txtFacturaId.Text))
                {
                    if (int.TryParse(txtFacturaId.Text.ToString(), out int facturaId) && facturaId != 0)
                    {
                        facturas.FacturaId = facturaId;
                    }
                }
                nFacturas.AgregarFacturas(facturas);
                LimpiarDatos();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var FacturaId = txtFacturaId.Text.ToString();
            if (string.IsNullOrEmpty(FacturaId) || string.IsNullOrWhiteSpace(FacturaId))
            {
                return;
            }
            nFacturas.Eliminar(int.Parse(FacturaId));
            CargarDatos();
            LimpiarDatos();
        }

        private void dgFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgFacturas.Rows.Count)
            {
                DataGridViewRow row = dgFacturas.Rows[e.RowIndex];
                txtFacturaId.Text = row.Cells["FacturaID"].Value.ToString();
                var clientes = dgFacturas.CurrentRow.Cells["ClienteNombreCompleto"].Value.ToString();
                cbxclientes.SelectedIndex = cbxclientes.FindStringExact(clientes);
                var pedidos = dgFacturas.CurrentRow.Cells["PedidoInfo"].Value.ToString();
                cbxpedidos.SelectedIndex = cbxpedidos.FindStringExact(pedidos);
                var fechaFactura = row.Cells["FechaFactura"].Value;
                if (fechaFactura != null)
                {
                    fechafactura.Value = (DateTime)fechaFactura;
                }
                cbEstado.Checked = bool.Parse(dgFacturas.CurrentRow.Cells["Estado"].Value.ToString());
                txttotal.Text = row.Cells["Total"].Value.ToString();
                txtsubtotal.Text = row.Cells["SubTotal"].Value.ToString();
                txtdescuento.Text = row.Cells["Descuento"].Value.ToString();
            }
        }
    }
}
