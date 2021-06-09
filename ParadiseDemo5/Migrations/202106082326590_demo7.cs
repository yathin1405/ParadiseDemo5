namespace ParadiseDemo5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bookingcs", "Tour_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookingcs", "Tour_ID", c => c.Int(nullable: false));
        }
    }
}
