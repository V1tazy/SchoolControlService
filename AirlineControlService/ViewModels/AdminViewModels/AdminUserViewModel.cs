using AirlineControlService.DAL.Entityes;
using AirlineControlService.Infrastructure.Commands;
using AirlineControlService.Interfaces;
using AirlineControlService.VIewModels.Base;
using System.Windows.Input;

namespace AirlineControlService.ViewModels.AdminViewModels
{
    internal class AdminUserViewModel: ViewModel
    {
        #region Define repository

        private readonly IRepository<User> _Users;

        private IObservable<User> _UsersList;

        public IObservable<User> UsersList
        {
            get => _UsersList;
            set => Set(ref  _UsersList, value);
        }
        #endregion

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

        #region Construction
        public AdminUserViewModel(IRepository<User> users)
        {
            _Users = users;

            AddCommand = new LambdaCommand(OnAddUserCommand, CanAddCommand);
            EditCommand = new LambdaCommand(OnEditUserCommand, CanEditCommand);
            RemoveCommand = new LambdaCommand(OnRemoveUserCommand, CanRemoveCommand);
        }
        #endregion
    }
}
