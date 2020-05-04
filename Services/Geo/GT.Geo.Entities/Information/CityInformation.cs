using System.Collections.Generic;

namespace GT.Geo.Entities.Information
{
    public class CityInformation
    {
        public string Id { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set;}
        public GeoLocation Location { get; set; }
        public TimeZone TimeZone { get; set; }
        public Electricity Electricity { get; set; }
        public List<Language> Languages { get; set; }

        public CityInformation()
        {
            Languages = new List<Language>();
        }
    }
}