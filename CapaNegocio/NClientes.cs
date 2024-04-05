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
   public class NClientes
    {
        private DClientes dClientes;
        private MGrupoDescuentos mgrupoDescuentos;
        private MCondicionPagos mCondicionPagos;

        public NClientes()
        {
            dClientes = new DClientes();
            mgrupoDescuentos = new MGrupoDescuentos();
            mCondicionPagos = new MCondicionPagos();
        }

        public List<MClientes> TodosClientes()
        {
            return dClientes.TodosLosClientes();
        }

        public List<object> obtenerClientesActivosGrid()
        {
            var clientes = dClientes.TodosLosClientes().Select(c => new {
                c.ClienteID,
                c.Codigo,
                c.Nombres,
                c.Apellidos,
                DescuentosCodigo = c.MGrupoDescuentos.Codigo,
                PagoCodigo = c.MCondicionPagos.Codigo,
                c.Estado,
                c.FechaCreacion
            });
            return clientes.Where(c => c.Estado == true).Cast<object>().ToList();
        }
        public int GuardarClientes(MClientes clientes)
        {
            clientes.FechaCreacion = DateTime.Now;
            return dClientes.GuardarClientes(clientes);
        }
        public int EditarClientes(MClientes clientes)
        {
            return dClientes.GuardarClientes(clientes);
        }
        public int EliminarCliente(int ClienteID)
        {
            return dClientes.EliminarCliente(ClienteID);
        }
        public List<object> obtenerGridClientes()
        {
            var clientes = dClientes.TodosLosClientes().Select(c => new {
                c.ClienteID,
                c.Codigo,
                c.Nombres,
                c.Apellidos,
                DescuentosCodigo = c.MGrupoDescuentos.Codigo,
                PagoCodigo = c.MCondicionPagos.Codigo,
                c.Estado,
                c.FechaCreacion
            });
            return clientes.Cast<object>().ToList();
        }
    }
  
}
