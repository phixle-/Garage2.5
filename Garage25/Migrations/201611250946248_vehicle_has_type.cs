namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vehicle_has_type : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "VehicleType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Vehicles", "VehicleType_Id");
            AddForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes");
            DropIndex("dbo.Vehicles", new[] { "VehicleType_Id" });
            DropColumn("dbo.Vehicles", "VehicleType_Id");
        }
    }
}
