using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DProductos
    {

        Repository<MProductos> _repository;

        public DProductos()
        {
            _repository = new Repository<MProductos>();
        }

        public int ProductoId { get; set; }
        public int Categoriaid { get; set; }
        public int UnidadMedidaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public decimal PrecioCompra { get; set; }

        public int Guardar(MProductos producto)
        {
            if (producto.ProductoId == 0)
            {
                producto.FechaCreacion = DateTime.Now;
                _repository.Agregar(producto);
                return 1;
            }
            else
            {
                var productoInDb = _repository.Consulta().FirstOrDefault(c => c.ProductoId == producto.ProductoId);
                if (productoInDb != null)
                {
                    productoInDb.Categoriaid = producto.Categoriaid;
                    productoInDb.UnidadMedidaId = producto.UnidadMedidaId;
                    producto.FechaCreacion = productoInDb.FechaCreacion;
                    productoInDb.Estado = producto.Estado;
                    productoInDb.PrecioCompra = producto.PrecioCompra;
                    _repository.Editar(productoInDb);
                    return 1;
                }

                return 0;
            }
        }

        public List<MProductos> TodosLosProductos()
        {
            return _repository.Consulta().Include(c => c.MCategorias)
                                         .Include(c => c.MUnidadMedidas)
                                         .ToList();
        }

        public int Eliminar(int ProductoId)
        {
            var productoInDb = _repository.Consulta().FirstOrDefault(c => c.ProductoId == ProductoId);
            if (productoInDb != null)
            {
                _repository.Eliminar(productoInDb);
                return 1;
            }
            return 0;
        }
    }
}