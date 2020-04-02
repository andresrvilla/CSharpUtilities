using CSharpUtilities.Entities.DataAccess.Interfaces;
using CSharpUtilities.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CSharpUtilities.Entities.DataAccess
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {
        public void Create(T entity)
        {
            Task.Run(() => CreateAsync(entity));
        }

        public void Delete(T entity)
        {
            Task.Run(() => DeleteAsync(entity));
        }

        public T GetById(Guid id)
        {
            return Task.Run(() => GetByIdAsync(id)).Result;
        }

        public IEnumerable<T> List()
        {
            return Task.Run(() => ListAsync()).Result;
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return Task.Run(() => ListAsync(predicate)).Result;
        }

        public void Update(T entity)
        {
            Task.Run(() => UpdateAsync(entity));
        }


        public abstract Task CreateAsync(T entity);

        public abstract Task DeleteAsync(T entity);

        public abstract Task<T> GetByIdAsync(Guid id);

        public abstract Task<IEnumerable<T>> ListAsync();

        public abstract Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> predicate);

        public abstract Task UpdateAsync(T entity);
    }
}
