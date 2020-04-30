
using GT.Geo.Entities.Regions;
using GT.Entities.Entities;

namespace GT.Flights.Entities.Common
{
    public class Airport : Entity
    {
        public int Id { get; set;}
        public string Code { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
    }
}