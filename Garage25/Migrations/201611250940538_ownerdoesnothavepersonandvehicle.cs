namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ownerdoesnothavepersonandvehicle : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Owners", "Person_Id");
            DropColumn("dbo.Owners", "Vehicle_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Owners", "Vehicle_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Owners", "Person_Id", c => c.Int(nullable: false));
        }
    }
}
