using AirlineControlService.DAL.Entityes;
using AirlineControlService.Infrastructure.Commands;
using AirlineControlService.Interfaces;
using AirlineControlService.VIewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AirlineControlService.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private readonly IRepository<User> _Users;
        private readonly IRepository<Child> _Childs;
        private readonly IRepository<Schedule> _Schedules;
        private readonly User _CurrentUser;

        private string _username = "default_user";

        public string Username
        {
            get => _username;
            set => Set(ref _username, value);
        }

        private string _title = "Журнал";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private ViewModel _CurrentViewModel = null;

        public ViewModel CurrentViewModel
        {
            get => _CurrentViewModel;
            set => Set(ref _CurrentViewModel, value);
        }

        public ICommand AchiveSelectCommand { get; }
        public ICommand ScheduleSelectCommand {get;}
        public ICommand ChildSelectCommand { get; }
        public ICommand PersonalSelectCommand { get; }

        private void OnAchiveSelectCommand(object p)
        {
            Title = "Достижения";
            CurrentViewModel = new AchivementPageViewModel();
        }

        private void OnScheduleSelectCommand(object p) 
        {
            Title = "Расписание";
            CurrentViewModel = new ClassesViewModel();
        }

        private void OnChildSelectCommand(object p)
        {
            Title = "Дети";
            CurrentViewModel = new ChildVIewModel();
        }

        private void OnPersonalSelectCommand(object p)
        {
            Title = "Личный кабинет";
            CurrentViewModel = new PersonalAccountViewModel();
        }

        public MainWindowViewModel(IRepository<Child> Childs, IRepository<Schedule> Schedules, IRepository<User> Users, User CurrentUser)
        {
            _Childs = Childs;
            _Schedules = Schedules;
            _Users = Users;
            _CurrentUser = CurrentUser;
            Username = "Текущий пользователь: " +_CurrentUser.Name;

            AchiveSelectCommand = new LambdaCommand(OnAchiveSelectCommand);
            ScheduleSelectCommand = new LambdaCommand(OnScheduleSelectCommand);
            ChildSelectCommand = new LambdaCommand(OnChildSelectCommand);
            PersonalSelectCommand = new LambdaCommand(OnPersonalSelectCommand);
        }
    }
}
