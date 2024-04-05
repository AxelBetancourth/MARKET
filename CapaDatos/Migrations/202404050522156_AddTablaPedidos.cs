namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaPedidos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MPedidos",
                c => new
                    {
                        PedidoID = c.Int(nullable: false, identity: true),
                        ClienteID = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaPedido = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PedidoID)
                .ForeignKey("dbo.MClientes", t => t.ClienteID, cascadeDelete: true)
                .Index(t => t.ClienteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MPedidos", "ClienteID", "dbo.MClientes");
            DropIndex("dbo.MPedidos", new[] { "ClienteID" });
            DropTable("dbo.MPedidos");
        }
    }
}
