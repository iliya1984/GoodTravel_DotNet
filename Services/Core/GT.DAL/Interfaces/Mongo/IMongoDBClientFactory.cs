using GT.DAL.Mongo;
using MongoDB.Driver;

namespace GT.DAL.Interfaces.Mongo
{
    public interface IMongoDBClientFactory
    {
         IMongoClient CreateClient(MongoDBSettings settings);
    }
}