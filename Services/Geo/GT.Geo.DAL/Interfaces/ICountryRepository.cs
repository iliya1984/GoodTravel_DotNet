using GT.DAL.Interfaces;
using GT.Geo.Entities.Filters.Regions;
using GT.Geo.Entities.Regions;

namespace GT.Geo.DAL.Interfaces
{
    public interface ICountryRepository: IGetByFilterRepository<CountryFilter, Country>
    {
         
    }
}