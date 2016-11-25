namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class owner_is_person : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Owners", "PersonId", c => c.Int(nullable: false));
            CreateIndex("dbo.Owners", "PersonId");
            AddForeignKey("dbo.Owners", "PersonId", "dbo.People", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Owners", "PersonId", "dbo.People");
            DropIndex("dbo.Owners", new[] { "PersonId" });
            DropColumn("dbo.Owners", "PersonId");
        }
    }
}
