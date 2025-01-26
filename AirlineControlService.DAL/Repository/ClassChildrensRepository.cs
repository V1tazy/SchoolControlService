using AirlineControlService.DAL.Context;
using AirlineControlService.DAL.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.DAL.Repository
{
    class ClassChildrensRepository: DbRepository<ClassChild>
    {
        public override IQueryable<ClassChild> items => base.items
            .Include(c => c.Class)
            .Include(c => c.Child);
        public ClassChildrensRepository(AirlineDb db) : base(db) { }
    }
}
