namespace TimeSeriesForms_Kinyapin.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeSeriesForms_Kinyapin.DataBase.ContextDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TimeSeriesForms_Kinyapin.DataBase.ContextDB";
        }

        protected override void Seed(TimeSeriesForms_Kinyapin.DataBase.ContextDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
