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
    public class DGrupoDescuentos
    {
        UnitOfWork _unitOfWork;
        public DGrupoDescuentos()
        {
            _unitOfWork = new UnitOfWork();
        }
        public int GrupoDescuentoId { get; set; }
        public string Codigo { get; set; }
        public string Descripción { get; set; }
        public bool Estado { get; set; }
        public int Porcentaje { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<MGrupoDescuentos> GDescuentosTodas()
        {
            return _unitOfWork.Repository<MGrupoDescuentos>().Consulta().ToList();
        }

        public int GuardarDescuentos(MGrupoDescuentos grupoDescuentos)
        {
            if (grupoDescuentos.GrupoDescuentoId == 0)
            {
                _unitOfWork.Repository<MGrupoDescuentos>().Agregar(grupoDescuentos);
                return _unitOfWork.Guardar();
            }
            else
            {
                var GrupoDescuentosInDb = _unitOfWork.Repository<MGrupoDescuentos>().Consulta().FirstOrDefault(c => c.GrupoDescuentoId == grupoDescuentos.GrupoDescuentoId);

                if (GrupoDescuentosInDb != null)
                {
                    GrupoDescuentosInDb.Codigo = grupoDescuentos.Codigo;
                    GrupoDescuentosInDb.Descripción = grupoDescuentos.Descripción;
                    GrupoDescuentosInDb.Estado = grupoDescuentos.Estado;
                    GrupoDescuentosInDb.Porcentaje = grupoDescuentos.Porcentaje;
                    _unitOfWork.Repository<MGrupoDescuentos>().Editar(GrupoDescuentosInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }

        }
        public int EliminarDescuentos(int grupoDescuentosId)
        {
            var GrupoDescuentosInDb = _unitOfWork.Repository<MGrupoDescuentos>().Consulta().FirstOrDefault(c => c.GrupoDescuentoId == grupoDescuentosId);
            if (GrupoDescuentosInDb != null)
            {
                _unitOfWork.Repository<MGrupoDescuentos>().Eliminar(GrupoDescuentosInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
