using GT.Entities.Enums;
using GT.Flights.Entities.Enums;

namespace GT.Flights.Entities.Flights
{
    public class FlightSeat
    {
        public int SeatId { get; set;}
        public short Row { get; set;}
        public ECoreFlights.SeatColumn Column { get; set;}        
        public ECoreFlights.SeatType Type { get; set; }
        public EFlights.SeatStatus Status { get; set; }
        public string Code { get; set; }
    }
}