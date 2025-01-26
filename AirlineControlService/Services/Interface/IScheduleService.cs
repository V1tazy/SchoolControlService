using AirlineControlService.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirlineControlService.BLL.Services
{
    public interface IScheduleService
    {
        IEnumerable<Schedule> Schedules { get; }

        Task<Schedule> MakeASchedule(
            int TeacherId,
            DateTime Date,
            TimeSpan StartTime,
            TimeSpan EndTime,
            string Description);
    }
}
