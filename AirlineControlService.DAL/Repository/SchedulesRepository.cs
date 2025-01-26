using AirlineControlService.DAL.Context;
using AirlineControlService.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace AirlineControlService.DAL.Repository
{
    class SchedulesRepository: DbRepository<Schedule>
    {
        public override IQueryable<Schedule> items => base.items
            .Include(s => s.Teacher);
        public SchedulesRepository(AirlineDb db) : base(db) { }
    }
}
