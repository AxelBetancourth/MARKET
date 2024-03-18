using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos.Modelos
{
    public class MProductos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required]
        public int Categoriaid { get; set; }
        public MCategorias MCategotias { get; set; }
        public int UnidadMedidaId { get; set; }
        public MUnidadMedidas MUnidadMedidas { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        [Required]
        public decimal PrecioCompra { get; set; }
    }
}
