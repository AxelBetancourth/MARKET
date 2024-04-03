namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationChangeReglasBaseDatosPermitirDeleteCascada : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MClientes", "CodigoPagoId", "dbo.MCondicionPagos");
            DropForeignKey("dbo.MClientes", "GrupoDescuentoId", "dbo.MGrupoDescuentos");
            DropForeignKey("dbo.MProductos", "UnidadMedidaId", "dbo.MUnidadMedidas");
            DropForeignKey("dbo.MProductos", "Categoriaid", "dbo.MCategorias");
            DropIndex("dbo.MProductos", new[] { "Categoriaid" });
            CreateIndex("dbo.MProductos", "CategoriaId");
            AddForeignKey("dbo.MClientes", "CodigoPagoId", "dbo.MCondicionPagos", "CodigoPagoId", cascadeDelete: true);
            AddForeignKey("dbo.MClientes", "GrupoDescuentoId", "dbo.MGrupoDescuentos", "GrupoDescuentoId", cascadeDelete: true);
            AddForeignKey("dbo.MProductos", "UnidadMedidaId", "dbo.MUnidadMedidas", "UnidadMedidaId", cascadeDelete: true);
            AddForeignKey("dbo.MProductos", "CategoriaId", "dbo.MCategorias", "CategoriaId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MProductos", "CategoriaId", "dbo.MCategorias");
            DropForeignKey("dbo.MProductos", "UnidadMedidaId", "dbo.MUnidadMedidas");
            DropForeignKey("dbo.MClientes", "GrupoDescuentoId", "dbo.MGrupoDescuentos");
            DropForeignKey("dbo.MClientes", "CodigoPagoId", "dbo.MCondicionPagos");
            DropIndex("dbo.MProductos", new[] { "CategoriaId" });
            CreateIndex("dbo.MProductos", "Categoriaid");
            AddForeignKey("dbo.MProductos", "Categoriaid", "dbo.MCategorias", "CategoriaId");
            AddForeignKey("dbo.MProductos", "UnidadMedidaId", "dbo.MUnidadMedidas", "UnidadMedidaId");
            AddForeignKey("dbo.MClientes", "GrupoDescuentoId", "dbo.MGrupoDescuentos", "GrupoDescuentoId");
            AddForeignKey("dbo.MClientes", "CodigoPagoId", "dbo.MCondicionPagos", "CodigoPagoId");
        }
    }
}
