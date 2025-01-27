using AirlineControlService.DAL.Entityes;
using AirlineControlService.Interfaces;
using AirlineControlService.VIewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AirlineControlService.ViewModels.AdminViewModels
{
    internal class AdminSchedulesViewModel: ViewModel
    {
        private readonly IRepository<Schedule> _Schedules;

        #region Command.Define

        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand RemoveCommand { get; }

        #endregion

        #region Command.Condition

        private bool CanAddCommand(object p)
        {
            return true;
        }

        private bool CanEditCommand(object p)
        {
            return true;
        }

        private bool CanRemoveCommand(object p)
        {
            return true;
        }
        #endregion
        #region Command.Functional

        private void OnAddUserCommand(object p)
        {

        }

        private void OnEditUserCommand(object p)
        {

        }

        private void OnRemoveUserCommand(object p)
        {

        }
        #endregion


        public AdminSchedulesViewModel(IRepository<Schedule> Schedules)
        {
            _Schedules = _Schedules;
        }
    }
}
