using GT.Entities.Entities;

namespace GT.Flights.Entities.Common
{
    public class Airline: Entity
    {
        public int AirlineId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}