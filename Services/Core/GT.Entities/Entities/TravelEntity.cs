using System;
using GT.Entities.Enums;

namespace GT.Entities.Entities
{
    public abstract class TravelEntity: Entity
    {
        public ETravel.EntityType TravelType { get; set;}
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Destination { get; set;}
    }
}