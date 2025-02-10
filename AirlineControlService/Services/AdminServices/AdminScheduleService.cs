using AirlineControlService.DAL.Entityes;
using AirlineControlService.Interfaces;
using AirlineControlService.Services.Interface.Admin;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AirlineControlService.Services.AdminServices
{
    public class AdminScheduleService : IAdminService
    {
        private readonly IRepository<Schedule> _scheduleRepository;

        public AdminScheduleService(IRepository<Schedule> scheduleRepository)
        {
            _scheduleRepository = scheduleRepository ?? throw new ArgumentNullException(nameof(scheduleRepository));
        }

        public async Task<IEntity> Add(IEntity item)
        {
            if (item is not Schedule schedule)
                throw new ArgumentException("Invalid entity type", nameof(item));

            return await _scheduleRepository.AddAsync(schedule, CancellationToken.None);
        }

        public async Task<IEntity> Update(IEntity item)
        {
            if (item is not Schedule schedule)
                throw new ArgumentException("Invalid entity type", nameof(item));

            await _scheduleRepository.UpdateAsync(schedule, CancellationToken.None);
            return schedule;
        }

        public async Task Remove(int id)
        {
            await _scheduleRepository.RemoveAsync(id, CancellationToken.None);
        }
    }
}
