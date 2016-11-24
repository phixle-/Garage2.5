namespace Garage2._5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mVehicles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegNr = c.String(nullable: false, maxLength: 7),
                        Color = c.String(nullable: false),
                        NumberOfWheels = c.Int(nullable: false),
                        Manufacturer = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Owner_PersonId = c.Int(),
                        VehicleType_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Owners", t => t.Owner_PersonId)
                .ForeignKey("dbo.VehicleTypes", t => t.VehicleType_Id, cascadeDelete: true)
                .Index(t => t.RegNr, unique: true)
                .Index(t => t.Owner_PersonId)
                .Index(t => t.VehicleType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes");
            DropForeignKey("dbo.Vehicles", "Owner_PersonId", "dbo.Owners");
            DropIndex("dbo.Vehicles", new[] { "VehicleType_Id" });
            DropIndex("dbo.Vehicles", new[] { "Owner_PersonId" });
            DropIndex("dbo.Vehicles", new[] { "RegNr" });
            DropTable("dbo.Vehicles");
        }
    }
}
