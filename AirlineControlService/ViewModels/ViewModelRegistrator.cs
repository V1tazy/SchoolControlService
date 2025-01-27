﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.ViewModels
{
    static class ViewModelRegistrator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
            .AddSingleton<AuthViewModel>()
            .AddSingleton<MainWindowViewModel>()
            .AddSingleton<ClassesViewModel>()
            .AddSingleton<PersonalAccountViewModel>()
            .AddSingleton<AdminViewModel>()
            .AddSingleton<AchivementPageViewModel>()
        ;
    }
}
