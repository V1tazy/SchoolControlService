using System.Threading.Tasks;
using AirlineControlService.DAL.Entityes;
using AirlineControlService.DAL.Repository;
using AirlineControlService.Interfaces;
using AirlineControlService.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace AirlineControlService.BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly IRepository<User> _Users;

        public AuthService(IRepository<User> users)
        {
            _Users = users;
        }

        public async Task<User> AuthUser(string username, string password)
        {
            // Поиск пользователя по логину
            var user = await _Users.items
                .FirstOrDefaultAsync(u => u.Login == username)
                .ConfigureAwait(false);

            if (user == null)
                return null;

            // Проверка пароля (пока без хэширования)
            if (user.Password == password)
            {
                return user;
            }

            return null; // Неверный пароль
        }
    }
}
