

using GT.Geo.Entities.Interfaces;
using GT.Geo.Entities.Regions;

namespace GT.Flights.Entities.Common
{
    public class Airport : ICityLocatable, ICountryLocatable
    {
        public int Id { get; set;}
        public string Code { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }
    }
}