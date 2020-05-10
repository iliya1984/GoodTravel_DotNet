using GS.Core.BLL.Interfaces.Services;
using GT.Geo.Entities.Filters.Regions;
using GT.Geo.Entities.Regions;

namespace GT.Geo.BLL.Interfaces
{
    public interface ICountryService : IGetByFilterAsyncService<CountryFilter, Country>
    {
         
    }
}