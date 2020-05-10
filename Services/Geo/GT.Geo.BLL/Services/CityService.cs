using System;
using System.Threading.Tasks;
using GS.Core.BLL.Entities.Results;
using GS.Core.BLL.Extensions;
using GS.Core.BLL.Services;
using GS.Logging.Client.Interfaces;
using GT.Geo.BLL.Interfaces;
using GT.Geo.DAL.Interfaces;
using GT.Geo.Entities.Filters.Regions;
using GT.Geo.Entities.Regions;

namespace GT.Geo.BLL.Services
{
    [BLLServiceRegistration(typeof(ICityService))] 
    public class CityService : BLLService, ICityService
    {
        private ICityRepository _repository;

        public CityService(ICityRepository repository, ILoggingFactory loggingFactory) : base(loggingFactory)
        {
            _repository = repository;
        }

        public async Task<GetResult<City>> GetByFilterAsync(CityFIlter filter)
        {
            try
            {
                var result = await _repository.GetByFilterAsync(filter);
                return result.ToBLLResult();
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
                return new GetResult<City>(ex);
            };
        }
    }
}