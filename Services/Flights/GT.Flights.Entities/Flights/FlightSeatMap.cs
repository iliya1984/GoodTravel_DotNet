using System.Collections.Generic;

namespace GT.Flights.Entities.Flights
{
    public class FlightSeatMap 
    {
        public int SeatMapId { get; set; }
        public List<FlightSeat> Seats { get; set; }

        public FlightSeatMap()
        {
            Seats = new List<FlightSeat>();
        }
    }
}