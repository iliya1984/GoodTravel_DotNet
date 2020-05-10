using System;
using System.Threading.Tasks;
using GS.Core.Api.Controllers;
using GS.Core.BLL.Entities.Enums;
using GS.Logging.Client.Interfaces;
using GT.Geo.BLL.Interfaces;
using GT.Geo.Entities.Filters.Regions;
using Microsoft.AspNetCore.Mvc;

namespace GT.Geo.API.Controllers
{
   [Route("api/cities")]
    public class CitiesController : ApiController
    {
        private ICityService _service;
        public CitiesController(ICityService service, ILoggingFactory loggingFactory) : base(loggingFactory)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Lookup(string countryId)
        {
            try
            {
                var filter = new CityFilter();
                filter.CountryId = countryId;

                var result = await _service.GetByFilterAsync(filter);
                if(result.Status == BusinessOperationStatus.Failure)
                {
                    return Exception(result);
                }

                return Ok(result.Entities);
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
                return Exception(ex);
            }
        }
    }
}