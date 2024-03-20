﻿using CapaDatos.BaseDatos.Modelos;
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
        Repository<MGrupoDescuentos> _repository;

        public DGrupoDescuentos()
        {
            _repository = new Repository<MGrupoDescuentos>();
        }

        public int GrupoDescuentoId { get; set; }
        public string Codigo { get; set; }
        public string Descripción { get; set; }
        public bool Estado { get; set; }
        public int Porcentaje { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<MGrupoDescuentos> GDescuentosTodas()
        {
            return _repository.Consulta().ToList();
        }

        public int GuardarDescuentos(MGrupoDescuentos grupoDescuentos)
        {
            if (grupoDescuentos.GrupoDescuentoId == 0)
            {
                grupoDescuentos.FechaCreacion = DateTime.Now;
                _repository.Agregar(grupoDescuentos);
                return 1;
            }
            else
            {
                var GrupoDescuentosInDb = _repository.Consulta().FirstOrDefault(c => c.GrupoDescuentoId == grupoDescuentos.GrupoDescuentoId);

                if (GrupoDescuentosInDb != null)
                {
                    GrupoDescuentosInDb.Codigo = grupoDescuentos.Codigo;
                    GrupoDescuentosInDb.Descripción = grupoDescuentos.Descripción;
                    GrupoDescuentosInDb.Estado = grupoDescuentos.Estado;
                    GrupoDescuentosInDb.Porcentaje = grupoDescuentos.Porcentaje;
                    _repository.Editar(GrupoDescuentosInDb);
                    return 1;
                }
                return 0;
            }

        }
        public int EliminarDescuentos(int grupoDescuentosId)
        {
            var GrupoDescuentosInDb = _repository.Consulta().FirstOrDefault(c => c.GrupoDescuentoId == grupoDescuentosId);
            if (GrupoDescuentosInDb != null)
            {
                _repository.Eliminar(GrupoDescuentosInDb);
                return 1;
            }
            return 0;
        }
    }
}
