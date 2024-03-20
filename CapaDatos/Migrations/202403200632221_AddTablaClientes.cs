namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaClientes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MClientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 15),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellidos = c.String(nullable: false, maxLength: 50),
                        GrupoDescuentoId = c.Int(nullable: false),
                        CodigoPagoId = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID)
                .ForeignKey("dbo.MCondicionPagos", t => t.CodigoPagoId)
                .ForeignKey("dbo.MGrupoDescuentos", t => t.GrupoDescuentoId)
                .Index(t => t.GrupoDescuentoId)
                .Index(t => t.CodigoPagoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MClientes", "GrupoDescuentoId", "dbo.MGrupoDescuentos");
            DropForeignKey("dbo.MClientes", "CodigoPagoId", "dbo.MCondicionPagos");
            DropIndex("dbo.MClientes", new[] { "CodigoPagoId" });
            DropIndex("dbo.MClientes", new[] { "GrupoDescuentoId" });
            DropTable("dbo.MClientes");
        }
    }
}
