using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Task7.Core.Entities;
using Task7.Core.Repositories;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Task7.DAL.Repositories
{
    public class RepositoryBase<TEntity, TPrimaryKey> : IRepositoryBase<TEntity, TPrimaryKey> where TEntity : EntityBase<TPrimaryKey> where TPrimaryKey : struct
    {
        private readonly ApplicationContext _context;

        public RepositoryBase(ApplicationContext context)
        {
            _context = context;
        }

        public virtual async Task Delete(TEntity entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Delete(TPrimaryKey id)
        {
            _context.Remove(id);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<TEntity> Get(TPrimaryKey id)
        {     
            return await _context.FindAsync<TEntity>(id);      
        }

        public IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression);
        }

        public virtual async Task<TPrimaryKey> Insert(TEntity entity)
        {
            await _context.AddAsync<TEntity>(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().Where(expression).FirstOrDefaultAsync();
        }
    }
}
