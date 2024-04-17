using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
        private NFacturaDetalle nFacturaDetalle;

        public PFacturas()
        {
            InitializeComponent();
            nFacturas = new NFacturas();
            nClientes = new NClientes();
            nPedidos = new NPedidos();
            nFacturaDetalle = new NFacturaDetalle();
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
        }

        void LimpiarDatos()
        {
            txtFacturaId.Text = "";
            cbxclientes.SelectedValue = "";
            txtpedidoid.Text = "";
            fechafactura.Value = DateTime.Now;
            cbEstado.Checked = false;
            txttotal.Text = "";
            txtsubtotal.Text = "";
            txtdescuento.Text = "";
            errorProvider1.Clear();
        }

        private bool ValidarCliente()
        {
            var clientesValidos = nClientes.CargaCombo().Select(c => c.Descripcion).ToList();
            if (!clientesValidos.Contains(cbxclientes.Text))
            {
                errorProvider1.SetError(cbxclientes, "El cliente seleccionado no es válido.");
                return false;
            }
            return true;
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(cbxclientes.Text.Trim()))
            {
                FormularioValido = false;
                errorProvider1.SetError(cbxclientes, "Debe seleccionar un Cliente");
                return FormularioValido;
            }
            if (!ValidarCliente())
            {
                FormularioValido = false;
            }
            if (string.IsNullOrEmpty(txttotal.Text.ToString()) || string.IsNullOrWhiteSpace(txttotal.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txttotal, "Debe ingresar un Pedido");
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
            errorProvider1.Clear();
            var fecha = fechafactura.Value.ToString();
            DateTime fechaeditarfactura = DateTime.Parse(fecha);

            if (ValidarDatos())
            {
                MFacturas facturas = new MFacturas()

                {
                    ClienteID = int.Parse(cbxclientes.SelectedValue.ToString()),
                    PedidoID = int.Parse(txtpedidoid.Text.ToString()),
                    FechaFactura = fechaeditarfactura,
                    Estado = cbEstado.Checked,
                    Total = decimal.Parse(txttotal.Text.ToString()),
                    SubTotal = decimal.Parse(txtsubtotal.Text.ToString()),
                    Descuento = decimal.Parse(txtdescuento.Text.ToString()),

                };
                if (!string.IsNullOrEmpty(txtFacturaId.Text) && int.TryParse(txtFacturaId.Text.ToString(), out int facturaId) && facturaId != 0)
                {
                    facturas.FacturaId = facturaId;
                    nFacturas.EditarFacturas(facturas);
                }
                else
                {
                    nFacturas.AgregarFacturas(facturas);
                }
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
            var DetalleFacturasAsociado = nFacturaDetalle.TodosDetallesFacturas().Where(c => c.FacturaId == int.Parse(FacturaId)).ToList();
            if (DetalleFacturasAsociado.Count > 0)
            {
                MessageBox.Show("La factura tiene asociados 'Detalle de Facturas', desvincule para poder eliminar ");
            }
            else
            {
                nFacturas.Eliminar(int.Parse(FacturaId));
                CargarDatos();
                LimpiarDatos();
            }
        }

        private void bbuscarpedido_Click(object sender, EventArgs e)
        {
            PBuscarPedido ppedido = new PBuscarPedido();
            ppedido.ShowDialog();
            txtpedidoid.Text = ppedido.PedidoID;
            txttotal.Text = ppedido.Total;
            txtsubtotal.Text = ppedido.SubTotal;
            txtdescuento.Text = ppedido.Descuento;
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgFacturas.DataSource = nFacturas.obtenerFacturasActivasGrid();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void dgFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgFacturas.Rows.Count)
            {
                txtpedidoid.Text = dgFacturas.CurrentRow.Cells["PedidoID"].Value.ToString();
                txttotal.Text = dgFacturas.CurrentRow.Cells["Total"].Value.ToString();
                txtsubtotal.Text = dgFacturas.CurrentRow.Cells["SubTotal"].Value.ToString();
                txtdescuento.Text = dgFacturas.CurrentRow.Cells["Descuento"].Value.ToString();

                txtFacturaId.Text = dgFacturas.CurrentRow.Cells["FacturaID"].Value.ToString();
                var clientes = dgFacturas.CurrentRow.Cells["ClienteNombreCompleto"].Value.ToString();
                cbxclientes.SelectedIndex = cbxclientes.FindStringExact(clientes);
                if (DateTime.TryParse(dgFacturas.CurrentRow.Cells["FechaFactura"].Value.ToString(), out DateTime fechaFactura))
                {
                    fechafactura.Value = fechaFactura;
                }
                cbEstado.Checked = bool.Parse(dgFacturas.CurrentRow.Cells["Estado"].Value.ToString());
                

                txttotal.Refresh();
                txtsubtotal.Refresh();
                txtdescuento.Refresh();
            }
        }
    }
}
