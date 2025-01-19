using AirlineControlService.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.DAL
{
    internal class DbRepository<T>: IRepository<T> where T : Entity, new()
    {
    }
}
