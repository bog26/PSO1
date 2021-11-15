namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTitleAndReviewToUserItemReviews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserItemReviews", "Title", c => c.String());
            AddColumn("dbo.UserItemReviews", "Review", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserItemReviews", "Review");
            DropColumn("dbo.UserItemReviews", "Title");
        }
    }
}
