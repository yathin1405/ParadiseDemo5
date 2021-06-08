namespace ParadiseDemo5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        TourID = c.Int(nullable: false, identity: true),
                        TourType = c.Int(nullable: false),
                        Tour_Name = c.String(),
                        Tour_Duration = c.String(),
                        Num_Adults = c.Int(nullable: false),
                        Num_Kids = c.Int(nullable: false),
                        LocationFrom = c.String(),
                        TourDate = c.DateTime(nullable: false),
                        TourStartTime = c.DateTime(nullable: false),
                        Price = c.Single(nullable: false),
                        Deposit = c.Double(nullable: false),
                        GuestCost = c.Double(nullable: false),
                        Total_Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TourID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tours");
        }
    }
}
