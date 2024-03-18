using CapaDatos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos
{
    public class MarketContext:DbContext
    {
        public MarketContext():base("Market")
        {
            
        }

        public DbSet<MCategorias> MCategorias { get; set; }
        public DbSet<MGrupoDescuentos> MGrupoDescuentos { get; set; }
        public DbSet<MUnidadMedidas> MUnidadMedidas { get; set; }

    }
}
