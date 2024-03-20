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
    class DClientes
    {
        Repository<MClientes> _repository;

        public DClientes()
        {
            _repository = new Repository<MClientes>();
        }
        [Key]
        public int ClienteID { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int GrupoDescuentoId { get; set; }
        public int CodigoPagoId { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<MClientes> ClientesTodos()
        {
            return _repository.Consulta().ToList();
        }

        public int GuardarClientes(MClientes Cliente)
        {
            if (Cliente.ClienteID == 0)
            {
                Cliente.FechaCreacion = DateTime.Now;
                _repository.Agregar(Cliente);
                return 1;
            }
            else
            {
                var ClienteInDb = _repository.Consulta().FirstOrDefault(c => c.ClienteID == Cliente.ClienteID);

                if (ClienteInDb != null)
                {
                    ClienteInDb.Codigo = Cliente.Codigo;
                    ClienteInDb.Nombres = Cliente.Nombres;
                    ClienteInDb.Apellidos = Cliente.Apellidos;
                    ClienteInDb.GrupoDescuentoId = Cliente.GrupoDescuentoId;
                    ClienteInDb.CodigoPagoId = Cliente.CodigoPagoId;
                    ClienteInDb.Estado = Cliente.Estado;
                    _repository.Editar(ClienteInDb);
                    return 1;
                }
                return 0;
            }

        }

        public int EliminarCategoria(int ClienteID)
        {
            var ClienteInDb = _repository.Consulta().FirstOrDefault(c => c.ClienteID == ClienteID);
            if (ClienteInDb != null)
            {
                _repository.Eliminar(ClienteInDb);
                return 1;
            }
            return 0;
        }
    }
}
