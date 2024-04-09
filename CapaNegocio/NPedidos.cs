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
    public class NPedidos
    {
        private DPedidos dPedidos;
        public NPedidos()
        {
            dPedidos = new DPedidos();
        }

        public List<MPedidos> TodosPedidos()
        {
            return dPedidos.TodosLosPedidos();
        }
        public int AgregarPedidos(MPedidos Pedidos)
        {
            Pedidos.FechaCreacion = DateTime.Now;
            return dPedidos.Guardar(Pedidos);
        }
        public int EditarPedidos(MPedidos Pedidos)
        {
            return dPedidos.Guardar(Pedidos);
        }

        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var Pedidos = TodosPedidos().Select(c => new
            {
                c.PedidoID,
                c.FechaPedido
            }).ToList();
            foreach (var item in Pedidos)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.PedidoID,
                    //Descripcion = item.FechaPedido.ToString("yyyy-MM-dd HH:mm:ss")
                    Descripcion = $"{item.PedidoID} - {item.FechaPedido.ToString("yyyy-MM-dd HH:mm:ss")}"
                });
            }

            return Datos;
        }
        public int Eliminar(int PedidosID)
        {
            return dPedidos.Eliminar(PedidosID);
        }
        public List<object> obtenerPedidosGrid()
        {
            var pedidos = dPedidos.TodosLosPedidos().Select(c => new {
                c.PedidoID,
                ClienteNombreCompleto = c.MClientes.Nombres + " " + c.MClientes.Apellidos,
                c.Estado,
                c.FechaCreacion,
                c.FechaPedido,
                c.Total,
                c.SubTotal,
                c.Descuento
            });
            return pedidos.Cast<object>().ToList();
        }

        public List<object> obtenerPedidosActivosGrid()
        {
            var pedidos = dPedidos.TodosLosPedidos().Select(c => new {
                c.PedidoID,
                ClienteNombreCompleto = c.MClientes.Nombres + " " + c.MClientes.Apellidos,
                c.Estado,
                c.FechaCreacion,
                c.FechaPedido,
                c.Total,
                c.SubTotal,
                c.Descuento
            });
            return pedidos.Where(c => c.Estado == true).Cast<object>().ToList();
        }
        public List<object> BuscarPedidosGrid()
        {
            var pedidos = dPedidos.TodosLosPedidos().Select(c => new {
                c.PedidoID,
                ClientesNombres = c.MClientes.Nombres,
                ClientesApellidos = c.MClientes.Apellidos,
                c.Estado,
                c.Total,
                c.SubTotal,
                c.Descuento
            });
            return pedidos.Cast<object>().ToList();
        }
        public List<object> BuscarPedidosactivosGrid()
        {
            var pedidos = dPedidos.TodosLosPedidos().Select(c => new {
                c.PedidoID,
                ClientesNombres = c.MClientes.Nombres,
                ClientesApellidos = c.MClientes.Apellidos,
                c.Estado,
                c.Total,
                c.SubTotal,
                c.Descuento
            });
            return pedidos.Where(c => c.Estado == true).Cast<object>().ToList();
        }

    }
}
