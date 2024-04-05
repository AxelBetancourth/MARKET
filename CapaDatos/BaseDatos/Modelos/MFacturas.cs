using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos.Modelos
{
    public class MFacturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteID { get; set; }
        public MClientes MClientes { get; set; }
        public int PedidoID { get; set; }
        public MPedidos MPedidos { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set;}
        [Required]
        public DateTime FechaFactura { get; set; }
        public bool Estado { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal Descuento { get; set; }
    }
}
