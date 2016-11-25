namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VTstring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VehicleTypes", "Type", c => c.String(nullable: false));
            DropColumn("dbo.VehicleTypes", "Vehicle_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VehicleTypes", "Vehicle_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.VehicleTypes", "Type", c => c.Int(nullable: false));
        }
    }
}
