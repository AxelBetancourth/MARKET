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
    public partial class PFacturaDetalles : Form
    {
        NFacturaDetalle nFacturaDetalle;

        public PFacturaDetalles()
        {
            InitializeComponent();
            nFacturaDetalle = new NFacturaDetalle();
            CargarDatos();
        }

        private void PFacturaDetalles_Load(object sender, EventArgs e)
        {
        }
        void CargarDatos()
        {
            var datos = nFacturaDetalle.obtenerFacturaDetalleGrid();
            DgDetalleFactura.DataSource = datos;
        }

        void LimpiarDatos()
        {
            txtDetalleFacturaId.Text = "";
            txtFacturaId.Text = "";
            txtProductoId.Text = "";
            txtPrecio.Text = "";
            txtTotal.Text = "";
            txtSubtotal.Text = "";
            txtDescuento.Text = "";
            errorProvider1.Clear();
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtPrecio.Text.ToString()) || string.IsNullOrWhiteSpace(txtPrecio.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtPrecio, "Debe de buscar y seleccionar un Producto");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtTotal.Text.ToString()) || string.IsNullOrWhiteSpace(txtTotal.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtTotal, "Debe buscar y seleccionar una Factura");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtSubtotal.Text.ToString()) || string.IsNullOrWhiteSpace(txtSubtotal.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtSubtotal, "Debe buscar y seleccionar una Factura");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtDescuento.Text.ToString()) || string.IsNullOrWhiteSpace(txtDescuento.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtDescuento, "Debe buscar y seleccionar una Factura");
                return FormularioValido;
            }
            return FormularioValido;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MFacturaDetalle FacturaDetalle = new MFacturaDetalle()
                {
                    FacturaId = int.Parse(txtFacturaId.Text.ToString()),
                    ProductoId = int.Parse(txtProductoId.Text.ToString()),
                    Precio = decimal.Parse(txtPrecio.Text.ToString()),
                    Total = decimal.Parse(txtTotal.Text.ToString()),
                    SubTotal = decimal.Parse(txtSubtotal.Text.ToString()),
                    Descuento = decimal.Parse(txtDescuento.Text.ToString()),
                };
                if (!string.IsNullOrEmpty(txtDetalleFacturaId.Text) && int.TryParse(txtDetalleFacturaId.Text.ToString(), out int facturaId) && facturaId != 0)
                {
                    FacturaDetalle.FacturaDetalleId = facturaId;
                    nFacturaDetalle.EditarFacturaDetalle(FacturaDetalle);
                }
                else
                {
                    nFacturaDetalle.AgregarFacturaDetalle(FacturaDetalle);
                }
                LimpiarDatos();
                CargarDatos();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var facturadetalleId = txtDetalleFacturaId.Text.ToString();
            if (string.IsNullOrEmpty(facturadetalleId) || string.IsNullOrWhiteSpace(facturadetalleId))
            {
                return;
            }
            nFacturaDetalle.Eliminar(int.Parse(facturadetalleId));
            CargarDatos();
            LimpiarDatos();
        }

        private void DgDetalleFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgDetalleFactura.Rows.Count)
            {
                txtDetalleFacturaId.Text = DgDetalleFactura.CurrentRow.Cells["FacturaDetalleId"].Value.ToString();
                txtProductoId.Text = DgDetalleFactura.CurrentRow.Cells["ProductoId"].Value.ToString();
                txtPrecio.Text = DgDetalleFactura.CurrentRow.Cells["Precio"].Value.ToString();
                txtFacturaId.Text = DgDetalleFactura.CurrentRow.Cells["FacturaId"].Value.ToString();
                txtTotal.Text = DgDetalleFactura.CurrentRow.Cells["Total"].Value.ToString();
                txtSubtotal.Text = DgDetalleFactura.CurrentRow.Cells["SubTotal"].Value.ToString();
                txtDescuento.Text = DgDetalleFactura.CurrentRow.Cells["Descuento"].Value.ToString();
            }
        }

        private void bProducto_Click(object sender, EventArgs e)
        {
            PBuscarProducto BuscarProductos = new PBuscarProducto();
            BuscarProductos.ShowDialog();
            txtProductoId.Text = BuscarProductos.ProductoId.ToString();
            txtPrecio.Text = BuscarProductos.PrecioCompra.ToString();
        }

        private void bFactura_Click(object sender, EventArgs e)
        {
            PBuscarFacturas pfactura = new PBuscarFacturas();
            pfactura.ShowDialog();
            txtFacturaId.Text = pfactura.FacturaId;
            txtTotal.Text = pfactura.Total;
            txtSubtotal.Text = pfactura.SubTotal;
            txtDescuento.Text = pfactura.Descuento;
        }
    }
}
