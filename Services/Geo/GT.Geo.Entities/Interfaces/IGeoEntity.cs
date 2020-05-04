using GT.Entities.Interfaces;
using GT.Geo;

namespace GT.Geo.Entities.Interfaces
{
    public interface IGeoEntity : IEntity
    {
        EGeo.EntityType GeoEntityType { get; }
        string Code { get; set; }
        string Name { get; set; }
    }
}