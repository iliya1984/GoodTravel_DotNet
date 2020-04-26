using System.Collections.Generic;

namespace GT.Flights.Entities.Seats
{
    public class SeatPricing
    {
        public double BasicPrice { get; set; }
        public List<SeatPricingItem> Items { get; set;}
    }
}