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
    public class DCondicionPagos
    {
        UnitOfWork _unitOfWork;
        public DCondicionPagos()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int CodigoPagoId { get; set; }
        public string Codigo { get; set; }
        public string Descripción { get; set; }
        public bool Estado { get; set; }
        public int Dias { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<MCondicionPagos> CondicionesTodas()
        {
            return _unitOfWork.Repository<MCondicionPagos>().Consulta().ToList();
        }

        public int GuardarUnidades(MCondicionPagos condicionPagos)
        {
            if (condicionPagos.CodigoPagoId == 0)
            {
                _unitOfWork.Repository<MCondicionPagos>().Agregar(condicionPagos);
                return _unitOfWork.Guardar();
            }
            else
            {
                var CondicionPagosInDb = _unitOfWork.Repository<MCondicionPagos>().Consulta().FirstOrDefault(c => c.CodigoPagoId == condicionPagos.CodigoPagoId);

                if (CondicionPagosInDb != null)
                {
                    CondicionPagosInDb.Codigo = condicionPagos.Codigo;
                    CondicionPagosInDb.Descripción = condicionPagos.Descripción;
                    CondicionPagosInDb.Estado = condicionPagos.Estado;
                    CondicionPagosInDb.Dias = condicionPagos.Dias;
                    _unitOfWork.Repository<MCondicionPagos>().Editar(CondicionPagosInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }

        }
        public int EliminarCondiciones(int codigoPagoId)
        {
            var CondicionPagosInDb = _unitOfWork.Repository<MCondicionPagos>().Consulta().FirstOrDefault(c => c.CodigoPagoId == codigoPagoId);
            if (CondicionPagosInDb != null)
            {
                _unitOfWork.Repository<MCondicionPagos>().Eliminar(CondicionPagosInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

    }
}


            


        







