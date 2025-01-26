using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineControlService.DAL.Entityes;
using AirlineControlService.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using AirlineControlService.Interfaces;

namespace AirlineControlService.BLL.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IRepository<Schedule> _Schedules;
        private readonly IRepository<User> _Users;

        public IEnumerable<Schedule> Schedules => _Schedules.items;

        public ScheduleService(IRepository<Schedule> schedules, IRepository<User> users)
        {
            _Schedules = schedules;
            _Users = users;
        }

        public async Task<Schedule> MakeASchedule(
            int TeacherId,
            DateTime Date,
            TimeSpan StartTime,
            TimeSpan EndTime,
            string Description)
        {
            // Проверка существования преподавателя
            var teacher = await _Users.items.FirstOrDefaultAsync(u => u.Id == TeacherId).ConfigureAwait(false);
            if (teacher is null)
                throw new ArgumentException("Преподаватель с указанным ID не найден.");

            // Создание нового расписания
            var schedule = new Schedule
            {
                TeacherId = TeacherId,
                Teacher = teacher,
                Date = Date,
                StartTime = StartTime,
                EndTime = EndTime,
                Description = Description
            };

            // Добавление расписания в базу данных
            var addedSchedule = await _Schedules.AddAsync(schedule, CancellationToken.None).ConfigureAwait(false);

            return addedSchedule;
        }
    }
}
