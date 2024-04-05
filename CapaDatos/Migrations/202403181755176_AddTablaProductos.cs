namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaProductos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MProductos",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        CategoriaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        PrecioCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductoId)
                .ForeignKey("dbo.MCategorias", t => t.CategoriaId)
                .ForeignKey("dbo.MUnidadMedidas", t => t.UnidadMedidaId)
                .Index(t => t.CategoriaId)
                .Index(t => t.UnidadMedidaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MProductos", "UnidadMedidaId", "dbo.MUnidadMedidas");
            DropForeignKey("dbo.MProductos", "Categoriaid", "dbo.MCategorias");
            DropIndex("dbo.MProductos", new[] { "UnidadMedidaId" });
            DropIndex("dbo.MProductos", new[] { "Categoriaid" });
            DropTable("dbo.MProductos");
        }
    }
}
