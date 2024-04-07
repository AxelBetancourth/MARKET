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
    public class DFacturas
    {
        UnitOfWork _unitOfWork;

        public DFacturas()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int FacturaId { get; set; }
        public int ClienteID { get; set; }
        public int PedidoID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFactura { get; set; }
        public bool Estado { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }


        public List<MFacturas> TodosLasFacturas()
        {
            return _unitOfWork.Repository<MFacturas>().Consulta().Include(c => c.MClientes)
                                         .Include(c => c.MPedidos)
                                         .ToList();
        }
        public int Guardar(MFacturas facturas)
        {
            if (facturas.FacturaId == 0)
            {
                _unitOfWork.Repository<MFacturas>().Agregar(facturas);
                return _unitOfWork.Guardar();
            }
            else
            {
                var facturaInDb = _unitOfWork.Repository<MFacturas>().Consulta().FirstOrDefault(c => c.FacturaId == facturas.FacturaId);
                if (facturaInDb != null)
                {
                    facturaInDb.ClienteID = facturas.ClienteID;
                    facturaInDb.PedidoID = facturas.PedidoID;
                    facturas.FechaFactura = facturaInDb.FechaFactura;
                    facturaInDb.Estado = facturas.Estado;
                    facturaInDb.Total = facturas.Total;
                    facturaInDb.SubTotal = facturas.SubTotal;
                    facturaInDb.Descuento = facturas.Descuento;
                    _unitOfWork.Repository<MFacturas>().Editar(facturaInDb);
                    return _unitOfWork.Guardar();
                }

                return 0;
            }
        }
        public int Eliminar(int FacturaId)
        {
            var facturaInDb = _unitOfWork.Repository<MFacturas>().Consulta().FirstOrDefault(c => c.FacturaId == FacturaId);
            if (facturaInDb != null)
            {
                _unitOfWork.Repository<MFacturas>().Eliminar(facturaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
