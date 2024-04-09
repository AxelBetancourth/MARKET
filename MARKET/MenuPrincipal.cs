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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void condiciónDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PGrupoDescuentos descuentos= new PGrupoDescuentos();
            descuentos.MdiParent = this;
            descuentos.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void unidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCategorias categoria = new PCategorias();
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void condiciónDePagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PCondicionPagos condicionPagos = new PCondicionPagos();
            condicionPagos.MdiParent = this;
            condicionPagos.Show();
        }

        private void unidadDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PUnidadMedidas unidadMedidas = new PUnidadMedidas();
            unidadMedidas.MdiParent = this;
            unidadMedidas.Show();
        }

        private void grupoDeDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PProductos Productos = new PProductos();
            Productos.MdiParent = this;
            Productos.Show();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PFacturas Facturas = new PFacturas();
            Facturas.MdiParent = this;
            Facturas.Show();
        }

        private void grupoDeDescuentosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PClientes Clientes = new PClientes();
            Clientes.MdiParent = this;
            Clientes.Show();
        }

        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PPedidos Pedidos = new PPedidos();
            Pedidos.MdiParent = this;
            Pedidos.Show();
        }
    }
    
}
