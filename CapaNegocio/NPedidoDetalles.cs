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
    public class NPedidoDetalles
    {
        private DPedidoDetalles dpedidodetalles;

        public NPedidoDetalles()
        {
            dpedidodetalles = new DPedidoDetalles();
        }

        public List<MPedidoDetalles> TodosDetallesPedidos()
        {
            return dpedidodetalles.TodosLosPedidos();
        }
        public int AgregarPedidoDetalles(MPedidoDetalles Pedidos)
        {
            Pedidos.FechaCreacion = DateTime.Now;
            return dpedidodetalles.Guardar(Pedidos);
        }
        public int EditarPedidoDetalle(MPedidoDetalles Pedidos)
        {

            return dpedidodetalles.Guardar(Pedidos);
        }

        public int Eliminar(int PedidodetalleId)
        {
            return dpedidodetalles.Eliminar(PedidodetalleId);
        }
        public List<object> obtenerPedidosDetalleGrid()
        {
            var pedidodetalles = dpedidodetalles.TodosLosPedidos().Select(c => new
            {
                c.PedidoDetalleId,
                c.PedidoID,
                c.ProductoId,
                CreacionPedido = c.FechaCreacion,
                c.Precio,
                c.Total,
                c.SubTotal,
                c.Descuento
            });
            return pedidodetalles.Cast<object>().ToList();
        }
        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var pedidos = TodosDetallesPedidos().Select(c => new
            {
                c.PedidoID,

            }).ToList();
            foreach (var item in pedidos)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.PedidoID,
                });
            }
            return Datos;
        }
    }
}
