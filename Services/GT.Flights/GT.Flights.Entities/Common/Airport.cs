namespace GT.Flights.Entities.Common
{
    public class Airport : Entity
    {
        public int Id { get; set;}
        public string Code { get; set; }
        public City City { get; set; }
        public Contry County { get; set; }
    }
}