using System;
using System.Threading.Tasks;
using GS.Core.Api.Controllers;
using GS.Core.BLL.Entities.Enums;
using GS.Logging.Client.Interfaces;
using GS.Logging.Entities;
using GT.Geo.BLL.Interfaces;
using GT.Geo.Entities.Common;
using GT.Geo.Entities.Filters.Regions;
using Microsoft.AspNetCore.Mvc;

namespace GT.Geo.API.Controllers
{
    [Route("api/countries")]
    [GeoLoggable(ELogs.Layer.Api)]
    public class CountriesController : ApiController
    {
        private ICountryService _service;
        public CountriesController(ICountryService service, ILoggingFactory loggingFactory) : base(loggingFactory)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Lookup(string continentId)
        {
            try
            {
                var filter = new CountryFilter();
                filter.ContinentId = continentId;

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