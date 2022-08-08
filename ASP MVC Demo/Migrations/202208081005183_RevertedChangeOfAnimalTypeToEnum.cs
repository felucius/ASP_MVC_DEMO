namespace ASP_MVC_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevertedChangeOfAnimalTypeToEnum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "Type");
        }
    }
}
