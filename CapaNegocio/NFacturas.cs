using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using CapaNegocio.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NFacturas
    {
        private DFacturas dFacturas;
        private MClientes mClientes;
        private MPedidos mPedidos;

        public NFacturas()
        {
            dFacturas = new DFacturas();
            mClientes = new MClientes();
            mPedidos = new MPedidos();
        }

        public List<MFacturas> TodasFacturas()
        {
            return dFacturas.TodosLasFacturas();
        }
        public int AgregarFacturas(MFacturas Facturas)
        {
            Facturas.FechaCreacion = DateTime.Now;
            return dFacturas.Guardar(Facturas);
        }
        public int EditarFacturas(MFacturas Facturas)
        {
            return dFacturas.Guardar(Facturas);
        }

        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var Facturas = TodasFacturas().Select(c => new
            {
                c.FacturaId,
                c.FechaFactura
            }).ToList();
            foreach (var item in Facturas)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.FacturaId,
                    Descripcion = item.FechaFactura.ToString("yyyy-MM-dd HH:mm:ss")
                });
            }
            return Datos;
        }
        public int Eliminar(int PedidosID)
        {
            return dFacturas.Eliminar(PedidosID);
        }
        public List<object> obtenerFacturasGrid()
        {
            var pedidos = dFacturas.TodosLasFacturas().Select(c => new {
                c.FacturaId,
                ClienteNombreCompleto = c.MClientes.Nombres + " " + c.MClientes.Apellidos,
                c.PedidoID,
                PedidoInfo = $"{c.MPedidos.PedidoID} - {c.MPedidos.FechaPedido}",
                c.Estado,
                c.FechaCreacion,
                c.FechaFactura,
                c.Total,
                c.SubTotal,
                c.Descuento
            });
            return pedidos.Cast<object>().ToList();
        }

        public List<object> obtenerFacturasActivasGrid()
        {
            var pedidos = dFacturas.TodosLasFacturas().Select(c => new {
                c.FacturaId,
                ClienteNombreCompleto = c.MClientes.Nombres + " " + c.MClientes.Apellidos,
                c.PedidoID,
                PedidoInfo = $"{c.MPedidos.PedidoID} - {c.MPedidos.FechaPedido}",
                c.Estado,
                c.FechaCreacion,
                c.FechaFactura,
                c.Total,
                c.SubTotal,
                c.Descuento
            });
            return pedidos.Where(c => c.Estado == true).Cast<object>().ToList();
        }
    }
}
