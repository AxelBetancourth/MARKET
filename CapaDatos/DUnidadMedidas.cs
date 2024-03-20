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
    public class DUnidadMedidas
    {
        Repository<MUnidadMedidas> _repository;

        public DUnidadMedidas()
        {
            _repository = new Repository<MUnidadMedidas>();
        }

        public int UnidadMedidaId { get; set; }
        public string Codigo { get; set; }
        public string Descripción { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<MUnidadMedidas> UnidadesTodas()
        {
            return _repository.Consulta().ToList();
        }

        public int GuardarUnidades(MUnidadMedidas unidadMedidas)
        {
            if (unidadMedidas.UnidadMedidaId == 0)
            {
                unidadMedidas.FechaCreacion = DateTime.Now;
                _repository.Agregar(unidadMedidas);
                return 1;
            }
            else
            {
                var UnidadMedidasInDb = _repository.Consulta().FirstOrDefault(c => c.UnidadMedidaId == unidadMedidas.UnidadMedidaId);

                if (UnidadMedidasInDb != null)
                {
                    UnidadMedidasInDb.Codigo = unidadMedidas.Codigo;
                    UnidadMedidasInDb.Descripción = unidadMedidas.Descripción;
                    UnidadMedidasInDb.Estado = unidadMedidas.Estado;
                    _repository.Editar(UnidadMedidasInDb);
                    return 1;
                }
                return 0;
            }

        }
        public int EliminarUnidades(int unidadMedidaId)
        {
            var UnidadMedidasInDb = _repository.Consulta().FirstOrDefault(c => c.UnidadMedidaId == unidadMedidaId);
            if (UnidadMedidasInDb != null)
            {
                _repository.Eliminar(UnidadMedidasInDb);
                return 1;
            }
            return 0;
        }
    }
}
