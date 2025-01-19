using AirlineControlService.DAL.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.DAL.Context
{
    public class AirlineDb: DbContext
    {
        public DbSet<User> Users { get; set; }


        public AirlineDb(DbContextOptions<AirlineDb> options) : base(options) { }
    }
}
