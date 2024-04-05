using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
    }
}
