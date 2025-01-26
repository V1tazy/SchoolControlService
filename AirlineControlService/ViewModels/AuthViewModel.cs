using AirlineControlService.DAL.Entityes;
using AirlineControlService.Infrastructure.Commands;
using AirlineControlService.Interfaces;
using AirlineControlService.VIewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace AirlineControlService.ViewModels
{
    internal class AuthViewModel: ViewModel
    {

        private readonly IRepository<User> _userRepository;
        #region defineValues

        private string _login;
        public string Login {
            get => _login; 
            set => Set(ref _login, value);
        }

        private string _password;

        public string Password
        {
            get => _password;
            set => Set(ref _password, value);
        }
        #endregion


        #region CommandSection
        public ICommand AuthCommand { get; }

        private void OnAuthCommandExecute(object p)
        {
            MessageBox.Show("adsasd");
        }

        private bool CanAuthCommandExecute(object p)
        {
            if(Login != null && Password != null) return true;

            return false;
        }
        #endregion

        #region Constructor
        public AuthViewModel()
        {
            AuthCommand = new LambdaCommand(OnAuthCommandExecute, CanAuthCommandExecute);
        }

        #endregion
    }
}
