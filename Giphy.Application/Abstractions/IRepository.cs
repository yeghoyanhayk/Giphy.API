using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Giphy.Application.Abstractions
{
    public interface IRepository<TEntity>
    {
        void Delete(object id);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes);
        Task InsertAsync(TEntity entity);
        Task SaveAsync();
        void Update(TEntity entityToUpdate);
    }
}