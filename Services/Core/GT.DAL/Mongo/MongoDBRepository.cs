using GT.DAL.Interfaces;
using MongoDB.Driver;
using GS.Logging.Client;
using GS.Logging.Client.Interfaces;
using GT.DAL.Interfaces.Repositories;
using GT.DAL.Repositories;
using System.Collections.Generic;

namespace GT.DAL.Mongo
{
    public abstract class MongoDBRepository<DBEntity>: Repository
    {
       
        protected IMongoClient Client { get; private set; } 
        protected IMongoDatabase Database { get; private set; }
        protected IMongoCollection<DBEntity> Collection { get; set; }

        protected MongoDBRepository(MongoDBRepositoryToolkit toolkit, string collectionName)
            : base(toolkit.ConfigurationManager, toolkit.LoggingFactory)
        {
            var mongoDbSettings = (MongoDBSettings)Settings;

            Client = toolkit.MongoClientFactory.CreateClient(mongoDbSettings);
            Database = Client.GetDatabase(mongoDbSettings.DatabaseName);
            Collection = Database.GetCollection<DBEntity>(collectionName); 
        }

        protected List<TEntity> EmptyResult<TEntity>()
        {
            return new List<TEntity>();
        }
    }
}