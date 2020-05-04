using GT.Entities.Interfaces;

namespace GT.DAL.Interfaces.Repositories
{
    public interface IGetByIdRepository<TEntity> where TEntity: IEntity
    {
        TEntity GetById(string id);
    }
}