using GT.Entities.Enums;

namespace GT.Flights.Entities.Seats
{
    public class SeatPricingItem
    {
        public ECoreFlights.SeatType Type { get; set; } 
        public short AvailableSeats { get; set; }
        public double PriceDifference { get; set;}
    }
}