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
    internal class AdminChildService : IAdminService
    {
        private readonly IRepository<Child> _Childs;


        public AdminChildService(IRepository<Child> childs)
        {
            _Childs = childs;
        }

        public Task<IEntity> Add(IEntity item)
        {
            if (item == _Childs.items.FirstOrDefault())
            {
                return null;
            }

            else
            {
                return null;
            }
        }

        public Task Remove(int id)
        {
            return null;
        }

        public Task<IEntity> Update(IEntity item)
        {
            return null;
        }
    }
}
