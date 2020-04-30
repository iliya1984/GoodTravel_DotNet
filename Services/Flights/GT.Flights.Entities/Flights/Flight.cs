using System;
using GT.Entities.Entities;
using GT.Flights.Entities.Common;
using GT.Flights.Entities.Seats;
using System.Collections.Generic;

namespace GT.Flights.Entities.Flights
{
    public class Flight : TravelEntity 
    {
        public long FlightId { get; set;}
        public string FlightNumber { get; set;}
        public Airport DepartureAirport { get; set;}
        public Airport ArrivalAirport { get; set; }
        public DateTime DepartureDate { get; set;}
        public DateTime ArrivalDate { get; set;}
        public Airline Airline { get; set; }
        public SeatPricing SeatPricing { get; set; }
        public List<string> Remarks { get; set; }
    }
}