using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos.Modelos
{
    public class MClientes
    {
        [Key]
        public int ClienteID { get; set; }
        [Required]
        [MaxLength(15)]
        public string Codigo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombres { get; set; }
        [Required]
        [MaxLength(50)]
        public string Apellidos { get; set; }
        public int GrupoDescuentoId { get; set; }
        public MGrupoDescuentos MGrupoDescuentos { get; set; }
        public int CodigoPagoId { get; set; }
        public MCondicionPagos MCondicionPagos { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}