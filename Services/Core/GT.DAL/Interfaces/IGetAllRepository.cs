using GT.Entities.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace GT.DAL.Interfaces
{
    public interface IGetAllRepository<TEntity> where TEntity: IEntity
    {
        List<TEntity> GetAll();
    }
}