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
        Repository<MCategorias> _repository;

        public DCategorias()
        {
            _repository = new Repository<MCategorias>();
        }
        public int CategoriaId { get; set; }
        public string Codigo { get; set; }
        public string Descripción { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<MCategorias> categoriaTodas()
        {
            return _repository.Consulta().ToList();
        }

        public int GuardarCategoria(MCategorias categoria)
        {
            if (categoria.CategoriaId == 0)
            {
                categoria.FechaCreacion = DateTime.Now;
                _repository.Agregar(categoria);
                return 1;
            }
            else
            {
                var CategoriaInDb = _repository.Consulta().FirstOrDefault(c => c.CategoriaId == categoria.CategoriaId);

                if (CategoriaInDb != null)
                {
                    CategoriaInDb.Codigo = categoria.Codigo;
                    CategoriaInDb.Descripción = categoria.Descripción;
                    CategoriaInDb.Estado = categoria.Estado;
                    _repository.Editar(CategoriaInDb);
                    return 1;
                }
                return 0;
            }

        }

        public int EliminarCategoria(int categoriaId)
        {
            var CategoriaInDb = _repository.Consulta().FirstOrDefault(c => c.CategoriaId == categoriaId);
            if (CategoriaInDb != null)
            {
                _repository.Eliminar(CategoriaInDb);
                return 1;
            }
            return 0;
        }
    }
}
