using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopApiP223.Repositories
{
    public interface IRepository<TEntity>where TEntity : class
    {
        Task AddAsync(TEntity entity);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> exp,params string[] includes);
        Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> exp, params string[] includes);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> exp, params string[] includes);
        void Remove(TEntity entity);
        int Commit();
        Task<int> CommitAsync();
    }
}
