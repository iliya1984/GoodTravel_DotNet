using System.Threading.Tasks;
using GT.Entities.Interfaces;

namespace GT.DAL.Interfaces.Repositories
{
    public interface IGetByIdAsyncRepository<TEntity> where TEntity: IEntity
    {
        Task<TEntity> GetByIdAsync(string id);
    }
}