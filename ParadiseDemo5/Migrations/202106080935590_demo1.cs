namespace ParadiseDemo5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        HotelID = c.Int(nullable: false, identity: true),
                        Name_Guests = c.String(),
                        Num_Adults = c.String(),
                        Num_Children = c.String(),
                        Guest_Type = c.String(),
                        TPrice = c.Double(nullable: false),
                        Price = c.Single(nullable: false),
                        Hotels = c.Int(nullable: false),
                        NumOfGuests = c.Int(nullable: false),
                        Rooms = c.Int(nullable: false),
                        Breakfast = c.Boolean(nullable: false),
                        Breakfast_Price = c.Double(nullable: false),
                        Meal_Type = c.String(),
                        RoomType_Price = c.Double(nullable: false),
                        MealType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HotelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hotels");
        }
    }
}
