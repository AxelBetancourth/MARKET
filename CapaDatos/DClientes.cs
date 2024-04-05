using CapaDatos.BaseDatos;
using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DClientes
    {
        UnitOfWork _unitOfWork;

        public DClientes()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int ClienteID { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int GrupoDescuentoId { get; set; }
        public int CodigoPagoId { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<MClientes> TodosLosClientes()
        {
            return _unitOfWork.Repository<MClientes>().Consulta().Include(c=> c.MGrupoDescuentos)
                                         .Include(c=> c.MCondicionPagos)
                                         .ToList();
        }

        public int GuardarClientes(MClientes Cliente)
        {
            if (Cliente.ClienteID == 0)
            {
                _unitOfWork.Repository<MClientes>().Agregar(Cliente);
                return _unitOfWork.Guardar();
            }
            else
            {
                var ClienteInDb = _unitOfWork.Repository<MClientes>().Consulta().FirstOrDefault(c => c.ClienteID == Cliente.ClienteID);

                if (ClienteInDb != null)
                {
                    ClienteInDb.Codigo = Cliente.Codigo;
                    ClienteInDb.Nombres = Cliente.Nombres;
                    ClienteInDb.Apellidos = Cliente.Apellidos;
                    ClienteInDb.GrupoDescuentoId = Cliente.GrupoDescuentoId;
                    ClienteInDb.CodigoPagoId = Cliente.CodigoPagoId;
                    ClienteInDb.Estado = Cliente.Estado;
                    _unitOfWork.Repository<MClientes>().Editar(ClienteInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }

        }

        public int EliminarCliente(int ClienteID)
        {
            var ClienteInDb = _unitOfWork.Repository<MClientes>().Consulta().FirstOrDefault(c => c.ClienteID == ClienteID);
            if (ClienteInDb != null)
            {
                _unitOfWork.Repository<MClientes>().Eliminar(ClienteInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
