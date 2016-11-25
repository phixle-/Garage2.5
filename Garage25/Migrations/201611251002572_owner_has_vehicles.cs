namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class owner_has_vehicles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "Owner_Id", c => c.Int());
            CreateIndex("dbo.Vehicles", "Owner_Id");
            AddForeignKey("dbo.Vehicles", "Owner_Id", "dbo.Owners", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "Owner_Id", "dbo.Owners");
            DropIndex("dbo.Vehicles", new[] { "Owner_Id" });
            DropColumn("dbo.Vehicles", "Owner_Id");
        }
    }
}
