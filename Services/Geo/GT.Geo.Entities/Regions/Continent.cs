using GT.Geo;

namespace GT.Geo.Entities.Regions
{
    public class Continent : GeoEntity
    {
        public string ContinentId { get; set; }

         public Continent() : base(EGeo.EntityType.Continent) {}
    }
}