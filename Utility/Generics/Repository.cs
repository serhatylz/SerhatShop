using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Utilities.Generics
{
    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        Task<T> ReadByIdAsync(object entityKey);
        Task<T> ReadFirstAsync(Expression<Func<T, bool>>? expression = null);
        Task<IEnumerable<T>> ReadManyAsync(Expression<Func<T, bool>>? expression = null);
        Task UpdateAsync(T entity);
        Task DeleteAsync(object entityKey);
        Task DeleteAsync(T entity);
    }

    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> _set;

        protected Repository(DbContext db)
        {

            _set = db.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await _set.AddAsync(entity);
        }

        public async Task DeleteAsync(object entityKey)
        {
            var entity = await ReadByIdAsync(entityKey);
            if (entity != null)
            {
                await DeleteAsync(entity);
            }
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => _set.Remove(entity));
        }

        public async Task<T> ReadByIdAsync(object entityKey)
        {
            return await _set.FindAsync(entityKey);
        }

        public async Task<T?> ReadFirstAsync(Expression<Func<T, bool>>? expression = null)
        {
            return expression != null
                ? await _set.FirstOrDefaultAsync(expression)
                : await _set.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> ReadManyAsync(Expression<Func<T, bool>>? expression = null)
        {
            return expression != null
                ? await _set.Where(expression).ToListAsync()
                : await _set.ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() => _set.Update(entity));
        }
    }
}
