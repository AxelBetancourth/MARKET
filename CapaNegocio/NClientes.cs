using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
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

        public NClientes()
        {
            dClientes = new DClientes();
        }

        public List<MClientes> ClientesTodos()
        {
            return dClientes.ClientesTodos();
        }
        public List<MClientes> ClientesActivos()
        {
            return dClientes.ClientesTodos().Where(c => c.Estado == true).ToList();
        }
       
        public int GuardarClientes(MClientes clientes)
        {
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

       
}
  
}
