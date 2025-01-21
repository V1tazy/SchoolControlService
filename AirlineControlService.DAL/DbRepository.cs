using AirlineControlService.DAL.Entityes.Base;
using AirlineControlService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.DAL
{
    public class DbRepository<T>: IRepository<T> where T : Entity, new()
    {
    }
}
