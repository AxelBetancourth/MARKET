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
    }
}
