using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPedidoDetalles
    {

        UnitOfWork _unitOfWork;

        public DPedidoDetalles()
        {

            _unitOfWork = new UnitOfWork();
        }
        public int PedidoDetalleId { get; set; }
        public int PedidoID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }


        public List<MPedidoDetalles> TodosLosPedidos()
        {
            return _unitOfWork.Repository<MPedidoDetalles>().Consulta().Include(c => c.MPedidos)
                                         .Include(c => c.MProductos)
                                         .ToList();
        }
        public int Guardar(MPedidoDetalles pedido)
        {
            if (pedido.PedidoDetalleId == 0)
            {
                _unitOfWork.Repository<MPedidoDetalles>().Agregar(pedido);
                return _unitOfWork.Guardar();
            }
            else
            {
                var pedidoInDb = _unitOfWork.Repository<MPedidoDetalles>().Consulta().FirstOrDefault(c => c.PedidoDetalleId == pedido.PedidoDetalleId);
                if (pedidoInDb != null)
                {
                    pedidoInDb.PedidoID = pedido.PedidoID;
                    pedidoInDb.ProductoId = pedido.ProductoId;
                    pedidoInDb.FechaCreacion = pedido.FechaCreacion;
                    pedidoInDb.Precio = pedido.Precio;
                    pedidoInDb.Total = pedido.Total;
                    pedidoInDb.SubTotal = pedido.SubTotal;
                    pedidoInDb.Descuento = pedido.Descuento;
                    _unitOfWork.Repository<MPedidoDetalles>().Editar(pedidoInDb);
                    return _unitOfWork.Guardar();
                }

                return 0;
            }
        }

        public int Eliminar(int pedidoId)
        {
            var pedidoInDb = _unitOfWork.Repository<MPedidoDetalles>().Consulta().FirstOrDefault(c => c.PedidoDetalleId == pedidoId);
            if (pedidoInDb != null)
            {
                _unitOfWork.Repository<MPedidoDetalles>().Eliminar(pedidoInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}

