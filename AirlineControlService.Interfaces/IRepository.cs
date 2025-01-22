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
        Task<T> GetAsync(int id, CancellationToken Cancel);

        T Add(T item);
        Task<T> AddAsync(T item, CancellationToken Cancel);

        void Update(T item);
        Task UpdateAsync(T item, CancellationToken Cancel);

        void Remove(int id);
        Task RemoveAsync(int id, CancellationToken Cancel);
    }
}
