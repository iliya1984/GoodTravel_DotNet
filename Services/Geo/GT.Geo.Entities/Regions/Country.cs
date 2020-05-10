using GT.Geo;

namespace GT.Geo.Entities.Regions
{
    public class Country : GeoEntity
    {
        public string ContinentId { get; set; }

        public Country(string id) : base(EGeo.EntityType.Country, id) {}
    }
}