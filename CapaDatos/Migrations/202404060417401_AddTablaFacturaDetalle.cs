namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaFacturaDetalle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MFacturaDetalle",
                c => new
                    {
                        FacturaDetalleId = c.Int(nullable: false, identity: true),
                        FacturaId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.FacturaDetalleId)
                .ForeignKey("dbo.MFacturas", t => t.FacturaId)
                .ForeignKey("dbo.MProductos", t => t.ProductoId)
                .Index(t => t.FacturaId)
                .Index(t => t.ProductoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MFacturaDetalle", "ProductoId", "dbo.MProductos");
            DropForeignKey("dbo.MFacturaDetalle", "FacturaId", "dbo.MFacturas");
            DropIndex("dbo.MFacturaDetalle", new[] { "ProductoId" });
            DropIndex("dbo.MFacturaDetalle", new[] { "FacturaId" });
            DropTable("dbo.MFacturaDetalle");
        }
    }
}
