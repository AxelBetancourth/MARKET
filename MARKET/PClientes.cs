﻿using CapaDatos;
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
        private NPedidos nPedidos;
        private NFacturas nFacturas;
        public PClientes()
        {
            InitializeComponent();
            nclientes = new NClientes();
            nCondicionPagos = new NCondicionPagos();
            nGrupoDescuentos = new NGrupoDescuentos();
            nPedidos = new NPedidos();
            nFacturas = new NFacturas();
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
            txtClienteId.Text = "";
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

        private bool ValidarGrupoDescuento()
        {
            var GrupoDescuentoValidos = nGrupoDescuentos.CargaCombo().Select(c => c.Descripcion).ToList();
            

            if (!GrupoDescuentoValidos.Contains(cbxdescuentos.Text))
            {
                ErrorClientes.SetError(cbxdescuentos, "El Grupo de descuento seleccionado no es válido.");
                return false;
            }
            return true;
        }
        private bool ValidarCondicionPagos()
        {
            var CondicionPagoValidos = nCondicionPagos.CargaCombo().Select(c => c.Descripcion).ToList();
            if (!CondicionPagoValidos.Contains(cbxPagos.Text))
            {
                ErrorClientes.SetError(cbxPagos, "La condicion de pago seleccionada no es válida.");
                return false;
            }
            return true;
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
            if (string.IsNullOrEmpty(cbxdescuentos.Text.Trim()))
            {
                FormularioValido = false;
                ErrorClientes.SetError(cbxdescuentos, "Debe ingresar un grupo de descuento");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(cbxPagos.Text.Trim()))
            {
                FormularioValido = false;
                ErrorClientes.SetError(cbxPagos, "Debe ingresar una condición de pago");
                return FormularioValido;
            }
            if (!ValidarGrupoDescuento())
            {
                FormularioValido = false;
            }
            if (!ValidarCondicionPagos())
            {
                FormularioValido = false;
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
            return FormularioValido;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ErrorClientes.Clear();
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
            var PedidosAsociados = nPedidos.TodosPedidos().Where(c => c.ClienteID == int.Parse(ClienteID)).ToList();
            if (PedidosAsociados.Count > 0)
            {
                MessageBox.Show("El cliente tiene asociados 'Pedidos', desvincule para poder eliminar ");
                return;
            }
            var FacturasAsociadas = nFacturas.TodasFacturas().Where(c => c.ClienteID == int.Parse(ClienteID)).ToList();
            if (FacturasAsociadas.Count > 0)
            {
                MessageBox.Show("El cliente tiene asociadas 'Facturas', desvincule para poder eliminar ");
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



