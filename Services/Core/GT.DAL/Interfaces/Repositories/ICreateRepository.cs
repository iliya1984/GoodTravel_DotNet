using GT.Entities.Interfaces;

namespace GT.DAL.Interfaces.Repositories
{
    public interface ICreateRepository<TEntity> where TEntity: IEntity
    {
         TEntity Create(TEntity entity);
    }
}