namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.ScheduleDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Data.ScheduleDb context)
        {
           context.ScheduleTypes.AddOrUpdate(s => s.Name,
               new ScheduleType() {Name = "Fix time" },
               new ScheduleType() { Name = "On a period" },
               new ScheduleType() { Name = "Reccuring" }
               );
        }
    }
}
