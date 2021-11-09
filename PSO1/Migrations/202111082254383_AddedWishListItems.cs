namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWishListItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WishListItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WishListItems", "UserId", "dbo.Users");
            DropForeignKey("dbo.WishListItems", "ProductId", "dbo.Products");
            DropIndex("dbo.WishListItems", new[] { "ProductId" });
            DropIndex("dbo.WishListItems", new[] { "UserId" });
            DropTable("dbo.WishListItems");
        }
    }
}
