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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MARKET
{
    public partial class PProductos : Form
    {

        private NProductos nProductos;
        private NCategorias nCategoria;
        private NUnidadMedidas nUnidadMedida;
        private NPedidoDetalles nPedidoDetalles;
        public PProductos()
        {
            InitializeComponent();
            nProductos = new NProductos();
            nCategoria = new NCategorias();
            nUnidadMedida = new NUnidadMedidas();
            nPedidoDetalles = new NPedidoDetalles();
            CargarDatos();
            CargarCombos();
        }

        void LimpiarDatos()
        {
            txtProductoid.Text = "";
            cbxcategoria.SelectedValue = "";
            cbxunidadmedida.SelectedValue = "";
            checkbEstado.Checked = false;
            txtpreciocompra.Text = "";
            errorProvider1.Clear();
        }


        void CargarDatos()
        {
            var datos = nProductos.obtenerProductosGrid();
            dgProductos.DataSource = datos;
        }
        private void PProductos_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(cbxcategoria.Text.ToString()) || string.IsNullOrWhiteSpace(cbxcategoria.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(cbxcategoria, "Debe seleccionar una categoria");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(cbxunidadmedida.Text.ToString()) || string.IsNullOrWhiteSpace(cbxunidadmedida.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(cbxunidadmedida, "Debe deleccionar una unidad de medida");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtpreciocompra.Text.ToString()) || string.IsNullOrWhiteSpace(txtpreciocompra.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtpreciocompra, "Debe ingresar el precio de la compra");
                return FormularioValido;
            }
            if (!ValidarCategoria())
            {
                FormularioValido = false;
            }
            if (!ValidarUnidadeMedida())
            {
                FormularioValido = false;
            }
            return FormularioValido;
        }

        private void CargarCombos()
        {
            cbxcategoria.DataSource = nCategoria.CargaCombo();
            cbxcategoria.ValueMember = "Valor";
            cbxcategoria.DisplayMember = "Descripcion";

            cbxunidadmedida.DataSource = nUnidadMedida.CargaCombo();
            cbxunidadmedida.ValueMember = "Valor";
            cbxunidadmedida.DisplayMember = "Descripcion";
        }

        private void LimpiarCampos()
        {
            txtProductoid.Text = "";
            cbxcategoria.SelectedValue = "";
            cbxunidadmedida.SelectedValue = "";
            txtpreciocompra.Text = "";
            checkbEstado.Checked = false;
            errorProvider1.Clear();
        }
        private bool ValidarCategoria()
        {
            var CondicionPagoValidos = nCategoria.CargaCombo().Select(c => c.Descripcion).ToList();
            if (!CondicionPagoValidos.Contains(cbxcategoria.Text))
            {
                errorProvider1.SetError(cbxcategoria, "La Categoria no es válida Seleccione una categoria");
                return false;
            }
            return true;
        }
        private bool ValidarUnidadeMedida()
        {
            var CondicionPagoValidos = nUnidadMedida.CargaCombo().Select(c => c.Descripcion).ToList();
            if (!CondicionPagoValidos.Contains(cbxunidadmedida.Text))
            {
                errorProvider1.SetError(cbxunidadmedida, "La Unidad de Medida no es válida Seleccione una Unidad de Medida");
                return false;
            }
            return true;
        }
        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                decimal precioCompra;
                if (!decimal.TryParse(txtpreciocompra.Text, out precioCompra))
                {
                    MessageBox.Show("Ingrese un precio de compra válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MProductos Producto = new MProductos()
                {
                    CategoriaId = int.Parse(cbxcategoria.SelectedValue.ToString()),
                    UnidadMedidaId = int.Parse(cbxunidadmedida.SelectedValue.ToString()),
                    Estado = checkbEstado.Checked,
                    PrecioCompra = precioCompra,
                };
                if (!string.IsNullOrEmpty(txtProductoid.Text) || !string.IsNullOrWhiteSpace(txtProductoid.Text))
                {
                    if (int.TryParse(txtProductoid.Text.ToString(), out int productoId) && productoId != 0)
                    {
                        Producto.ProductoId = productoId;
                    }
                }
                nProductos.AgregarProducto(Producto);
                LimpiarCampos();
                CargarDatos();
            }
        }
        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            var productoId = txtProductoid.Text.ToString();
            if (string.IsNullOrEmpty(productoId) || string.IsNullOrWhiteSpace(productoId))
            {
                return;
            }
            var PedidosDetallesAsociados = nPedidoDetalles.TodosDetallesPedidos().Where(c => c.ProductoId== int.Parse(productoId)).ToList();
            if (PedidosDetallesAsociados.Count > 0)
            {
                MessageBox.Show("El producto tiene asociados 'Pedidos Detalles', desvincule para poder eliminar ");
                return;
            }
            nProductos.EliminarProductos(int.Parse(productoId));
            CargarDatos();
            LimpiarDatos();
        }

        private void checkBfiltroactivos_CheckedChanged_1(object sender, EventArgs e)
        {
            dgProductos.DataSource = nProductos.obtenerProductosActivosGrid();
            if (checkBfiltroactivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true;
            }
            else if (e.KeyChar != ',' && textBox.Text.Contains(","))
            {
                int posComa = textBox.Text.IndexOf(',');
                if (textBox.SelectionStart > posComa && textBox.Text.Length > posComa + 2)
                {
                    e.Handled = true;
                }
            }
        }
        private void dgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgProductos.Rows.Count)
            {

                txtProductoid.Text = dgProductos.CurrentRow.Cells["ProductoId"].Value.ToString();
                var categoria = dgProductos.CurrentRow.Cells["CategoriaDescripcion"].Value.ToString();
                cbxcategoria.SelectedIndex = cbxcategoria.FindStringExact(categoria);
                var unidadmedida = dgProductos.CurrentRow.Cells["UnidadMedidaDescripcion"].Value.ToString();
                cbxunidadmedida.SelectedIndex = cbxunidadmedida.FindStringExact(unidadmedida);
                checkbEstado.Checked = bool.Parse(dgProductos.CurrentRow.Cells["Estado"].Value.ToString());
                txtpreciocompra.Text = dgProductos.CurrentRow.Cells["PrecioCompra"].Value.ToString();
            }
        }

        private void txtpreciocompra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

