namespace VehicleMileageControl.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyDBFix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Maintenance",
                c => new
                    {
                        MaintenanceId = c.Int(nullable: false, identity: true),
                        MaintenanceOwnerId = c.Guid(nullable: false),
                        OdomoterMileage = c.Int(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        MessageId = c.Int(nullable: false),
                        MessageStr = c.String(),
                        VehicleInformationId = c.Int(nullable: false),
                        VehicleInformationStr = c.String(),
                        NoteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaintenanceId)
                .ForeignKey("dbo.Message", t => t.MessageId, cascadeDelete: true)
                .ForeignKey("dbo.Note", t => t.NoteId, cascadeDelete: true)
                .ForeignKey("dbo.VehicleInformation", t => t.VehicleInformationId, cascadeDelete: true)
                .Index(t => t.MessageId)
                .Index(t => t.VehicleInformationId)
                .Index(t => t.NoteId);
            
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        MessageOwnerId = c.Guid(nullable: false),
                        NewMessage = c.String(),
                        MessageOne = c.String(),
                        MessageTwo = c.String(),
                        MessageThree = c.String(),
                        MessageFour = c.String(),
                        MessageFive = c.String(),
                        MessageSix = c.String(),
                        MessageSeven = c.String(),
                        MessageEight = c.String(),
                        MessageNine = c.String(),
                        MessageTen = c.String(),
                        MessageEleven = c.String(),
                        MessageTwelve = c.String(),
                        MessageThirteen = c.String(),
                        MessageFourteen = c.String(),
                        MessageFifteen = c.String(),
                        MessageSixteen = c.String(),
                        MessageSeventeen = c.String(),
                        MessageEighteen = c.String(),
                        MessageNineteen = c.String(),
                        MessageTwenty = c.String(),
                        MessageTwentyone = c.String(),
                        MessageTwentytwo = c.String(),
                        MessageTwentythree = c.String(),
                        MessageTwentyfour = c.String(),
                        MessageTwentyfive = c.String(),
                        MessageTwentysix = c.String(),
                        MessageTwentyseven = c.String(),
                        MessageTwentyeight = c.String(),
                    })
                .PrimaryKey(t => t.MessageId);
            
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        NoteId = c.Int(nullable: false, identity: true),
                        NoteOwnerId = c.Guid(nullable: false),
                        NoteTitle = c.String(nullable: false),
                        NoteContent = c.String(nullable: false),
                        VehicleHistoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NoteId)
                .ForeignKey("dbo.VehicleHistory", t => t.VehicleHistoryId, cascadeDelete: true)
                .Index(t => t.VehicleHistoryId);
            
            CreateTable(
                "dbo.VehicleHistory",
                c => new
                    {
                        VehicleHistoryId = c.Int(nullable: false, identity: true),
                        VehicleHistoryOwnerId = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        FullName = c.String(nullable: false),
                        VehicleMake = c.String(nullable: false),
                        VehicleModel = c.String(nullable: false),
                        VehicleYear = c.Int(nullable: false),
                        LicenseNo = c.String(nullable: false),
                        VinNo = c.String(nullable: false),
                        ServiceDate = c.DateTime(nullable: false),
                        OdometerMileage = c.Int(nullable: false),
                        ServiceOne = c.String(nullable: false),
                        ServiceTwo = c.String(),
                        ServiceThree = c.String(),
                        ServiceFour = c.String(),
                        ServiceFive = c.String(),
                        ServiceOneCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServiceTwoCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServiceThreeCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServiceFourCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServiceFiveCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.VehicleHistoryId);
            
            CreateTable(
                "dbo.VehicleInformation",
                c => new
                    {
                        VehicleInformationId = c.Int(nullable: false, identity: true),
                        VehicleInformationOwnerId = c.Guid(nullable: false),
                        NewVehicleInformation = c.String(),
                        OilAndFilterChange = c.String(),
                        TireRotation = c.String(),
                        TireAlignment = c.String(),
                        EngineAirFilterChange = c.String(),
                        CabinAirFilterChange = c.String(),
                        FuelFilterChange = c.String(),
                        BrakeFluidChange = c.String(),
                        TransmissionFluidAndFilterChange = c.String(),
                        TransmissionSystemsInspection = c.String(),
                        BrakePadChange = c.String(),
                        BatteryChange = c.String(),
                        EngineCoolingSystemInspection = c.String(),
                        EngineCoolantChange = c.String(),
                        StrutCheck = c.String(),
                        SteeringRackCheck = c.String(),
                        BrakeRotorChange = c.String(),
                        RadiatorHoseChange = c.String(),
                        TimingBeltChange = c.String(),
                        FuelTankPressureSensorCheck = c.String(),
                        FuelSystemsInspection = c.String(),
                        PowerSteeringPumpInspection = c.String(),
                        SparkPlugChange = c.String(),
                        DriveTrainInspection = c.String(),
                        AlternatorChange = c.String(),
                        CatalyticConverterCheck = c.String(),
                    })
                .PrimaryKey(t => t.VehicleInformationId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.SavedPaymentInformation",
                c => new
                    {
                        SavedPaymentInformationId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        CardNumber = c.Int(nullable: false),
                        FullName = c.String(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        CVV = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SavedPaymentInformationId);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.Maintenance", "VehicleInformationId", "dbo.VehicleInformation");
            DropForeignKey("dbo.Maintenance", "NoteId", "dbo.Note");
            DropForeignKey("dbo.Note", "VehicleHistoryId", "dbo.VehicleHistory");
            DropForeignKey("dbo.Maintenance", "MessageId", "dbo.Message");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.Note", new[] { "VehicleHistoryId" });
            DropIndex("dbo.Maintenance", new[] { "NoteId" });
            DropIndex("dbo.Maintenance", new[] { "VehicleInformationId" });
            DropIndex("dbo.Maintenance", new[] { "MessageId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.SavedPaymentInformation");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.VehicleInformation");
            DropTable("dbo.VehicleHistory");
            DropTable("dbo.Note");
            DropTable("dbo.Message");
            DropTable("dbo.Maintenance");
        }
    }
}
