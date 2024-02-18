using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.EfCore.Repositories
{
    public class EfCoreGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;
        public EfCoreGenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //CountAsync(x=>!x.IsDeleted)
        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            //var result = await _dbContext
            //    .Set<TEntity>()
            //    .CountAsync(predicate);
            var result = await _dbContext
                .Set<TEntity>()
                .Where(predicate)
                .CountAsync();
            return result;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            var entities= await _dbContext.Set<TEntity>().ToListAsync();
            return entities;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            return entity;
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            var result = _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return result==null ? false : true;
        }
    }
}
