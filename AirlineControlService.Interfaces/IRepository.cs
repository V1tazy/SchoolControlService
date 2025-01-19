using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Interfaces
{
    public interface IRepository<T> where T: class, IEntity, new()
    {
        IQueryable<T> Items { get; }

        T Get(int id);
        Task<T> GetAsync(int id, CancellationToken Cancel = default);

        T Add(T item);
        Task<T> AddAsync(int id, CancellationToken Cancel = default);

        void Update(T item);
        Task UpdateAsync(int id, CancellationToken Cancel = default);

        void Remove(int id);
        Task RemoveAsync(int id, CancellationToken Cancel = default);
    }
}
