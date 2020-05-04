using GT.Entities.Entities;
using GT.Geo.Entities.Interfaces;
using GT.Geo;

namespace GT.Geo.Entities.Regions
{
    public abstract class GeoEntity : Entity, IGeoEntity
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public EGeo.EntityType GeoEntityType { get; private set;}

        protected GeoEntity(EGeo.EntityType entityType)
        {
            GeoEntityType = entityType;
        }
    }
}