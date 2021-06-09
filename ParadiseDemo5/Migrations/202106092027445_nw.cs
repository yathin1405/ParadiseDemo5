using System;
using System.Data.Entity.Migrations;

 namespace ParadiseDemo5.Migrations
{
    public partial class nw : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tours", "FriendlyMessage", c => c.String());
            DropColumn("dbo.Tours", "capacity");
        }

        public override void Down()
        {
            AddColumn("dbo.Tours", "capacity", c => c.Int(nullable: false));
            DropColumn("dbo.Tours", "FriendlyMessage");
        }
    }
}

