using GS.Logging.Client.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GT.Api.Controllers
{
    public abstract class ApiController : ControllerBase
    {
        protected ILoggingClient Logger {get; private set;}

        protected ApiController(ILoggingFactory loggingFactory)
        {
            Logger = loggingFactory.GetAsyncLoggerByType(GetType());
        }
    }
}