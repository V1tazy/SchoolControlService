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

        Task<IEntity> Add(IEntity item);

        Task<IEntity> Update(IEntity item);

        Task Remove(int id);
    }
}
