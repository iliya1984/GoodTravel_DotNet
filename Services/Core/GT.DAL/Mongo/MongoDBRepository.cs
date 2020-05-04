using GT.DAL.Interfaces;
using MongoDB.Driver;
using GS.Logging.Client;
using GS.Logging.Client.Interfaces;
using GT.DAL.Interfaces.Repositories;
using GT.DAL.Repositories;

namespace GT.DAL.Mongo
{
    public abstract class MongoDBRepository : Repository
    {
       
        protected IMongoClient Client { get; private set; } 
        protected IMongoDatabase Database { get; private set; }
        
        protected MongoDBRepository(MongoDBRepositoryToolkit toolkit)
            : base(toolkit.ConfigurationManager, toolkit.LoggingFactory)
        {
            var mongoDbSettings = (MongoDBSettings)Settings;

            Client = toolkit.MongoClientFactory.CreateClient(mongoDbSettings);
            Database = Client.GetDatabase(mongoDbSettings.DatabaseName); 
        }

    }
}