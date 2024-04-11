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
    public partial class PFacturaDetalle : Form
    {
        private NFacturaDetalle nFacturadetalle;
        private NProductos nProductos;
        private PBuscarFacturas buscarFactura;
        private PBuscarProducto buscarProducto;
        public PFacturaDetalle()
        {
            InitializeComponent();
            InitializeComponent();
            nProductos = new NProductos();
            nFacturadetalle = new NFacturaDetalle();
            CargarDatos();
        }

       
        void LimpiarDatos()
        {
            txtDetalleFacturaId.Text = "";
            txtFacturaaId.Text = "";
            txtProductooId.Text = "";
            txtPrecios.Text = "";
            txtTotaal.Text = "";
            txtSubto.Text = "";
            txtDescuentoo.Text = "";
            errorProvider1.Clear();
        }
        void CargarDatos()
        {
            var datos = nFacturadetalle.obtenerFacturaDetalleGrid();
            DgDetalleFactura.DataSource = datos;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bbuscarproducto_Click(object sender, EventArgs e)
        {
            PBuscarProducto pproducto = new PBuscarProducto();
            if (pproducto.ShowDialog() == DialogResult.OK)
            {
                txtProductooId.Text = pproducto.productoId;
                txtPrecios.Text = pproducto.preciocompra;
            }
            /*PBuscarProducto pproducto = new PBuscarProducto();
            pproducto.ShowDialog();
            txtProductooId.Text = pproducto.productoId;
            txtPrecios.Text = pproducto.preciocompra; */
        }
        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtPrecios.Text.ToString()) || string.IsNullOrWhiteSpace(txtPrecios.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtPrecios, "Debe de buscar y seleccionar un pedido");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtTotaal.Text.ToString()) || string.IsNullOrWhiteSpace(txtTotaal.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtTotaal, "Debe buscar y seleccionar un producto");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtSubto.Text.ToString()) || string.IsNullOrWhiteSpace(txtSubto.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtSubto, "Debe buscar y seleccionar un producto");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtDescuentoo.Text.ToString()) || string.IsNullOrWhiteSpace(txtDescuentoo.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtDescuentoo, "Debe buscar y seleccionar un producto");
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
                    FacturaId = int.Parse(txtFacturaaId.Text.ToString()),
                    ProductoId = int.Parse(txtProductooId.Text.ToString()),
                    Precio = decimal.Parse(txtPrecios.Text.ToString()),
                    Total = decimal.Parse(txtTotaal.Text.ToString()),
                    SubTotal = decimal.Parse(txtSubto.Text.ToString()),
                    Descuento = decimal.Parse(txtDescuentoo.Text.ToString()),
                };
                if (!string.IsNullOrEmpty(txtDetalleFacturaId.Text) && int.TryParse(txtDetalleFacturaId.Text.ToString(), out int facturaId) && facturaId != 0)
                {
                    FacturaDetalle.FacturaDetalleId = facturaId;
                    nFacturadetalle.EditarFacturaDetalle(FacturaDetalle);
                }
                else
                {
                    nFacturadetalle.AgregarFacturaDetalle(FacturaDetalle);
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
            nFacturadetalle.Eliminar(int.Parse(facturadetalleId));
            CargarDatos();
            LimpiarDatos();
        }

        private void bbuscarfactu_Click(object sender, EventArgs e)
        {
            PBuscarFacturas pfactura = new PBuscarFacturas();
            pfactura.ShowDialog();
            txtTotaal.Text = pfactura.Total;
            txtSubto.Text = pfactura.SubTotal;
            txtDescuentoo.Text = pfactura.Descuento;
            txtFacturaaId.Text = pfactura.FacturaId;
        }

        private void DgDetalleFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgDetalleFactura.Rows.Count)
            {
                txtDetalleFacturaId.Text = DgDetalleFactura.CurrentRow.Cells["FacturaDetalleId"].Value.ToString();
                txtPrecios.Text = DgDetalleFactura.CurrentRow.Cells["Precio"].Value.ToString();
                txtTotaal.Text = DgDetalleFactura.CurrentRow.Cells["Total"].Value.ToString();
                txtSubto.Text = DgDetalleFactura.CurrentRow.Cells["SubTotal"].Value.ToString();
                txtDescuentoo.Text = DgDetalleFactura.CurrentRow.Cells["Descuento"].Value.ToString();
                txtFacturaaId.Text = DgDetalleFactura.CurrentRow.Cells["FacturaId"].Value.ToString();
                txtProductooId.Text = DgDetalleFactura.CurrentRow.Cells["ProductoId"].Value.ToString();
            }
        }

        private void PFacturaDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
