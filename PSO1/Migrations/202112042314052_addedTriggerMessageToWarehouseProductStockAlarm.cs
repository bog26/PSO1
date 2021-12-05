namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTriggerMessageToWarehouseProductStockAlarm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WarehouseProductStockAlarms", "TriggerMessage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WarehouseProductStockAlarms", "TriggerMessage");
        }
    }
}
