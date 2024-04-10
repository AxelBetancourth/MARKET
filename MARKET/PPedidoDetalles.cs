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
    public partial class PPedidoDetalles : Form
    {
        private NPedidoDetalles nPedidodetalles;
        private NProductos nProductos;
        private PBuscarPedido buscarPedido;
        private PBuscarProducto buscarProducto;
        public PPedidoDetalles()
        {
            InitializeComponent();
            nProductos = new NProductos();
            nPedidodetalles = new NPedidoDetalles();
            CargarDatos();
        }

        private void PPedidoDetalles_Load(object sender, EventArgs e)
        {
            
        }

        void LimpiarDatos()
        {
            txtDetallePedidoId.Text = "";
            txtpedidoid.Text = "";
            txtproductoid.Text = "";
            txtprecio.Text = "";
            txtotal.Text = "";
            txtsubt.Text = "";
            txtDescuento.Text = "";
            errorProvider1.Clear();
        }
        void CargarDatos()
        {
            var datos = nPedidodetalles.obtenerPedidosDetalleGrid();
            DgDetallesPedido.DataSource = datos;
        }
        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtprecio.Text.ToString()) || string.IsNullOrWhiteSpace(txtprecio.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtprecio, "Debe de buscar y seleccionar un pedido");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtotal.Text.ToString()) || string.IsNullOrWhiteSpace(txtotal.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtotal, "Debe buscar y seleccionar un producto");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtsubt.Text.ToString()) || string.IsNullOrWhiteSpace(txtsubt.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtsubt, "Debe buscar y seleccionar un producto");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtDescuento.Text.ToString()) || string.IsNullOrWhiteSpace(txtDescuento.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtDescuento, "Debe buscar y seleccionar un producto");
                return FormularioValido;
            }
            return FormularioValido;
        }
        private void cbxfechapedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MPedidoDetalles PedidoDetalle = new MPedidoDetalles()
                {
                    PedidoID = int.Parse(txtpedidoid.Text.ToString()),
                    ProductoId = int.Parse(txtproductoid.Text.ToString()),
                    Precio = decimal.Parse(txtprecio.Text.ToString()),
                    Total = decimal.Parse(txtotal.Text.ToString()),
                    SubTotal = decimal.Parse(txtsubt.Text.ToString()),
                    Descuento = decimal.Parse(txtDescuento.Text.ToString()),
                };
                if (!string.IsNullOrEmpty(txtDetallePedidoId.Text) || !string.IsNullOrWhiteSpace(txtDetallePedidoId.Text))
                {
                    if (int.TryParse(txtDetallePedidoId.Text.ToString(), out int pedidodetalleid) && pedidodetalleid != 0)
                    {
                        PedidoDetalle.PedidoDetalleId = pedidodetalleid;
                    }
                }
                nPedidodetalles.AgregarPedidoDetalles(PedidoDetalle);
                LimpiarDatos();
                CargarDatos();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var pedidodetalleId = txtDetallePedidoId.Text.ToString();
            if (string.IsNullOrEmpty(pedidodetalleId) || string.IsNullOrWhiteSpace(pedidodetalleId))
            {
                return;
            }
            nPedidodetalles.Eliminar(int.Parse(pedidodetalleId));
            CargarDatos();
            LimpiarDatos();
        }

        private void bbuscarproducto_Click(object sender, EventArgs e)
        {
            PBuscarProducto pproducto = new PBuscarProducto();
            pproducto.ShowDialog();
            txtprecio.Text = pproducto.preciocompra;
            txtproductoid.Text = pproducto.productoId;
        }

        private void buscarpdido_Click(object sender, EventArgs e)
        {
            PBuscarPedido ppedido = new PBuscarPedido();
            ppedido.ShowDialog();
            txtotal.Text = ppedido.Total;
            txtsubt.Text = ppedido.SubTotal;
            txtDescuento.Text = ppedido.Descuento;
            txtpedidoid.Text = ppedido.PedidoID;
        }

        private void DgDetallesPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgDetallesPedido.Rows.Count)
            {
                txtDetallePedidoId.Text = DgDetallesPedido.CurrentRow.Cells["PedidoDetalleId"].Value.ToString();
                txtprecio.Text = DgDetallesPedido.CurrentRow.Cells["Precio"].Value.ToString();
                txtotal.Text = DgDetallesPedido.CurrentRow.Cells["Total"].Value.ToString();
                txtsubt.Text = DgDetallesPedido.CurrentRow.Cells["SubTotal"].Value.ToString();
                txtDescuento.Text = DgDetallesPedido.CurrentRow.Cells["Descuento"].Value.ToString();
                txtpedidoid.Text = DgDetallesPedido.CurrentRow.Cells["PedidoID"].Value.ToString();
                txtproductoid.Text = DgDetallesPedido.CurrentRow.Cells["ProductoId"].Value.ToString();
            }
        }
    }
}

