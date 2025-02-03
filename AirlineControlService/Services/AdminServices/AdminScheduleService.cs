using AirlineControlService.DAL.Entityes;
using AirlineControlService.Interfaces;
using AirlineControlService.Services.Interface.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Services.AdminServices
{
    internal class AdminScheduleService : IAdminService
    {
        public Task<Child> Add(IEntity item)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Child> Update(IEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
