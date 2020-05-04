using GT.Entities.Interfaces;

namespace GT.DAL.Interfaces
{
    public interface ICreateRepository<TEntity> where TEntity: IEntity
    {
         TEntity Create(TEntity entity);
    }
}