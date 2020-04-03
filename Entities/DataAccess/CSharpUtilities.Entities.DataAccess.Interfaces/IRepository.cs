using CSharpUtilities.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CSharpUtilities.Entities.DataAccess.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        T GetById(Guid id);

        Task<T> GetByIdAsync(Guid id);

        IEnumerable<T> List();

        Task<IEnumerable<T>> ListAsync();

        IEnumerable<T> List(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> predicate);

        void Create(T entity);

        Task CreateAsync(T entity);

        void Delete(T entity);

        Task DeleteAsync(T entity);

        void Update(T entity);

        Task UpdateAsync(T entity);
    }
}
