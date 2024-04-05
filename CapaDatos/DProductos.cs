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
        UnitOfWork _unitOfWork;

        public DProductos()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int ProductoId { get; set; }
        public int Categoriaid { get; set; }
        public int UnidadMedidaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public decimal PrecioCompra { get; set; }

        public List<MProductos> TodosLosProductos()
        {
            return _unitOfWork.Repository<MProductos>().Consulta().Include(c => c.MCategorias)
                                         .Include(c => c.MUnidadMedidas)
                                         .ToList();
        }
        public int Guardar(MProductos producto)
        {
            if (producto.ProductoId == 0)
            {
                _unitOfWork.Repository<MProductos>().Agregar(producto);
                return _unitOfWork.Guardar();
            }
            else
            {
                var productoInDb = _unitOfWork.Repository<MProductos>().Consulta().FirstOrDefault(c => c.ProductoId == producto.ProductoId);
                if (productoInDb != null)
                {
                    productoInDb.CategoriaId = producto.CategoriaId;
                    productoInDb.UnidadMedidaId = producto.UnidadMedidaId;
                    producto.FechaCreacion = productoInDb.FechaCreacion;
                    productoInDb.Estado = producto.Estado;
                    productoInDb.PrecioCompra = producto.PrecioCompra;
                    _unitOfWork.Repository<MProductos>().Editar(productoInDb);
                    return _unitOfWork.Guardar();
                }

                return 0;
            }
        }

        public int Eliminar(int ProductoId)
        {
            var productoInDb = _unitOfWork.Repository<MProductos>().Consulta().FirstOrDefault(c => c.ProductoId == ProductoId);
            if (productoInDb != null)
            {
                _unitOfWork.Repository<MProductos>().Eliminar(productoInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}