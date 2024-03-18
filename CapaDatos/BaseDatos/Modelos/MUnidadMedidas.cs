using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos.Modelos
{
    public class MUnidadMedidas
    {
        [Key]
        public int UnidadMedidaId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Codigo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Descripción { get; set; }
        public bool Estado { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
