using AirlineControlService.DAL.Context;
using AirlineControlService.DAL.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

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
            var timer = Stopwatch.StartNew();
            _logger.LogInformation("Инициализация БД");

            if (await _db.Users.AnyAsync()) return;

            _logger.LogInformation("Миграция БД");
            await _db.Database.MigrateAsync().ConfigureAwait(false);
            _logger.LogInformation("Миграция выполнена за {0} мс", timer.ElapsedMilliseconds);


            await InitializeUsers();
            await InitializeChildren();
            await InitializeClasses();
            await InitializeSchedules();
            await InitializeAttendances();

            _logger.LogInformation("Инициализация БД выполнена за {0} мс", timer.ElapsedMilliseconds);
        }


        private async Task InitializeUsers()
        {
            if (await _db.Users.AnyAsync()) return;

            var users = new[]
            {
                new User
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Login = "johndoe",
                    Password = "password123",
                    Email = "john.doe@example.com",
                    Phone = "1234567890",
                    Role = "Admin",
                    Name = "John Doe"
                },
                new User
                {
                    FirstName = "Jane",
                    LastName = "Smith",
                    Login = "janesmith",
                    Password = "password456",
                    Email = "jane.smith@example.com",
                    Phone = "0987654321",
                    Role = "Teacher",
                    Name = "Jane Smith"
                }
            };

            await _db.Users.AddRangeAsync(users);
            await _db.SaveChangesAsync();
        }

        private async Task InitializeClasses()
        {
            if (await _db.Classes.AnyAsync()) return;

            var teacher = await _db.Users.FirstOrDefaultAsync(u => u.Role == "Teacher");
            if (teacher == null) return;

            var classes = new[]
            {
                new Class
                {
                    Name = "Class A",
                    TeacherId = teacher.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Class
                {
                    Name = "Class B",
                    TeacherId = teacher.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            };

            await _db.Classes.AddRangeAsync(classes);
            await _db.SaveChangesAsync();
        }

        private async Task InitializeChildren()
        {
            if (await _db.Children.AnyAsync()) return;

            var children = new[]
            {
                new Child
                {
                    FirstName = "Alice",
                    LastName = "Johnson",
                    BirthDay = new DateTime(2015, 5, 10),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Child
                {
                    FirstName = "Bob",
                    LastName = "Williams",
                    BirthDay = new DateTime(2014, 7, 15),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
            }
            };

            await _db.Children.AddRangeAsync(children);
            await _db.SaveChangesAsync();
        }

        private async Task InitializeSchedules()
        {
            if (await _db.Schedules.AnyAsync()) return;

            var teacher = await _db.Users.FirstOrDefaultAsync(u => u.Role == "Teacher");
            if (teacher == null) return;

            var schedules = new[]
            {
        new Schedule
        {
            Date = DateTime.Today,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(12, 0, 0),
            Description = "Math Class",
            TeacherId = teacher.Id
        },
        new Schedule
        {
            Date = DateTime.Today.AddDays(1),
            StartTime = new TimeSpan(10, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            Description = "Science Class",
            TeacherId = teacher.Id
        }
    };

            await _db.Schedules.AddRangeAsync(schedules);
            await _db.SaveChangesAsync();
        }

        private async Task InitializeAttendances()
        {
            if (await _db.Attendances.AnyAsync()) return;

            var child = await _db.Children.FirstOrDefaultAsync();
            var createdBy = await _db.Users.FirstOrDefaultAsync();
            if (child == null || createdBy == null) return;

            var attendances = new[]
            {
        new Attendance
        {
            ChildId = child.Id,
            CreatedById = createdBy.Id,
            Date = DateTime.Today,
            Description = "Present"
        },
        new Attendance
        {
            ChildId = child.Id,
            CreatedById = createdBy.Id,
            Date = DateTime.Today.AddDays(-1),
            Description = "Absent"
        }
    };

            await _db.Attendances.AddRangeAsync(attendances);
            await _db.SaveChangesAsync();
        }



    }
}
