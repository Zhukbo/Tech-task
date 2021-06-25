using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Task7.Core.Entities;
using Task7.Core.Repositories;

namespace Task7.DAL.Repositories
{
    public class RepositoryBase<TEntity, TPrimaryKey> : IRepositoryBase<TEntity, TPrimaryKey> where TEntity : EntityBase<TPrimaryKey> where TPrimaryKey : struct
    {
        private readonly ApplicationContext _context;

        public async Task Delete(TEntity entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public Task Delete(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Get(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public Task<TPrimaryKey> Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
