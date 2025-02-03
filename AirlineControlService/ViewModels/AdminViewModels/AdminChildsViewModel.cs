using AirlineControlService.DAL.Entityes;
using AirlineControlService.Interfaces;
using AirlineControlService.VIewModels.Base;
using System.Windows.Input;

namespace AirlineControlService.ViewModels.AdminViewModels
{
    internal class AdminChildsViewModel: ViewModel
    {
        #region Define Repository
        private readonly IRepository<Child> _Childs;
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

        #region Constructor
        public AdminChildsViewModel(IRepository<Child> childs)
        {
            _Childs = childs;
        }
        #endregion
    }
}
