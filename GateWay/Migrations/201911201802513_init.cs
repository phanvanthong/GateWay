namespace GateWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arrivals",
                c => new
                    {
                        ArrivalID = c.Guid(nullable: false),
                        Longitude = c.Single(nullable: false),
                        Latitude = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ArrivalID);
            
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
                "dbo.Notifications",
                c => new
                    {
                        NotificationID = c.Guid(nullable: false),
                        NotificationContent = c.String(),
                        Driver_DriverID = c.Guid(),
                        Student_StudentID = c.Guid(),
                        Teacher_TeacherID = c.Guid(),
                    })
                .PrimaryKey(t => t.NotificationID)
                .ForeignKey("dbo.Drivers", t => t.Driver_DriverID)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherID)
                .Index(t => t.Driver_DriverID)
                .Index(t => t.Student_StudentID)
                .Index(t => t.Teacher_TeacherID);
            
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
                        Plan_PlanID = c.Guid(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Plans", t => t.Plan_PlanID)
                .Index(t => t.Plan_PlanID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Guid(nullable: false),
                        TeacherName = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Plans", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Notifications", "Teacher_TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Students", "Plan_PlanID", "dbo.Plans");
            DropForeignKey("dbo.Notifications", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.Plans", "DriverID", "dbo.Drivers");
            DropForeignKey("dbo.Plans", "CarID", "dbo.Cars");
            DropForeignKey("dbo.Notifications", "Driver_DriverID", "dbo.Drivers");
            DropForeignKey("dbo.Drivers", "GarageID", "dbo.Garages");
            DropForeignKey("dbo.Cars", "GarageID", "dbo.Garages");
            DropForeignKey("dbo.Cars", "CarTypeID", "dbo.CarTypes");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Students", new[] { "Plan_PlanID" });
            DropIndex("dbo.Plans", new[] { "TeacherID" });
            DropIndex("dbo.Plans", new[] { "CarID" });
            DropIndex("dbo.Plans", new[] { "DriverID" });
            DropIndex("dbo.Notifications", new[] { "Teacher_TeacherID" });
            DropIndex("dbo.Notifications", new[] { "Student_StudentID" });
            DropIndex("dbo.Notifications", new[] { "Driver_DriverID" });
            DropIndex("dbo.Drivers", new[] { "GarageID" });
            DropIndex("dbo.Cars", new[] { "CarTypeID" });
            DropIndex("dbo.Cars", new[] { "GarageID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Plans");
            DropTable("dbo.Notifications");
            DropTable("dbo.Drivers");
            DropTable("dbo.Garages");
            DropTable("dbo.CarTypes");
            DropTable("dbo.Cars");
            DropTable("dbo.Arrivals");
        }
    }
}
