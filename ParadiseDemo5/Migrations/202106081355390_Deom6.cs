namespace ParadiseDemo5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deom6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tours", "capacity", c => c.Int(nullable: false));
            AddColumn("dbo.Tours", "TTickets", c => c.Int(nullable: false));
            DropColumn("dbo.Tours", "Counter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tours", "Counter", c => c.Int(nullable: false));
            DropColumn("dbo.Tours", "TTickets");
            DropColumn("dbo.Tours", "capacity");
        }
    }
}
