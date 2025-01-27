using AirlineControlService.DAL.Entityes;
using AirlineControlService.Interfaces;
using AirlineControlService.VIewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AirlineControlService.ViewModels
{
    internal class MainWindowViewModel: ViewModel
    {
        private readonly IRepository<User> _Users;

        private string _username = "default_user";

        public string Username
        {
            get => _username;
            set => Set(ref _username, value);
        }

        private string _title = "Журнал приколист";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        public MainWindowViewModel()
        {
        }
    }
}
