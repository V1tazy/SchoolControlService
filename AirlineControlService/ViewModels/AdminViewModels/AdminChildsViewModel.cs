using AirlineControlService.DAL.Entityes;
using AirlineControlService.Infrastructure.Commands;
using AirlineControlService.Interfaces;
using AirlineControlService.Services.AdminServices;
using AirlineControlService.VIewModels.Base;
using System.Windows.Input;

namespace AirlineControlService.ViewModels.AdminViewModels
{
    internal class AdminChildsViewModel: ViewModel
    {
        #region Define Repository
        private readonly IRepository<Child> _Childs;
        private readonly AdminChildService _childService;
        #endregion

        private Child _currentChild;

        public Child CurrentChild
        {
            get => _currentChild;

            set => Set(ref _currentChild, value);
        }

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
            if (CurrentChild != null) 
                return true;

            return false;
        }

        private bool CanRemoveCommand(object p)
        {

            if (CurrentChild != null) 
                return true;

            return false;
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

        #region Constructor
        public AdminChildsViewModel(IRepository<Child> childs)
        {
            _Childs = childs;


            AddCommand = new LambdaCommand(OnAddUserCommand);
            EditCommand = new LambdaCommand(OnEditUserCommand);
            RemoveCommand = new LambdaCommand(OnRemoveUserCommand);
        }
        #endregion
    }
}
