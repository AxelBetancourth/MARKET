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
    public partial class PBuscarFacturas : Form
    {
        NFacturas nFacturas;
        public string FacturaId { get; set; }
        public string Total { get; set; }
        public string SubTotal { get; set; }
        public string Descuento { get; set; }
        public PBuscarFacturas()
        {
            InitializeComponent();
            nFacturas = new NFacturas();
            cargardatos();
        }

        private void PBuscarFacturacs_Load(object sender, EventArgs e)
        {

        }
        private void cargardatos()
        {
            var datos = nFacturas.obtenerFacturasGrid();
            dgbuscarFactura.DataSource = datos;
        }

        private void checkBfacturas_CheckedChanged(object sender, EventArgs e)
        {
            dgbuscarFactura.DataSource = nFacturas.obtenerFacturasActivasGrid();
            if (checkBfacturas.Checked == false)
            {
                cargardatos();
            }
        }

     

        private void dgbuscarFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FacturaId = dgbuscarFactura.CurrentRow.Cells["FacturaId"].Value.ToString();
            Total = dgbuscarFactura.CurrentRow.Cells["Total"].Value.ToString();
            SubTotal = dgbuscarFactura.CurrentRow.Cells["SubTotal"].Value.ToString();
            Descuento = dgbuscarFactura.CurrentRow.Cells["Descuento"].Value.ToString();
            this.Visible = false;
        }

        private void dgbuscarFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
