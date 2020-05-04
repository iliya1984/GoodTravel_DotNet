using System.Collections.Generic;
using GT.Entities.Interfaces;

namespace GT.DAL.Interfaces
{
    public interface IGetByFilterRepository<TFilter, TEntity> where TEntity : IEntity
    {
         List<TEntity> GetByFilter(TFilter filter);
    }
}