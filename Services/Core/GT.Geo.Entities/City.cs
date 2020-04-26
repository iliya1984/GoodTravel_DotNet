using System;
using GT.Core.Entities.Entities;

namespace GT.Geo.Entities
{
    public class City : GeoRegion
    {
        public int CityId { get; set;}
        public int CountryId { get; set;}
    }
}
