namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaPedidoDetalles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MPedidoDetalles",
                c => new
                    {
                        PedidoDetalleId = c.Int(nullable: false, identity: true),
                        PedidoID = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PedidoDetalleId)
                .ForeignKey("dbo.MPedidos", t => t.PedidoID, cascadeDelete: true)
                .ForeignKey("dbo.MProductos", t => t.ProductoId, cascadeDelete: true)
                .Index(t => t.PedidoID)
                .Index(t => t.ProductoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MPedidoDetalles", "ProductoId", "dbo.MProductos");
            DropForeignKey("dbo.MPedidoDetalles", "PedidoID", "dbo.MPedidos");
            DropIndex("dbo.MPedidoDetalles", new[] { "ProductoId" });
            DropIndex("dbo.MPedidoDetalles", new[] { "PedidoID" });
            DropTable("dbo.MPedidoDetalles");
        }
    }
}
