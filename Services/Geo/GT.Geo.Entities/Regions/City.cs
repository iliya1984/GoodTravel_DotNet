using GT.Geo;

namespace GT.Geo.Entities.Regions
{
    public class City : GeoEntity
    {
        public string CityId { get; set; }
        public string CountryId { get; set; }

        public City() : base(EGeo.EntityType.City) {}
    }
}