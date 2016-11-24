namespace Garage2._5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VehicleRequire : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "RegNr", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "Color", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "Manufacturer", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "Model", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Model", c => c.String());
            AlterColumn("dbo.Vehicles", "Manufacturer", c => c.String());
            AlterColumn("dbo.Vehicles", "Color", c => c.String());
            AlterColumn("dbo.Vehicles", "RegNr", c => c.String());
        }
    }
}
