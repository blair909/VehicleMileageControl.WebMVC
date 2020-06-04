namespace VehicleMileageControl.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class derp : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.VehicleHistory", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VehicleHistory", "FullName", c => c.String());
        }
    }
}
