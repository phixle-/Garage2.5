namespace Garage2._5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Persons : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.People", new[] { "SSN" });
            AlterColumn("dbo.People", "SSN", c => c.String(nullable: false, maxLength: 12));
            CreateIndex("dbo.People", "SSN", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.People", new[] { "SSN" });
            AlterColumn("dbo.People", "SSN", c => c.String(maxLength: 12));
            CreateIndex("dbo.People", "SSN", unique: true);
        }
    }
}
