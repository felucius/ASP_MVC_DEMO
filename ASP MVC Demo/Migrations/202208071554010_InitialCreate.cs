namespace ASP_MVC_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        IsDomesticated = c.Boolean(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Animals");
        }
    }
}
