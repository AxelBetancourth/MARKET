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
    public partial class PBuscarPedido : Form
    {

        NPedidos nPedidos;
        public string PedidoID { get; set; }
        public string Total { get; set; }
        public string SubTotal { get; set; }
        public string Descuento { get; set; }
        public PBuscarPedido()
        {
            InitializeComponent();
            nPedidos = new NPedidos();
            cargardatos();
        }

        private void PBuscarPedido_Load(object sender, EventArgs e)
        {

        }
        private void cargardatos()
        {
            var datos = nPedidos.BuscarPedidosGrid();
            dgbuscarPedido.DataSource = datos;
        }
        private void dgbuscarPedido_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            PedidoID = dgbuscarPedido.CurrentRow.Cells["PedidoID"].Value.ToString();
            Total = dgbuscarPedido.CurrentRow.Cells["Total"].Value.ToString();
            SubTotal = dgbuscarPedido.CurrentRow.Cells["SubTotal"].Value.ToString();
            Descuento = dgbuscarPedido.CurrentRow.Cells["Descuento"].Value.ToString();
            this.Visible = false;
        }

        private void checkBpedidos_CheckedChanged_1(object sender, EventArgs e)
        {
            dgbuscarPedido.DataSource = nPedidos.BuscarPedidosactivosGrid();
            if (checkBpedidos.Checked == false)
            {
                cargardatos();
            }
        }
    }
}

