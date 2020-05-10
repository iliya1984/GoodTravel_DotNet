using GT.Geo;

namespace GT.Geo.Entities.Regions
{
    public class Continent : GeoEntity
    {
         public Continent(string id) : base(EGeo.EntityType.Continent, id) {}
    }
}