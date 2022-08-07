namespace ASP_MVC_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReleaseDateDateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "ReleaseDate");
        }
    }
}
