using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GS.Core.BLL.Entities.Results;
using GS.Core.BLL.Extensions;
using GS.Core.BLL.Interfaces.Services;
using GS.Core.BLL.Services;
using GS.Core.DAL.Entities.Results;
using GS.Core.DAL.Interfaces.Repositories;
using GS.Logging.Client.Interfaces;
using GT.Geo.BLL.Interfaces;
using GT.Geo.DAL.Interfaces;
using GT.Geo.Entities.Regions;

namespace GT.Geo.BLL.Services
{
    [BLLServiceRegistration(typeof(IContinentService))]
    public class ContinentService : BLLService, IContinentService
    {
        private IContinentRepository _repository;
        public ContinentService(IContinentRepository repository, ILoggingFactory loggingFactory) : base(loggingFactory)
        { 
            _repository = repository;
        }

        public async Task<GetResult<Continent>> GetAllAsync()
        {
            try
            {
                var result = await _repository.GetAllAsync();
                return result.ToBLLResult();
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
                return new GetResult<Continent>(ex);
            };
        }
    }
}