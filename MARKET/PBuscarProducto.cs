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

        public int ProductoId { get; set; }
        public int Categoriaid { get; set; }
        public int UnidadMedidaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public decimal PrecioCompra { get; set; }
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
            ProductoId = Convert.ToInt32(dgbuscarProducto.CurrentRow.Cells["ProductoId"].Value);
            Categoriaid = Convert.ToInt32(dgbuscarProducto.CurrentRow.Cells["CategoriaId"].Value);
            UnidadMedidaId = Convert.ToInt32(dgbuscarProducto.CurrentRow.Cells["UnidadMedidaId"].Value);
            PrecioCompra = Convert.ToInt32(dgbuscarProducto.CurrentRow.Cells["PrecioCompra"].Value);
            this.Visible = false;
        }
    }
}
