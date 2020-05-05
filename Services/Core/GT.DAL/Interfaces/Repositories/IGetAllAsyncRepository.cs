using GT.Entities.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GT.DAL.Interfaces.Repositories
{
    public interface IGetAllAsyncRepository<TEntity> where TEntity: IEntity
    {
        Task<List<TEntity>> GetAllAsync();
    }
}