using GS.Logging.Entities;
using GS.Logging.Entities.Attributes;
using GS.Logging.Entities.Modules;

namespace GT.Geo.Entities.Common
{
    public class GeoLoggableAttribute : LoggableAttribute
    {
        public GeoLoggableAttribute(ELogs.Layer layerGroup) : base(new GeoLoggingModule(layerGroup))
        { }
    }
}