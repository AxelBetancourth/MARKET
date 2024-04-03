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
        UnitOfWork _unitOfWork;

        public DUnidadMedidas()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int UnidadMedidaId { get; set; }
        public string Codigo { get; set; }
        public string Descripción { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<MUnidadMedidas> UnidadesTodas()
        {
            return _unitOfWork.Repository<MUnidadMedidas>().Consulta().ToList();
        }

        public int GuardarUnidades(MUnidadMedidas unidadMedidas)
        {
            if (unidadMedidas.UnidadMedidaId == 0)
            {
                _unitOfWork.Repository<MUnidadMedidas>().Agregar(unidadMedidas);
                return _unitOfWork.Guardar();
            }
            else
            {
                var UnidadMedidasInDb = _unitOfWork.Repository<MUnidadMedidas>().Consulta().FirstOrDefault(c => c.UnidadMedidaId == unidadMedidas.UnidadMedidaId);

                if (UnidadMedidasInDb != null)
                {
                    UnidadMedidasInDb.Codigo = unidadMedidas.Codigo;
                    UnidadMedidasInDb.Descripción = unidadMedidas.Descripción;
                    UnidadMedidasInDb.Estado = unidadMedidas.Estado;
                    _unitOfWork.Repository<MUnidadMedidas>().Editar(UnidadMedidasInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }

        }
        public int EliminarUnidades(int unidadMedidaId)
        {
            var UnidadMedidasInDb = _unitOfWork.Repository<MUnidadMedidas>().Consulta().FirstOrDefault(c => c.UnidadMedidaId == unidadMedidaId);
            if (UnidadMedidasInDb != null)
            {
                _unitOfWork.Repository<MUnidadMedidas>().Eliminar(UnidadMedidasInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }


    }
}
