using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.ViewModels
{
    class ViewModelLocator
    {
        public AuthViewModel AuthViewModel => App.Services.GetRequiredService<AuthViewModel>();
        public MainWindowViewModel MainWindowViewModel => App.Services.GetRequiredService<MainWindowViewModel>();

        public AdminViewModel AdminViewModel = App.Services.GetRequiredService<AdminViewModel>();

        public ClassesViewModel ClassesViewModel = App.Services.GetRequiredService<ClassesViewModel>();

        public PersonalAccountViewModel PersonalAccountViewModel = App.Services.GetRequiredService<PersonalAccountViewModel>();

        public AchivementPageViewModel AchivementPageViewModel = App.Services.GetRequiredService<AchivementPageViewModel>();

    }
}
