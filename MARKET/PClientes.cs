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
        public PClientes()
        {
            InitializeComponent();
            nclientes = new NClientes();
            CargarDatos();
        }

        void CargarDatos()
        {
            dgClientes.DataSource = nclientes.ClientesTodos();
        }

        void LimpiarDatos()
        {
            txtcodigo.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtdescuentoid.Text = "";
            txtpagoid.Text = "";
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgClientes.DataSource = nclientes.ClientesActivos();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var ClienteID = txtcodigo.Text.ToString();
            var codigo = txtcodigo.Text.ToString();
            var Nombres = txtnombres.Text.ToString();
            var Apellidos = txtapellidos.Text.ToString();
            var GrupoDescuentoId = txtdescuentoid.Text.ToString();
            var CodigoPagoId = txtpagoid.Text.ToString();
            var Estado = cbEstado.Text.ToString();

            if (string.IsNullOrEmpty(ClienteID) || string.IsNullOrWhiteSpace(ClienteID))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrWhiteSpace(codigo))
            {
                errorProvider1.SetError(txtcodigo, "Debe ingresar el codigo");
                return;
            }
            if (string.IsNullOrEmpty(Nombres) || string.IsNullOrWhiteSpace(Nombres))
            {
                errorProvider1.SetError(txtnombres, "Debe ingresar los Nombres");
                return;
            }
            if (string.IsNullOrEmpty(Apellidos) || string.IsNullOrWhiteSpace(Apellidos))
            {
                errorProvider1.SetError(txtapellidos, "Debe ingresar los apellidos");
                return;
            }
            if (string.IsNullOrEmpty(GrupoDescuentoId) || string.IsNullOrWhiteSpace(GrupoDescuentoId))
            {
                errorProvider1.SetError(txtdescuentoid, "Debe ingresar el grupo de descuento");
                return;
            }
            if (string.IsNullOrEmpty(CodigoPagoId) || string.IsNullOrWhiteSpace(CodigoPagoId))
            {
                errorProvider1.SetError(txtpagoid, "Debe ingresar el Id de pago");
                return;
            }
            if (agregar)
            {
                nclientes.GuardarClientes(new MClientes()
                {

               
                 Codigo = codigo,
                 Nombres = Nombres,
                 Apellidos = Apellidos,
                 GrupoDescuentoId = int.Parse(GrupoDescuentoId),
                 CodigoPagoId = int.Parse(CodigoPagoId),
                 Estado = cbEstado.Checked


            });
            }
            else
            {
                nclientes.GuardarClientes(new MClientes()
                {

                    ClienteID = int.Parse(ClienteID),
                    Codigo = codigo,
                    Nombres = Nombres,
                    Apellidos = Apellidos,
                    GrupoDescuentoId = int.Parse(GrupoDescuentoId),
                    CodigoPagoId = int.Parse(CodigoPagoId),
                    Estado = cbEstado.Checked
                });
            }

            CargarDatos();
            LimpiarDatos();
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

        private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgClientes.Rows.Count)
            {
                DataGridViewRow row = dgClientes.Rows[e.RowIndex];
                txtClienteId.Text = row.Cells["ClienteID"].Value.ToString();
                txtcodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtnombres.Text = row.Cells["Nombres"].Value.ToString();
                txtapellidos.Text = row.Cells["Apellidos"].Value.ToString();
                txtdescuentoid.Text = row.Cells["GrupoDescuentoId"].Value.ToString();
                txtpagoid.Text = row.Cells["CodigoPagoId"].Value.ToString();
                cbEstado.Checked = bool.Parse(dgClientes.CurrentRow.Cells["Estado"].Value.ToString());
                
            }
        }

    }
}



