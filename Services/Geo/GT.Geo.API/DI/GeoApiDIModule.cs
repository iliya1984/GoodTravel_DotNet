using Autofac;
using GS.Logging.Client.DI;
using GT.Geo.BLL.DI;
using Microsoft.Extensions.Configuration;

namespace GT.Geo.API.DI
{
    public class GeoApiDIModule : Module
    {
        private IConfiguration _cofiguration;

        public GeoApiDIModule(IConfiguration configuration)
        {
            _cofiguration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new LoggingClientDIModule(_cofiguration));
            builder.RegisterModule(new GeoBLLDIModule(_cofiguration));
        }
    }
}