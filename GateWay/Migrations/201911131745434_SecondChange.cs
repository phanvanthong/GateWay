namespace GateWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondChange : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Arrivals");
        }
    }
}
