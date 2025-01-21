using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Interfaces
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> items { get; }

        T Get(int id);
        Task<T> GetAsync(int id);

        T Add(T item);

        Task<T> AddAsync(T item);

        T Update(T item);
        Task<T> UpdateAsync(T item);

        T Remove(int id);
        Task<T> RemoveAsync(int id);
    }
}
