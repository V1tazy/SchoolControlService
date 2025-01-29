using AirlineControlService.DAL.Entityes;
using AirlineControlService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Services.Interface.Admin
{
    interface IAdminService
    {

        Task<Child> Add(IEntity item);

        Task<Child> Update(IEntity item);

        Task Remove(int id);
    }
}
