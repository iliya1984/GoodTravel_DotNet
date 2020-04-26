namespace GT.Flights.Entities.Common
{
    public class Airport : Entity
    {
        public int Id { get; set;}
        public string Code { get; set; }
        public AirportCity City { get; set; }
        public AirportContry County { get; set; }
    }
}