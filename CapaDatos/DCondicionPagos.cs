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
        Repository<MCondicionPagos> _repository;
        public DCondicionPagos()
        {
            _repository = new Repository<MCondicionPagos>();
        }

        public int CodigoPagoId { get; set; }
        public string Codigo { get; set; }
        public string Descripción { get; set; }
        public bool Estado { get; set; }
        public int Dias { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<MCondicionPagos> CondicionesTodas()
        {
            return _repository.Consulta().ToList();
        }

        public int GuardarUnidades(MCondicionPagos condicionPagos)
        {
            if (condicionPagos.CodigoPagoId == 0)
            {
                condicionPagos.FechaCreacion = DateTime.Now;
                _repository.Agregar(condicionPagos);
                return 1;
            }
            else
            {
                var CondicionPagosInDb = _repository.Consulta().FirstOrDefault(c => c.CodigoPagoId == condicionPagos.CodigoPagoId);

                if (CondicionPagosInDb != null)
                {
                    CondicionPagosInDb.Codigo = condicionPagos.Codigo;
                    CondicionPagosInDb.Descripción = condicionPagos.Descripción;
                    CondicionPagosInDb.Estado = condicionPagos.Estado;
                    _repository.Editar(CondicionPagosInDb);
                    return 1;
                }
                return 0;
            }

        }
        public int EliminarCondiciones(int codigoPagoId)
        {
            var CondicionPagosInDb = _repository.Consulta().FirstOrDefault(c => c.CodigoPagoId == codigoPagoId);
            if (CondicionPagosInDb != null)
            {
                _repository.Eliminar(CondicionPagosInDb);
                return 1;
            }
            return 0;
        }

    }
}


            


        







