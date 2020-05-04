using GS.Logging.Client.Interfaces;
using GT.DAL.Interfaces.Configuration;
using GT.DAL.Interfaces.Mongo;
using MongoDB.Driver;

namespace GT.DAL.Mongo
{
    public class MongoDBRepositoryToolkit
    {
        public IConfigurationManager ConfigurationManager { get; set; }
        public IMongoDBClientFactory MongoClientFactory { get; set;}
        public ILoggingFactory LoggingFactory { get; set;}
    }
}