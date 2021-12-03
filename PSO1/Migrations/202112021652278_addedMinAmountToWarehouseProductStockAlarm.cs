namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedMinAmountToWarehouseProductStockAlarm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WarehouseProductStockAlarms", "MinAmount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WarehouseProductStockAlarms", "MinAmount");
        }
    }
}
