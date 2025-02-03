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
        private readonly IRepository<Schedule> _Schedule;
        private readonly IRepository<User> _User;
        private readonly IRepository<Child> _Child;


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

                if (user.Role.ToLower() == "admin")
                {
                    window = new AdminWindow
                    {
                        DataContext = new AdminViewModel(_Schedule, _User, _Child)
                    };
                }
                else
                {
                    window = new MainWindow
                    {
                        DataContext = new MainWindowViewModel(_Child, _Schedule, _User, user)
                    };
                }

                window.Show(); // Открываем новое окно

                // Закрываем текущее окно
                if (App.Current.MainWindow != null)
                {
                    App.Current.MainWindow.Close();
                }
                App.Current.MainWindow = window; // Назначаем новое главное окно
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }



        private bool CanAuthCommandExecute(object p)
        {
            return !string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password);
        }
        #endregion

        #region Constructor
        public AuthViewModel(IAuthService authService, IRepository<Schedule> Schedule, IRepository<User> Users, IRepository<Child> Childs)
        {
            _Schedule = Schedule;
            _User = Users;
            _Child = Childs;


            _authService = authService;
            AuthCommand = new LambdaCommand(OnAuthCommandExecute, CanAuthCommandExecute);
        }
        #endregion
    }
}
