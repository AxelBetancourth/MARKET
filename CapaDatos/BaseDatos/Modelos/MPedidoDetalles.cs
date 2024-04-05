using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos.Modelos
{
    public class MPedidoDetalles
    {

        [Key]
        public int PedidoDetalleId { get; set; }
        public int PedidoID { get; set; }
        public MPedidos MPedidos { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int ProductoId { get; set; }
        public MProductos MProductos { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public decimal SubTotal { get; set;}
        [Required]
        public decimal Descuento { get; set; }
    }
}
