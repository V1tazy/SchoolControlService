using Microsoft.EntityFrameworkCore;
using AirlineControlService.DAL.Entityes;
using AirlineControlService.DAL.Context;
using AirlineControlService;


namespace AirlineControlService.DAL.Repository
{
    class AttendancesRepository : DbRepository<Attendance>
    {
        public override IQueryable<Attendance> items => base.items
        .Include(a => a.Child)
        .Include(a => a.CreatedBy);

        public AttendancesRepository(AirlineDb DB) : base(DB) {}
    }
}
