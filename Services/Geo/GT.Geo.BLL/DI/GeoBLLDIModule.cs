using Autofac;
using GS.Core.BLL.DI;
using GS.Core.DAL.DI;
using GS.Logging.Client.DI;
using GT.Geo.DAL.DI;
using Microsoft.Extensions.Configuration;

namespace GT.Geo.BLL.DI
{
    public class GeoBLLDIModule : Module
    {
        private IConfiguration _cofiguration;

        public GeoBLLDIModule(IConfiguration configuration)
        {
            _cofiguration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new LoggingClientDIModule(_cofiguration));
            builder.RegisterModule(new BLLDIModule(_cofiguration));
            builder.RegisterModule(new GeoDALDIModule(_cofiguration));
        }
    }
}