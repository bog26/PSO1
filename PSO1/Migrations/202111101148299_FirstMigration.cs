namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sender = c.String(),
                        Receiver = c.String(),
                        MessageTitle = c.String(),
                        MessageBody = c.String(),
                        MessageTime = c.DateTime(nullable: false),
                        MessageSenderStatus = c.String(),
                        MessageReceiverStatus = c.String(),
                        IsEncrypted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductPictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ImageData = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductSubCategoryId = c.Int(nullable: false),
                        ManufacturerId = c.Int(nullable: false),
                        Model = c.String(),
                        Stock = c.Int(nullable: false),
                        crtSellPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        crtManufacturerPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductSpecification = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .ForeignKey("dbo.ProductSubCategories", t => t.ProductSubCategoryId, cascadeDelete: true)
                .Index(t => t.ProductSubCategoryId)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.ProductSubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryId, cascadeDelete: true)
                .Index(t => t.ProductCategoryId);
            
            CreateTable(
                "dbo.ProductSpecifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        SpecData = c.Binary(),
                        SpecDataExtension = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReviewMark = c.Int(nullable: false),
                        ReviewText = c.String(),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        UserPersonalDataId = c.Int(nullable: false),
                        UserAddressId = c.Int(nullable: false),
                        isAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserAddresses", t => t.UserAddressId, cascadeDelete: true)
                .ForeignKey("dbo.UserPersonalDatas", t => t.UserPersonalDataId, cascadeDelete: true)
                .Index(t => t.UserPersonalDataId)
                .Index(t => t.UserAddressId);
            
            CreateTable(
                "dbo.UserAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Street = c.String(),
                        StreetNr = c.Int(nullable: false),
                        City = c.String(),
                        Region = c.String(),
                        Country = c.String(),
                        PostalCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserPersonalDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingCartItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.TransactionItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransactionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Transactions", t => t.TransactionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.TransactionId)
                .Index(t => t.UserId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TransactionStatus = c.String(),
                        TotalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransactionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            DropForeignKey("dbo.TransactionItems", "UserId", "dbo.Users");
            DropForeignKey("dbo.TransactionItems", "TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.TransactionItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ShoppingCartItems", "UserId", "dbo.Users");
            DropForeignKey("dbo.ShoppingCartItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Reviews", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "UserPersonalDataId", "dbo.UserPersonalDatas");
            DropForeignKey("dbo.Users", "UserAddressId", "dbo.UserAddresses");
            DropForeignKey("dbo.Reviews", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductSpecifications", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductPictures", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductSubCategoryId", "dbo.ProductSubCategories");
            DropForeignKey("dbo.ProductSubCategories", "ProductCategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.Products", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.WishListItems", new[] { "ProductId" });
            DropIndex("dbo.WishListItems", new[] { "UserId" });
            DropIndex("dbo.TransactionItems", new[] { "ProductId" });
            DropIndex("dbo.TransactionItems", new[] { "UserId" });
            DropIndex("dbo.TransactionItems", new[] { "TransactionId" });
            DropIndex("dbo.ShoppingCartItems", new[] { "ProductId" });
            DropIndex("dbo.ShoppingCartItems", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "UserAddressId" });
            DropIndex("dbo.Users", new[] { "UserPersonalDataId" });
            DropIndex("dbo.Reviews", new[] { "ProductId" });
            DropIndex("dbo.Reviews", new[] { "UserId" });
            DropIndex("dbo.ProductSpecifications", new[] { "ProductId" });
            DropIndex("dbo.ProductSubCategories", new[] { "ProductCategoryId" });
            DropIndex("dbo.Products", new[] { "ManufacturerId" });
            DropIndex("dbo.Products", new[] { "ProductSubCategoryId" });
            DropIndex("dbo.ProductPictures", new[] { "ProductId" });
            DropTable("dbo.WishListItems");
            DropTable("dbo.Transactions");
            DropTable("dbo.TransactionItems");
            DropTable("dbo.ShoppingCartItems");
            DropTable("dbo.UserPersonalDatas");
            DropTable("dbo.UserAddresses");
            DropTable("dbo.Users");
            DropTable("dbo.Reviews");
            DropTable("dbo.ProductSpecifications");
            DropTable("dbo.ProductSubCategories");
            DropTable("dbo.Products");
            DropTable("dbo.ProductPictures");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Messages");
            DropTable("dbo.Manufacturers");
        }
    }
}
