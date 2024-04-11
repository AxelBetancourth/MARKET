using CapaDatos.BaseDatos.Modelos;
using CapaDatos;
using CapaNegocio.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NFacturaDetalle
    {
        private DFacturaDetalle dfacturadetalle;

        public NFacturaDetalle()
        {
            dfacturadetalle = new DFacturaDetalle();
        }

        public List<MFacturaDetalle> TodosDetallesFacturas()
        {
            return dfacturadetalle.TodasLasFacturas();
        }
        public int AgregarFacturaDetalle(MFacturaDetalle Facturas)
        {
            Facturas.FechaCreacion = DateTime.Now;
            return dfacturadetalle.Guardar(Facturas);
        }
        public int EditarFacturaDetalle(MFacturaDetalle Facturas)
        {

            return dfacturadetalle.Guardar(Facturas);
        }

        public int Eliminar(int FacturadetalleId)
        {
            return dfacturadetalle.Eliminar(FacturadetalleId);
        }
        public List<object> obtenerFacturaDetalleGrid()
        {
            var facturadetalle = dfacturadetalle.TodasLasFacturas().Select(c => new
            {
                c.FacturaDetalleId,
                c.FacturaId,
                c.ProductoId,
                CreacionPedido = c.FechaCreacion,
                c.Precio,
                c.Total,
                c.SubTotal,
                c.Descuento
            });
            return facturadetalle.Cast<object>().ToList();
        }
        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var factura = TodosDetallesFacturas().Select(c => new
            {
                c.FacturaId,

            })
                                      .ToList();
            foreach (var item in factura)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.FacturaId,
                });
            }
            return Datos;
        }
    }
}
