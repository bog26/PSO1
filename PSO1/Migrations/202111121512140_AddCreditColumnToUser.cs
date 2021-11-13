namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreditColumnToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Credit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Credit");
        }
    }
}
