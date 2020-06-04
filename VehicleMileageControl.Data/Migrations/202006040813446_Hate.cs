namespace VehicleMileageControl.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VehicleHistory", "FullName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VehicleHistory", "FullName", c => c.String(nullable: false));
        }
    }
}
