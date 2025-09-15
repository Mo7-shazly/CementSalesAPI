using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Data.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(Expression<Func<T,bool>>?predicate = null, string? include = null);
        Task<T> GetFirst(Expression<Func<T, bool>>? predicate = null, string? include = null);
        void Update(T entity);
        void Delete (T entity);
        Task Add (T entity);
        IQueryable<T> FindQueryable(Expression<Func<T, bool>> filter);
        IQueryable<T> FindQueryable();

        Task<int> Count(Expression<Func<T, bool>>? filter = null);
    }
}
