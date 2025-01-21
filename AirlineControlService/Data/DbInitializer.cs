using AirlineControlService.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Data
{
    class DbInitializer
    {
        private readonly AirlineDb _db;
        private readonly ILogger<DbInitializer> _logger;

        public DbInitializer(AirlineDb db, ILogger<DbInitializer> logger) 
        { 
            _db = db; 
            _logger = logger;
        }

        public async Task InitializeAsync()
        {
            await _db.Database.EnsureDeletedAsync().ConfigureAwait(false);

            await _db.Database.MigrateAsync();


            if (await _db.Users.AnyAsync()) return;


        }

        private async Task InitializeUsers()
        {

        }

        private async Task InitializeSchedules()
        {

        }

        private async Task InitializeAttendances()
        {

        }


    }
}
