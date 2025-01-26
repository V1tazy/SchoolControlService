using AirlineControlService.BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Services
{
    static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IEnrolmentService, EnrolmentService>()
            .AddTransient<IScheduleService, ScheduleService>();
    }
}
