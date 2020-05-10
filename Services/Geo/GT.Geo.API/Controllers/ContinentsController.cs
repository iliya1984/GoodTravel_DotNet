using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using GS.Logging.Client.Interfaces;
using GT.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GT.Geo.API.Controllers
{
    public class ExceptionActionResult : IActionResult
    {
        private List<Exception> _exceptions;

        public ExceptionActionResult(Exception exception)
        {
            _exceptions =new List<Exception>{ exception };
        }

        public ExceptionActionResult(List<Exception> exceptions)
        {
            _exceptions = exceptions;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var exceptionResponses = _exceptions.Select(e => toExceptionResponse(e)).ToList();
            var objectReulst = new ObjectResult(exceptionResponses);
            objectReulst.StatusCode = (int)HttpStatusCode.InternalServerError;
            await objectReulst.ExecuteResultAsync(context);
        }

        private ExceptionResponse toExceptionResponse(Exception e)
        {
            var response = new ExceptionResponse
            {
                ExceptionMessage = e.Message,
                StackTrace = e.StackTrace,
                ExceptionType = e.GetType().Name
            };

            if(e.InnerException != null)
            {
                response.InnerException = toExceptionResponse(e.InnerException);
            }

            return response;
        }
    }

    public class ExceptionResponse
    {
        public string ExceptionMessage { get; set; }
        public string ExceptionType { get; set; }
        public string StackTrace { get; set; }
        public ExceptionResponse InnerException { get; set;}
    }

    public class CustomError
    {
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set;}
    }

    public class ContinentsController : ControllerBase //: ApiController
    {
        // public ContinentsController(ILoggingFactory loggingFactory) : base(loggingFactory)
        // { }

        [HttpGet]
        [Route("api/continents/{id}")]
        public IActionResult GetById(string id)
        {

                        throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/continents")]
        public IActionResult GetAll()
        {
            var innerException = new Exception("inner error");
            var exception = new Exception("error", innerException);
            var result = new ExceptionActionResult(exception);
      
           
            return result;

        }
    }
}