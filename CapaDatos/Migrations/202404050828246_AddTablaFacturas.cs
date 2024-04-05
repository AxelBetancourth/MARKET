namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaFacturas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MClientes", "CodigoPagoId", "dbo.MCondicionPagos");
            DropForeignKey("dbo.MClientes", "GrupoDescuentoId", "dbo.MGrupoDescuentos");
            DropForeignKey("dbo.MPedidoDetalles", "PedidoID", "dbo.MPedidos");
            DropForeignKey("dbo.MPedidoDetalles", "ProductoId", "dbo.MProductos");
            DropForeignKey("dbo.MPedidos", "ClienteID", "dbo.MClientes");
            DropForeignKey("dbo.MProductos", "CategoriaId", "dbo.MCategorias");
            DropForeignKey("dbo.MProductos", "UnidadMedidaId", "dbo.MUnidadMedidas");
            CreateTable(
                "dbo.MFacturas",
                c => new
                    {
                        FacturaId = c.Int(nullable: false, identity: true),
                        ClienteID = c.Int(nullable: false),
                        PedidoID = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaFactura = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.FacturaId)
                .ForeignKey("dbo.MClientes", t => t.ClienteID)
                .ForeignKey("dbo.MPedidos", t => t.PedidoID)
                .Index(t => t.ClienteID)
                .Index(t => t.PedidoID);
            
            AddForeignKey("dbo.MClientes", "CodigoPagoId", "dbo.MCondicionPagos", "CodigoPagoId");
            AddForeignKey("dbo.MClientes", "GrupoDescuentoId", "dbo.MGrupoDescuentos", "GrupoDescuentoId");
            AddForeignKey("dbo.MPedidoDetalles", "PedidoID", "dbo.MPedidos", "PedidoID");
            AddForeignKey("dbo.MPedidoDetalles", "ProductoId", "dbo.MProductos", "ProductoId");
            AddForeignKey("dbo.MPedidos", "ClienteID", "dbo.MClientes", "ClienteID");
            AddForeignKey("dbo.MProductos", "CategoriaId", "dbo.MCategorias", "CategoriaId");
            AddForeignKey("dbo.MProductos", "UnidadMedidaId", "dbo.MUnidadMedidas", "UnidadMedidaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MProductos", "UnidadMedidaId", "dbo.MUnidadMedidas");
            DropForeignKey("dbo.MProductos", "CategoriaId", "dbo.MCategorias");
            DropForeignKey("dbo.MPedidos", "ClienteID", "dbo.MClientes");
            DropForeignKey("dbo.MPedidoDetalles", "ProductoId", "dbo.MProductos");
            DropForeignKey("dbo.MPedidoDetalles", "PedidoID", "dbo.MPedidos");
            DropForeignKey("dbo.MClientes", "GrupoDescuentoId", "dbo.MGrupoDescuentos");
            DropForeignKey("dbo.MClientes", "CodigoPagoId", "dbo.MCondicionPagos");
            DropForeignKey("dbo.MFacturas", "PedidoID", "dbo.MPedidos");
            DropForeignKey("dbo.MFacturas", "ClienteID", "dbo.MClientes");
            DropIndex("dbo.MFacturas", new[] { "PedidoID" });
            DropIndex("dbo.MFacturas", new[] { "ClienteID" });
            DropTable("dbo.MFacturas");
            AddForeignKey("dbo.MProductos", "UnidadMedidaId", "dbo.MUnidadMedidas", "UnidadMedidaId", cascadeDelete: true);
            AddForeignKey("dbo.MProductos", "CategoriaId", "dbo.MCategorias", "CategoriaId", cascadeDelete: true);
            AddForeignKey("dbo.MPedidos", "ClienteID", "dbo.MClientes", "ClienteID", cascadeDelete: true);
            AddForeignKey("dbo.MPedidoDetalles", "ProductoId", "dbo.MProductos", "ProductoId", cascadeDelete: true);
            AddForeignKey("dbo.MPedidoDetalles", "PedidoID", "dbo.MPedidos", "PedidoID", cascadeDelete: true);
            AddForeignKey("dbo.MClientes", "GrupoDescuentoId", "dbo.MGrupoDescuentos", "GrupoDescuentoId", cascadeDelete: true);
            AddForeignKey("dbo.MClientes", "CodigoPagoId", "dbo.MCondicionPagos", "CodigoPagoId", cascadeDelete: true);
        }
    }
}
