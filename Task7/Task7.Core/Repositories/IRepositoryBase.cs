using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task7.Core.Entities;

namespace Task7.Core.Repositories
{
    public interface IRepositoryBase<TEntity, TPrimaryKey> where TEntity : EntityBase<TPrimaryKey> where TPrimaryKey: struct
    {
        Task Delete(TEntity entity);
        Task Delete(TPrimaryKey id);
        Task<TPrimaryKey> Insert(TEntity entity);
        Task<TEntity> Get(TPrimaryKey id);
        Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> expression);

        IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> expression); 
    }
}
