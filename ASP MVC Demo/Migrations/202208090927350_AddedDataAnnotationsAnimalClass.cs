namespace ASP_MVC_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotationsAnimalClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animals", "Name", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "Name", c => c.String());
        }
    }
}
