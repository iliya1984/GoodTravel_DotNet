using Autofac;
using GS.Core.DAL.DI;
using GS.Logging.Client.DI;
using Microsoft.Extensions.Configuration;

namespace GT.Geo.DAL.DI
{
    public class GeoDALDIModule : Module
    {
        private IConfiguration _cofiguration;

        public GeoDALDIModule(IConfiguration configuration)
        {
            _cofiguration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new LoggingClientDIModule(_cofiguration));
            builder.RegisterModule(new DALDIModule(_cofiguration));
        }
    }
}