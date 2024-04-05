using CapaDatos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<MCategorias> MCategorias { get; set; }
        public DbSet<MGrupoDescuentos> MGrupoDescuentos { get; set; }
        public DbSet<MUnidadMedidas> MUnidadMedidas { get; set; }
        public DbSet<MProductos> MProductos { get; set; }
        public DbSet<MCondicionPagos> MCondicionPagos { get; set; }
        public DbSet<MClientes> MClientes { get; set; }
        public DbSet<MPedidos> MPedidos { get; set; }
        public DbSet<MPedidoDetalles> MPedidoDetalles { get; set; }

    }
}
