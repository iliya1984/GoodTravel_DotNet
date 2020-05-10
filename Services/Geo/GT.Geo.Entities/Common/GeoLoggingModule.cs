using GS.Core.Entities.Enums;
using GS.Logging.Entities;
using GS.Logging.Entities.Modules;

namespace GT.Geo.Entities.Common
{
    public class GeoLoggingModule : LoggingModule
    {
        private const string ModuleName = "Geo";

        public GeoLoggingModule(ELogs.Layer layerGroup)
        {
            Group = ESystemManagement.ModuleGroup.GoodTravel.ToString();
            Name = ModuleName;
            Layer = new LoggingLayer
            {
                Name = $"{ModuleName}{layerGroup.ToString()}",
                Group = layerGroup
            };
        }
    }
}