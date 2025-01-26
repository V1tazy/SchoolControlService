using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AirlineControlService.DAL.Entityes;
using AirlineControlService.DAL.Repository;
using System.Threading;
using AirlineControlService.Interfaces;

namespace AirlineControlService.BLL.Services
{
    public class EnrolmentService : IEnrolmentService
    {
        private readonly IRepository<Child> _Childs;
        private readonly IRepository<User> _Users;
        private readonly IRepository<ParentChild> _ParentChilds;

        public IEnumerable<Child> Childs => _Childs.items;

        public EnrolmentService(IRepository<Child> childs, IRepository<User> users, IRepository<ParentChild> parentChilds)
        {
            _Childs = childs;
            _Users = users;
            _ParentChilds = parentChilds;
        }

        public async Task<Child> MakeEnrolment(
            string FirstName,
            string LastName,
            DateTime BirthDay,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int ParentId
        )
        {
            // Проверка существования родителя
            var parent = await _Users.items.FirstOrDefaultAsync(u => u.Id == ParentId).ConfigureAwait(false);
            if (parent is null)
                throw new ArgumentException("Родитель с указанным ID не найден.");

            // Создание нового ребёнка
            var child = new Child
            {
                FirstName = FirstName,
                LastName = LastName,
                BirthDay = BirthDay,
                CreatedAt = CreatedAt,
                UpdatedAt = UpdatedAt
            };

            // Добавление ребёнка в базу данных
            var addedChild = await _Childs.AddAsync(child, CancellationToken.None).ConfigureAwait(false);

            // Создание связи родителя и ребёнка
            var parentChild = new ParentChild
            {
                ParentId = ParentId,
                ChildId = addedChild.Id
            };

            // Добавление связи в базу данных
            await _ParentChilds.AddAsync(parentChild, CancellationToken.None).ConfigureAwait(false);

            return addedChild;
        }
    }
}
