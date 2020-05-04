using GT.Entities.Interfaces;

namespace GT.DAL.Interfaces.Repositories
{
    public interface IUpdateRepository<TEntity> where TEntity: IEntity
    {
         TEntity Update(TEntity entity);
    }
}