using AirlineControlService.DAL.Entityes;
using AirlineControlService.DAL.Repository;
using AirlineControlService.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AirlineControlService.DAL
{
    public static class RepositoryRegistrator
    {
        public static IServiceCollection AddRepositoryesInDB(this IServiceCollection services) => services
            .AddTransient<IRepository<User>, UsersRepository>()
            .AddTransient<IRepository<Child>, ChildsRepository>()
            .AddTransient<IRepository<ParentChild>, ParentChildsRepository>()
            .AddTransient<IRepository<Class>, ClassesRepository>()
            .AddTransient<IRepository<ClassChild>, ClassChildrensRepository>()
            .AddTransient<IRepository<Attendance>, AttendancesRepository>()
            .AddTransient<IRepository<Schedule>, SchedulesRepository>()
            ;
        
    }
}
