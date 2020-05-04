using GT.Geo;

namespace GT.Geo.Entities.Regions
{
    public class Country : GeoEntity
    {
        public string CountryId { get; set; }
        public string ContinentId { get; set; }

        public Country() : base(EGeo.EntityType.Country) {}
    }
}