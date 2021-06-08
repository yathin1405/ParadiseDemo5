namespace ParadiseDemo5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Demo2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tours", "Counter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tours", "Counter", c => c.Int(nullable: false));
        }
    }
}
