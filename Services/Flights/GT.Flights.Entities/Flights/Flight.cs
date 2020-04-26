using System;
using GT.Entities.Entities;
using GT.Flights.Entities.Common;

namespace GT.Flights.Entities.Flights
{
    public class Flight : TravelEntity 
    {
        public int FlightId { get; set;}
        public string FlightNumber { get; set;}
        public Airport DepartureAirport { get; set;}
        public Airport ArrivalAirport { get; set; }
        public DateTime DepartureDate { get; set;}
        public DateTime ArrivalDate { get; set;}
        public Airline Airline { get; set; }
    }
}