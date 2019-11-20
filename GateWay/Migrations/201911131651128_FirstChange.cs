namespace GateWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstChange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Guid(nullable: false),
                        LicensePlate = c.String(),
                        GarageID = c.Guid(nullable: false),
                        CarTypeID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.CarID)
                .ForeignKey("dbo.CarTypes", t => t.CarTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Garages", t => t.GarageID, cascadeDelete: true)
                .Index(t => t.GarageID)
                .Index(t => t.CarTypeID);
            
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        CarTypeID = c.Guid(nullable: false),
                        CarTypeName = c.String(),
                        Seats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarTypeID);
            
            CreateTable(
                "dbo.Garages",
                c => new
                    {
                        GarageID = c.Guid(nullable: false),
                        GarageName = c.String(),
                        Address = c.String(),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        Descript = c.String(),
                    })
                .PrimaryKey(t => t.GarageID);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverID = c.Guid(nullable: false),
                        DriverName = c.String(),
                        Phone = c.String(),
                        GarageID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.DriverID)
                .ForeignKey("dbo.Garages", t => t.GarageID, cascadeDelete: true)
                .Index(t => t.GarageID);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        PlanID = c.Guid(nullable: false),
                        PlanDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(),
                        DriverName = c.String(),
                        TeacherName = c.String(),
                        DriverID = c.Guid(),
                        CarID = c.Guid(),
                        TeacherID = c.Guid(),
                    })
                .PrimaryKey(t => t.PlanID)
                .ForeignKey("dbo.Cars", t => t.CarID)
                .ForeignKey("dbo.Drivers", t => t.DriverID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID)
                .Index(t => t.DriverID)
                .Index(t => t.CarID)
                .Index(t => t.TeacherID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Guid(nullable: false),
                        StudentName = c.String(),
                        StatusStudent = c.Boolean(nullable: false),
                        UserID = c.Guid(nullable: false),
                        Plan_PlanID = c.Guid(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Plans", t => t.Plan_PlanID)
                .Index(t => t.UserID)
                .Index(t => t.Plan_PlanID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Guid(nullable: false),
                        UserName = c.String(),
                        PassWord = c.String(),
                        FirstLogin = c.Boolean(nullable: false),
                        FinalLogin = c.DateTime(nullable: false),
                        UserPhone = c.String(),
                        UserAddress = c.String(),
                        UserRole = c.String(),
                        UserStatus = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Waiting = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Guid(nullable: false),
                        TeacherName = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plans", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Students", "Plan_PlanID", "dbo.Plans");
            DropForeignKey("dbo.Students", "UserID", "dbo.Users");
            DropForeignKey("dbo.Plans", "DriverID", "dbo.Drivers");
            DropForeignKey("dbo.Plans", "CarID", "dbo.Cars");
            DropForeignKey("dbo.Drivers", "GarageID", "dbo.Garages");
            DropForeignKey("dbo.Cars", "GarageID", "dbo.Garages");
            DropForeignKey("dbo.Cars", "CarTypeID", "dbo.CarTypes");
            DropIndex("dbo.Students", new[] { "Plan_PlanID" });
            DropIndex("dbo.Students", new[] { "UserID" });
            DropIndex("dbo.Plans", new[] { "TeacherID" });
            DropIndex("dbo.Plans", new[] { "CarID" });
            DropIndex("dbo.Plans", new[] { "DriverID" });
            DropIndex("dbo.Drivers", new[] { "GarageID" });
            DropIndex("dbo.Cars", new[] { "CarTypeID" });
            DropIndex("dbo.Cars", new[] { "GarageID" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Users");
            DropTable("dbo.Students");
            DropTable("dbo.Plans");
            DropTable("dbo.Drivers");
            DropTable("dbo.Garages");
            DropTable("dbo.CarTypes");
            DropTable("dbo.Cars");
        }
    }
}
