using AirlineControlService.DAL.Context;
using AirlineControlService.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace AirlineControlService.DAL.Repository
{
    class ParentChildsRepository: DbRepository<ParentChild>
    {
        public override IQueryable<ParentChild> items => base.items
            .Include(p => p.Parent)
            .Include(c => c.Child);
        public ParentChildsRepository(AirlineDb db) : base(db) { }
    }
}