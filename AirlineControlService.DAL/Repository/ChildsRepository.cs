using AirlineControlService.DAL.Context;
using AirlineControlService.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace AirlineControlService.DAL.Repository
{
    class ChildsRepository: DbRepository<Child>
    {

        public override IQueryable<Child> items => base.items
            .Include(c => c.ParentChildren)
            .Include(c => c.ClassChildren);
        public ChildsRepository(AirlineDb db) : base(db) { }
    }
}
