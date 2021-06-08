namespace ParadiseDemo5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ParadiseDemo5.Data.ParadiseDemo5Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ParadiseDemo5.Data.ParadiseDemo5Context";
        }

        protected override void Seed(ParadiseDemo5.Data.ParadiseDemo5Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
