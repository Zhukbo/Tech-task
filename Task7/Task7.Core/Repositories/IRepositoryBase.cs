using System;
using System.Collections.Generic;
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
    }
}
