using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;

namespace CapaDatos
{
    public class DFacturaDetalle
    {
        UnitOfWork _unitOfWork;

        public DFacturaDetalle()
        {

            _unitOfWork = new UnitOfWork();
        }
        public int FacturaDetalleId { get; set; }
        public int FacturaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }


        public List<MFacturaDetalle> TodasLasFacturas()
        {
            return _unitOfWork.Repository<MFacturaDetalle>().Consulta().Include(c => c.MFacturas)
                                         .Include(c => c.MProductos)
                                         .ToList();
        }
        public int Guardar(MFacturaDetalle factura)
        {
            if (factura.FacturaDetalleId == 0)
            {
                _unitOfWork.Repository<MFacturaDetalle>().Agregar(factura);
                return _unitOfWork.Guardar();
            }
            else
            {
                var facturaInDb = _unitOfWork.Repository<MFacturaDetalle>().Consulta().FirstOrDefault(c => c.FacturaDetalleId == factura.FacturaDetalleId);
                if (facturaInDb != null)
                {
                    facturaInDb.FacturaId = factura.FacturaId;
                    facturaInDb.ProductoId = factura.ProductoId;
                    facturaInDb.Precio = factura.Precio;
                    facturaInDb.Total = factura.Total;
                    facturaInDb.SubTotal = factura.SubTotal;
                    facturaInDb.Descuento = factura.Descuento;
                    _unitOfWork.Repository<MFacturaDetalle>().Editar(facturaInDb);
                    return _unitOfWork.Guardar();
                }

                return 0;
            }
        }

        public int Eliminar(int facturaId)
        {
            var facturaInDb = _unitOfWork.Repository<MFacturaDetalle>().Consulta().FirstOrDefault(c => c.FacturaDetalleId == facturaId);
            if (facturaInDb != null)
            {
                _unitOfWork.Repository<MFacturaDetalle>().Eliminar(facturaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
