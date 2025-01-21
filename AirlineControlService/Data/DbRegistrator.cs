using AirlineControlService.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace AirlineControlService.Data
{
    static class DbRegistrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration Configuration) => services
            .AddDbContext<AirlineDb>(opt =>
            {
                var type = Configuration["Type"];

                switch (type)
                {
                    case null: throw new ArgumentNullException("Не определен тип бд");

                    default: throw new InvalidOperationException($"Тип подключения {type} не поддерживается");


                    case "MSSQL":
                        opt.UseSqlServer(Configuration.GetConnectionString(type));
                        break;
                    case "InMemory":
                        opt.UseInMemoryDatabase("Airline.db");
                        break;
                }
            })
            .AddTransient<DbInitializer>();
    }
}
