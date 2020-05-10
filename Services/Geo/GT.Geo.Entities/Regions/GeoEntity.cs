using GT.Geo.Entities.Interfaces;
using GT.Geo;
using GS.Core.Entities.Entities;

namespace GT.Geo.Entities.Regions
{
    public abstract class GeoEntity : EntityWithStringID, IGeoEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public EGeo.EntityType GeoEntityType { get; private set;}

        protected GeoEntity(EGeo.EntityType entityType, string id) : base(id)
        {
            GeoEntityType = entityType;
        }
    }
}