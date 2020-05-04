using GT.Geo;

namespace GT.Geo.Entities.Regions
{
    public class Country : GeoEntity
    {
        public string ContinentId { get; set; }

        public Country() : base(EGeo.EntityType.Country) {}
    }
}