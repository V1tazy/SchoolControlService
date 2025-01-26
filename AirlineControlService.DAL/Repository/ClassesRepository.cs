using AirlineControlService.DAL.Context;
using AirlineControlService.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace AirlineControlService.DAL.Repository
{
    class ClassesRepository: DbRepository<Class>
    {
        public override IQueryable<Class> items => base.items
            .Include(c => c.ClassChildren)
            .Include(c => c.Teacher);
        public ClassesRepository(AirlineDb db) : base(db) { }
    }
}
