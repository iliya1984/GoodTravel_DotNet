using GS.Core.DAL.Interfaces.Repositories;
using GT.Geo.Entities.Filters.Regions;
using GT.Geo.Entities.Regions;

namespace GT.Geo.DAL.Interfaces
{
    public interface ICityRepository: IGetByFilterAsyncRepository<CityFilter, City>
    {
         
    }
}