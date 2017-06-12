namespace GarageDatabaseOstersund.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fees",
                c => new
                    {
                        VehicleTypeId = c.Int(nullable: false),
                        VehicleFee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleTypeId)
                .ForeignKey("dbo.VehicleTypes", t => t.VehicleTypeId)
                .Index(t => t.VehicleTypeId);
            
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        SSN = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SSN);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        RegNr = c.String(nullable: false, maxLength: 128),
                        Brand = c.String(),
                        OwnerSSN = c.String(maxLength: 128),
                        VehicleTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegNr)
                .ForeignKey("dbo.Owners", t => t.OwnerSSN)
                .ForeignKey("dbo.VehicleTypes", t => t.VehicleTypeId, cascadeDelete: true)
                .Index(t => t.OwnerSSN)
                .Index(t => t.VehicleTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "VehicleTypeId", "dbo.VehicleTypes");
            DropForeignKey("dbo.Vehicles", "OwnerSSN", "dbo.Owners");
            DropForeignKey("dbo.Fees", "VehicleTypeId", "dbo.VehicleTypes");
            DropIndex("dbo.Vehicles", new[] { "VehicleTypeId" });
            DropIndex("dbo.Vehicles", new[] { "OwnerSSN" });
            DropIndex("dbo.Fees", new[] { "VehicleTypeId" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.Owners");
            DropTable("dbo.VehicleTypes");
            DropTable("dbo.Fees");
        }
    }
}
