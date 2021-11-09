namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUserAddresssAndUserPersonalData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAddresses", "UserName", c => c.String());
            AddColumn("dbo.UserPersonalDatas", "UserName", c => c.String());
            DropColumn("dbo.UserAddresses", "UserId");
            DropColumn("dbo.UserPersonalDatas", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserPersonalDatas", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.UserAddresses", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.UserPersonalDatas", "UserName");
            DropColumn("dbo.UserAddresses", "UserName");
        }
    }
}
