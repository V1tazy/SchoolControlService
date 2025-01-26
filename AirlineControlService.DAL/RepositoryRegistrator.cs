using AirlineControlService.DAL.Entityes;
using AirlineControlService.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.DAL
{
    public static class RepositoryRegistrator
    {
        public static IServiceCollection AddRepositoryInDB(this IServiceCollection services) => services
            .AddTransient<IRepository<User>, DbRepository<User>>()
            .AddTransient<IRepository<Child>, DbRepository<Child>>()
            .AddTransient<IRepository<ParentChild>, DbRepository<ParentChild>>()
            .AddTransient<IRepository<Class>, DbRepository<Class>>()
            .AddTransient<IRepository<ClassChild>, DbRepository<ClassChild>>()
            .AddTransient<IRepository<Attendance>, DbRepository<Attendance>>()
            .AddTransient<IRepository<Schedule>, DbRepository<Schedule>>()
            ;
        
    }
}
