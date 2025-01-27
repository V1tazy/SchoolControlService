using AirlineControlService.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Services.Interface
{
    internal interface IAuthService
    {
        Task<User> AuthUser(string login, string password);
    }
}
