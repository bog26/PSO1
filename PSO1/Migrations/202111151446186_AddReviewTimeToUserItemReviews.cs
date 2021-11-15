namespace PSO1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReviewTimeToUserItemReviews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserItemReviews", "ReviewTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserItemReviews", "ReviewTime");
        }
    }
}
