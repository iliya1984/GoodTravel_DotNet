using GT.Entities.Interfaces;

namespace GT.DAL.Interfaces
{
    public interface IGetByIdRepository<TEntity> where TEntity: IEntity
    {
        TEntity GetById(string id);
    }
}