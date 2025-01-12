﻿using System;
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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        //Clientes
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PClientes Clientes = new PClientes();
            Clientes.MdiParent = this;
            Clientes.Show();
        }
        private void grupoDeDescuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PGrupoDescuentos descuentos = new PGrupoDescuentos();
            descuentos.MdiParent = this;
            descuentos.Show();
        }
        private void condicionDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCondicionPagos condicionPagos = new PCondicionPagos();
            condicionPagos.MdiParent = this;
            condicionPagos.Show();
        }

        //Productos
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PProductos Productos = new PProductos();
            Productos.MdiParent = this;
            Productos.Show();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PCategorias categoria = new PCategorias();
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void unidadDeMedidaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PUnidadMedidas unidadMedidas = new PUnidadMedidas();
            unidadMedidas.MdiParent = this;
            unidadMedidas.Show();
        }

        //Pedidos
        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PPedidos Pedidos = new PPedidos();
            Pedidos.MdiParent = this;
            Pedidos.Show();
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PPedidoDetalles Pedido = new PPedidoDetalles();
            Pedido.MdiParent = this;
            Pedido.Show();
        }

        //Facturas
        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PFacturas Facturas = new PFacturas();
            Facturas.MdiParent = this;
            Facturas.Show();
        }

        private void detallesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PFacturaDetalles Factura = new PFacturaDetalles();
            Factura.MdiParent = this;
            Factura.Show();
        }
    }
    
}
