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
    class UsersRepository: DbRepository<User>
    {
        public override IQueryable<User> items => base.items.Include);

        public UsersRepository(AirlineDb db): base(db) { }
    }
}
