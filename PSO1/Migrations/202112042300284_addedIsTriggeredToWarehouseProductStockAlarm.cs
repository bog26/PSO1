namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedIsTriggeredToWarehouseProductStockAlarm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WarehouseProductStockAlarms", "IsTriggered", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WarehouseProductStockAlarms", "IsTriggered");
        }
    }
}
