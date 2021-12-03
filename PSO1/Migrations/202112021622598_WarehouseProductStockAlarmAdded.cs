namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WarehouseProductStockAlarmAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WarehouseProductStockAlarms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        message = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WarehouseProductStockAlarms", "UserId", "dbo.Users");
            DropForeignKey("dbo.WarehouseProductStockAlarms", "ProductId", "dbo.Products");
            DropIndex("dbo.WarehouseProductStockAlarms", new[] { "ProductId" });
            DropIndex("dbo.WarehouseProductStockAlarms", new[] { "UserId" });
            DropTable("dbo.WarehouseProductStockAlarms");
        }
    }
}
