using GT.Geo;
using GT.Geo.Entities.Information;

namespace GT.Geo.Entities.Regions
{
    public class City : GeoEntity
    {
        public string CountryId { get; set; }

        public City(string id) : base(EGeo.EntityType.City, id) {}
    }
}