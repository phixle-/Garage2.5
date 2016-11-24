namespace Garage2._5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegNR : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "RegNr", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "RegNr");
        }
    }
}
