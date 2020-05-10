

using System;
using System.Threading.Tasks;
using GS.Core.Api.Controllers;
using GS.Core.BLL.Entities.Enums;
using GS.Logging.Client.Interfaces;
using GS.Logging.Entities;
using GT.Geo.BLL.Interfaces;
using GT.Geo.Entities.Common;
using Microsoft.AspNetCore.Mvc;

namespace GT.Geo.API.Controllers
{
    [Route("api/continents")]
    [GeoLoggable(ELogs.Layer.Api)]
    public class ContinentsController : ApiController
    {
        private IContinentService _service;

        public ContinentsController(IContinentService service, ILoggingFactory loggingFactory) : base(loggingFactory)
        { 
            _service = service;
        }

       
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var result = await _service.GetAllAsync();
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