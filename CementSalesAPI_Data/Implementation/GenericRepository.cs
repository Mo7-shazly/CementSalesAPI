using CementSalesAPI_Data.Data;
using CementSalesAPI_Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Data.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<int> Count(Expression<Func<T, bool>>? filter = null)
        {
            var count = 0;
            if (filter != null)
            {
                count = await _dbSet.CountAsync(filter);
            }
            else count = await _dbSet.CountAsync();
            return count;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<T> FindQueryable(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter);
        }
        public IQueryable<T> FindQueryable()
        {
            return _dbSet.AsQueryable();
        }
        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? predicate = null, string? include = null)
        {
            IQueryable<T> query = _dbSet;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (include != null)
            {
                foreach (var item in include.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<T> GetFirst(Expression<Func<T, bool>>? predicate = null, string? include = null)
        {
            IQueryable<T> query = _dbSet;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (include != null)
            {
                foreach (var item in include.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }

            return await query.SingleOrDefaultAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
