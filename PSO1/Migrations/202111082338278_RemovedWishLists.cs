namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedWishLists : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.WishLists");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WishLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        StringPIDs = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
