namespace ASP_MVC_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCutenessRatingPropertgy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "CutenessRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "CutenessRating");
        }
    }
}
