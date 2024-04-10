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
    public partial class PBuscarProducto : Form
    {

        NProductos nProductos;
        public string productoId { get; set; }
        public string categoria { get; set; }
        public string unidadmedida { get; set; }
        public string preciocompra { get; set; }
        public PBuscarProducto()
        {
            InitializeComponent();
            nProductos = new NProductos();
            cargardatos();
        }

        private void PBuscarProducto_Load(object sender, EventArgs e)
        {

        }
        private void cargardatos()
        {
            var datos = nProductos.BuscarProductosGrid();
            dgbuscarProducto.DataSource = datos;
        }
        private void dgbuscarProducto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void checkBprod_CheckedChanged_1(object sender, EventArgs e)
        {
            dgbuscarProducto.DataSource = nProductos.BuscarProductosGridactivos();
            if (checkBprod.Checked == false)
            {
                cargardatos();
            }
        }

        private void dgbuscarProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            productoId = dgbuscarProducto.CurrentRow.Cells["ProductoId"].Value.ToString();
            categoria = dgbuscarProducto.CurrentRow.Cells["CategoriaDescripcion"].Value.ToString();
            unidadmedida = dgbuscarProducto.CurrentRow.Cells["UnidadMedidaDescripcion"].Value.ToString();
            preciocompra = dgbuscarProducto.CurrentRow.Cells["PrecioCompra"].Value.ToString();
            this.Visible = false;
        }
    }
}
