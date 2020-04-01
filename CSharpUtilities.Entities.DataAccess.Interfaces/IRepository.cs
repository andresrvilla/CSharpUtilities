using CSharpUtilities.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpUtilities.Entities.DataAccess.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        T GetById(Guid id);

        IEnumerable<T> List();

        IEnumerable<T> List(Expression<Func<T, bool>> predicate);

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
