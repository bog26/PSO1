namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserItemReviews : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserItemReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        UserItemScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserItemReviews", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserItemReviews", "ProductId", "dbo.Products");
            DropIndex("dbo.UserItemReviews", new[] { "ProductId" });
            DropIndex("dbo.UserItemReviews", new[] { "UserId" });
            DropTable("dbo.UserItemReviews");
        }
    }
}
