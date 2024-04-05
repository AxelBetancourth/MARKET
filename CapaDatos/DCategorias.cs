using CapaDatos.BaseDatos;
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
    public class DCategorias
    {
        UnitOfWork _unitOfWork;

        public DCategorias()
        {
            _unitOfWork = new UnitOfWork();
        }
        public int CategoriaId { get; set; }
        public string Codigo { get; set; }
        public string Descripción { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<MCategorias> categoriaTodas()
        {
            return _unitOfWork.Repository<MCategorias>().Consulta().ToList();
        }

        public int GuardarCategoria(MCategorias categoria)
        {

            if (categoria.CategoriaId == 0)
            {
                _unitOfWork.Repository<MCategorias>().Agregar(categoria);
                return _unitOfWork.Guardar();
            }
            else
            {
                var CategoriaInDb = _unitOfWork.Repository<MCategorias>().Consulta().FirstOrDefault(c => c.CategoriaId == categoria.CategoriaId);

                if (CategoriaInDb != null)
                {
                    CategoriaInDb.Codigo = categoria.Codigo;
                    CategoriaInDb.Descripción = categoria.Descripción;
                    CategoriaInDb.Estado = categoria.Estado;
                    _unitOfWork.Repository<MCategorias>().Editar(CategoriaInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }

        }

        public int EliminarCategoria(int categoriaId)
        {
            var CategoriaInDb = _unitOfWork.Repository<MCategorias>().Consulta().FirstOrDefault(c => c.CategoriaId == categoriaId);
            if (CategoriaInDb != null)
            {
                _unitOfWork.Repository<MCategorias>().Eliminar(CategoriaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
