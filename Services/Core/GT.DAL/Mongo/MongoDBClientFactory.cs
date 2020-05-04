using System;
using GS.Logging.Client.Interfaces;
using GT.DAL.Interfaces.Mongo;
using MongoDB.Driver;

namespace GT.DAL.Mongo
{
    internal class MongoDBClientFactory : IMongoDBClientFactory
    {
        private Func<MongoDBSettings, IMongoClient> _factory;
        private ILoggingClient _logger;

        public MongoDBClientFactory(Func<MongoDBSettings, IMongoClient> facory, ILoggingFactory loggingFactory)
        {
            _factory = facory;
            _logger = loggingFactory.GetAsyncLoggerByType<MongoDBClientFactory>();
        }

        public IMongoClient CreateClient(MongoDBSettings settings)
        {
            try
            {
                return _factory.Invoke(settings);
            }
            catch(Exception ex)
            {
                _logger.Error(ex);
                return null;
            }
        }
    }
}