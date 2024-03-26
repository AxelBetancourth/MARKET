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
    public partial class PClientes : Form
    {
        private NClientes nclientes;
        private NCondicionPagos nCondicionPagos;
        private NGrupoDescuentos nGrupoDescuentos;
        public PClientes()
        {
            InitializeComponent();
            nclientes = new NClientes();
            nCondicionPagos = new NCondicionPagos();
            nGrupoDescuentos = new NGrupoDescuentos();
            CargarDatos();
            CargarCombos();
        }

        void CargarDatos()
        {
            var datos = nclientes.obtenerGridClientes();
            dgClientes.DataSource = datos;
        }
        void LimpiarDatos()
        {
            txtcodigo.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            cbxdescuentos.SelectedValue = "";
            cbxPagos.SelectedValue = "";
            cbEstado.Checked = false;
            ErrorClientes.Clear();
        }

        private void CargarCombos()
        {
            cbxdescuentos.DataSource = nGrupoDescuentos.CargaCombo();
            cbxdescuentos.ValueMember = "Valor";
            cbxdescuentos.DisplayMember = "Descripcion";

            cbxPagos.DataSource = nCondicionPagos.CargaCombo();
            cbxPagos.ValueMember = "Valor";
            cbxPagos.DisplayMember = "Descripcion";
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtcodigo.Text.ToString()) || string.IsNullOrWhiteSpace(txtcodigo.Text.ToString()))
            {
                FormularioValido = false;
                ErrorClientes.SetError(txtcodigo, "Debe ingrear un Codigo");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtnombres.Text.ToString()) || string.IsNullOrWhiteSpace(txtnombres.Text.ToString()))
            {
                FormularioValido = false;
                ErrorClientes.SetError(txtnombres, "Debe de ingresar un nombre");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtapellidos.Text.ToString()) || string.IsNullOrWhiteSpace(txtapellidos.Text.ToString()))
            {
                FormularioValido = false;
                ErrorClientes.SetError(txtapellidos, "Debe ingresar un apellido");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(cbxdescuentos.Text.ToString()) || string.IsNullOrWhiteSpace(cbxdescuentos.Text.ToString()))
            {
                FormularioValido = false;
                ErrorClientes.SetError(cbxdescuentos, "Debe ingresar un grupo de descuento");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(cbxPagos.Text.ToString()) || string.IsNullOrWhiteSpace(cbxPagos.Text.ToString()))
            {
                FormularioValido = false;
                ErrorClientes.SetError(cbxPagos, "Debe ingresar una condición de pago");
                return FormularioValido;
            }
            return FormularioValido;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MClientes Clientes = new MClientes()

                {
                    Codigo = txtcodigo.Text,
                    Nombres = txtnombres.Text,
                    Apellidos = txtapellidos.Text,
                    GrupoDescuentoId = int.Parse(cbxdescuentos.SelectedValue.ToString()),
                    CodigoPagoId = int.Parse(cbxPagos.SelectedValue.ToString()),
                    Estado = cbEstado.Checked
                };
                if (!string.IsNullOrEmpty(txtClienteId.Text) || !string.IsNullOrWhiteSpace(txtClienteId.Text))
                {
                    if (int.TryParse(txtClienteId.Text.ToString(), out int clienteId) && clienteId != 0)
                    {
                        Clientes.ClienteID = clienteId;
                    }
                }
                nclientes.GuardarClientes(Clientes);
                LimpiarDatos();
                CargarDatos();
            }

        }

        private void PClientes_Load(object sender, EventArgs e)
        {

        }

        private void dgClientes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgClientes.Rows.Count)
            {
                DataGridViewRow row = dgClientes.Rows[e.RowIndex];
                txtClienteId.Text = row.Cells["ClienteID"].Value.ToString();
                txtcodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtnombres.Text = row.Cells["Nombres"].Value.ToString();
                txtapellidos.Text = row.Cells["Apellidos"].Value.ToString();
                var descuentos = dgClientes.CurrentRow.Cells["DescuentosCodigo"].Value.ToString();
                cbxdescuentos.SelectedIndex = cbxdescuentos.FindStringExact(descuentos);
                var pagos = dgClientes.CurrentRow.Cells["PagoCodigo"].Value.ToString();
                cbxPagos.SelectedIndex = cbxPagos.FindStringExact(pagos);
                cbEstado.Checked = bool.Parse(dgClientes.CurrentRow.Cells["Estado"].Value.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var ClienteID = txtClienteId.Text.ToString();
            if (string.IsNullOrEmpty(ClienteID) || string.IsNullOrWhiteSpace(ClienteID))
            {
                return;
            }
            nclientes.EliminarCliente(int.Parse(ClienteID));
            CargarDatos();
            LimpiarDatos();
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgClientes.DataSource = nclientes.obtenerClientesActivosGrid();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }
    }
}



