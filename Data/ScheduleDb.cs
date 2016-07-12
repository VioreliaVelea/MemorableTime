using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ScheduleDb : DbContext, ISchduleDataSource
    {
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleType> ScheduleTypes { get; set; }

        IQueryable<Schedule> ISchduleDataSource.Schedules
        {
            get { return Schedules; }
        }

        IQueryable<ScheduleType> ISchduleDataSource.ScheduleTypes
        {
            get { return ScheduleTypes; }
        }
    }
}
