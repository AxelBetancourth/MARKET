namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaCondicionPagos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MCondicionPagos",
                c => new
                    {
                        CodigoPaosId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Descripción = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        Dias = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoPaosId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MCondicionPagos");
        }
    }
}
