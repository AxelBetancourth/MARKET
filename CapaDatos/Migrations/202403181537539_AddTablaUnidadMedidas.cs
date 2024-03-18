namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaUnidadMedidas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MUnidadMedidas",
                c => new
                    {
                        UnidadMedidaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Descripción = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UnidadMedidaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MUnidadMedidas");
        }
    }
}
