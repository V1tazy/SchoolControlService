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

    }
}
