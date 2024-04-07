using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPedidos
    {
        UnitOfWork _unitOfWork;

        public DPedidos()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int PedidoID { get; set; }
        public int ClienteID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPedido { get; set; }
        public bool Estado { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }

        public List<MPedidos> TodosLosPedidos()
        {
            return _unitOfWork.Repository<MPedidos>().Consulta().Include(c => c.MClientes)
                                         .ToList();
        }
        public int Guardar(MPedidos pedidos)
        {
            if (pedidos.PedidoID == 0)
            {
                _unitOfWork.Repository<MPedidos>().Agregar(pedidos);
                return _unitOfWork.Guardar();
            }
            else
            {
                var pedidoInDb = _unitOfWork.Repository<MPedidos>().Consulta().FirstOrDefault(c => c.PedidoID == pedidos.PedidoID);
                if (pedidoInDb != null)
                {
                    pedidoInDb.ClienteID = pedidos.ClienteID;
                    pedidos.FechaPedido = pedidoInDb.FechaPedido;
                    pedidoInDb.Estado = pedidos.Estado;
                    pedidoInDb.Total = pedidos.Total;
                    pedidoInDb.SubTotal = pedidos.SubTotal;
                    pedidoInDb.Descuento = pedidos.Descuento;
                    _unitOfWork.Repository<MPedidos>().Editar(pedidoInDb);
                    return _unitOfWork.Guardar();
                }

                return 0;
            }
        }

        public int Eliminar(int PedidoID)
        {
            var pedidoInDb = _unitOfWork.Repository<MPedidos>().Consulta().FirstOrDefault(c => c.PedidoID == PedidoID);
            if (pedidoInDb != null)
            {
                _unitOfWork.Repository<MPedidos>().Eliminar(pedidoInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
