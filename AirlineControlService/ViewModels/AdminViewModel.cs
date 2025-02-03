using AirlineControlService.DAL.Entityes;
using AirlineControlService.Infrastructure.Commands;
using AirlineControlService.Interfaces;
using AirlineControlService.ViewModels.AdminViewModels;
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
    class AdminViewModel: ViewModel
    {
        #region Command


        private readonly IRepository<Schedule> _Schedule;
        private readonly IRepository<User> _User;
        private readonly IRepository<Child> _Child;

        private ViewModel _CurrentModel;

        public ViewModel CurrentModel
        {
            get => _CurrentModel;
            set => Set(ref _CurrentModel, value);
        }

        public ICommand ScheduleSelectCommand { get; }
        public ICommand ChildSelectCommand { get; }
        public ICommand UserSelectCommand { get; }

        private void OnScheduleSelectCommand(object p) 
        {
            CurrentModel = new AdminSchedulesViewModel(_Schedule);
        }

        private void OnChildSelectCommand(object p) 
        {
            CurrentModel = new AdminChildsViewModel(_Child);
        }

        private void OnUserSelectCommand(object p) 
        {

            CurrentModel = new AdminUserViewModel(_User);
        }

        #endregion



        public AdminViewModel(IRepository<Schedule> Schedule, IRepository<User> Users, IRepository<Child> Childs) 
        {

            _Schedule = Schedule;
            _Child = Childs;
            _User = Users;

            ScheduleSelectCommand = new LambdaCommand(OnScheduleSelectCommand);
            ChildSelectCommand = new LambdaCommand(OnChildSelectCommand);
            UserSelectCommand = new LambdaCommand(OnUserSelectCommand);
        }
    }
}
