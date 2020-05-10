using System;
using System.Threading.Tasks;
using GS.Core.BLL.Entities.Results;
using GS.Core.BLL.Extensions;
using GS.Core.BLL.Services;
using GS.Logging.Client.Interfaces;
using GS.Logging.Entities;
using GT.Geo.BLL.Interfaces;
using GT.Geo.DAL.Interfaces;
using GT.Geo.Entities.Common;
using GT.Geo.Entities.Filters.Regions;
using GT.Geo.Entities.Regions;

namespace GT.Geo.BLL.Services
{
    [BLLServiceRegistration(typeof(ICountryService))]
    [GeoLoggable(ELogs.Layer.BusinessLayer)] 
    public class CountryService : BLLService, ICountryService
    {
        private ICountryRepository _repository;

        public CountryService(ICountryRepository repository, ILoggingFactory loggingFactory) : base(loggingFactory)
        {
            _repository = repository;
        }

        public async Task<GetResult<Country>> GetByFilterAsync(CountryFilter filter)
        {
            try
            {
                var result = await _repository.GetByFilterAsync(filter);
                return result.ToBLLResult();
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
                return new GetResult<Country>(ex);
            };
        }
    }
}