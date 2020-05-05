using System.Collections.Generic;
using System.Threading.Tasks;
using GT.Entities.Interfaces;

namespace GT.DAL.Interfaces.Repositories
{
    public interface IGetByFilterAsyncRepository<TFilter, TEntity> where TEntity : IEntity
    {
         Task<List<TEntity>> GetByFilterAsync(TFilter filter);
    }
}