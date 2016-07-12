using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface ISchduleDataSource
    {
        IQueryable<Schedule> Schedules { get; }
        IQueryable<ScheduleType> ScheduleTypes { get; }  
    }
}
