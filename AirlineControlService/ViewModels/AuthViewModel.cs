using AirlineControlService.DAL.Entityes;
using AirlineControlService.Infrastructure.Commands;
using AirlineControlService.Interfaces;
using AirlineControlService.Services.Interface;
using AirlineControlService.VIewModels.Base;
using AirlineControlService.Views.Windows;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AirlineControlService.ViewModels
{
    internal class AuthViewModel : ViewModel
    {
        private readonly IAuthService _authService;

        #region defineValues

        private string _login;
        public string Login
        {
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

        private async void OnAuthCommandExecute(object p)
        {
            var user = await _authService.AuthUser(Login, Password);

            if (user != null)
            {
                Window window;
                if(user.Role.ToLower() == "admin")
                    window = new AdminWindow();
                else
                    window = new MainWindow();

                MessageBox.Show($"Добро пожаловать, {user.FirstName}!");
                App.Current.MainWindow.Close();
                window.Show();
            }
            else
            {
                // Неверные логин или пароль
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private bool CanAuthCommandExecute(object p)
        {
            return !string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password);
        }
        #endregion

        #region Constructor
        public AuthViewModel(IAuthService authService)
        {
            _authService = authService;
            AuthCommand = new LambdaCommand(OnAuthCommandExecute, CanAuthCommandExecute);
        }
        #endregion
    }
}
