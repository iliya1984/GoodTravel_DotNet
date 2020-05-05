using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GT.Geo.DAL.Mongo.Entities
{
    public class DBCountry
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
   
        [BsonElement("Code")]
        [BsonRequired]
        public string Code { get; set; }

        [BsonElement("Name")]
        [BsonRequired]
        public string Name { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ContinentId { get; set; }
    }
}