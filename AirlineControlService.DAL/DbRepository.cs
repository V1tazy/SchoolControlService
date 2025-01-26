using AirlineControlService.DAL.Context;
using AirlineControlService.DAL.Entityes.Base;
using AirlineControlService.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.DAL
{
    class DbRepository<T> : IRepository<T> where T : Entity, new()
    {
        private readonly AirlineDb _db;
        private readonly DbSet<T> _Set;

        public bool AutoSaveChanges {  get; set; }


        public virtual IQueryable<T> items => _Set;

        public DbRepository(AirlineDb DB)
        {
            _db = DB;
            _Set = _db.Set<T>();
        }

        public T Add(T item)
        {
            if(item is null) throw new ArgumentNullException(nameof(item));
            _db.Entry(item).State = EntityState.Added;
            if (AutoSaveChanges)
            {
                _db.SaveChanges();
            }

            return item;
        }

        public async Task<T> AddAsync(T item, CancellationToken Cancel)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            _db.Entry(item).State = EntityState.Added;

            if (AutoSaveChanges)
            {
                await _db.SaveChangesAsync().ConfigureAwait(false);
            }

            return item;
        }


        public T Get(int id) => items.SingleOrDefault(item => item.Id == id);

        public async Task<T> GetAsync(int id, CancellationToken Cancel = default) => await items
           .SingleOrDefaultAsync(item => item.Id == id, Cancel)
           .ConfigureAwait(false);

        public void Remove(int id)
        {
            _db.Remove(new T { Id = id});

            if(AutoSaveChanges) 
                _db.SaveChanges();
        }

        public async Task RemoveAsync(int id, CancellationToken Cancel)
        {
            _db.Remove(new T { Id = id });

            if(AutoSaveChanges)
               await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);
        }

        public void Update(T item)
        {
            if(item is null) throw new ArgumentNullException(nameof(item));

            _db.Entry(item).State = EntityState.Modified;
            if(AutoSaveChanges)
                _db.SaveChanges();
        }

        public async Task UpdateAsync(T item, CancellationToken Cancel)
        {
            if(item is null) throw new ArgumentNullException( nameof(item));

            _db.Entry(item).State = EntityState.Modified;
            if(AutoSaveChanges)
                await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);

        }
    }
}
