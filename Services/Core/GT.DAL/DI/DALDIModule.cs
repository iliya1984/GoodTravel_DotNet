using System;
using Autofac;
using GS.Logging.Client.DI;
using GS.Logging.Client.Interfaces;
using GT.DAL.Configuration;
using GT.DAL.Interfaces.Configuration;
using GT.DAL.Interfaces.Mongo;
using GT.DAL.Mongo;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace GT.DAL.DI
{
    public class DALDIModule : Module
    {
        private IConfiguration _configuration;

        public DALDIModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new LoggingClientDIModule(_configuration));

            builder
                .Register(c =>
                {
                    var loggingFactory = c.Resolve<ILoggingFactory>();
                    try
                    {
                        return new ConfigurationManager(_configuration, loggingFactory);
                    }
                    catch (Exception ex)
                    {
                        loggingFactory.GetAsyncLoggerByType<DALDIModule>().Error(ex);
                        return null;
                    }
                })
                .As<IConfigurationManager>();

            builder
               .Register(c =>
               {
                   var loggingFactory = c.Resolve<ILoggingFactory>();
                   try
                   {
                       Func<MongoDBSettings, IMongoClient> factory = settings =>
                       {
                           return new MongoClient(settings.ConnectionString);
                       };

                       return new MongoDBClientFactory(factory, loggingFactory);
                   }
                   catch (Exception ex)
                   {
                       loggingFactory.GetAsyncLoggerByType<DALDIModule>().Error(ex);
                       return null;
                   }
               })
               .As<IMongoDBClientFactory>();

            builder
           .Register(c =>
           {
               var loggingFactory = c.Resolve<ILoggingFactory>();
               try
               {
                   var mongoDBClientFactory = c.Resolve<IMongoDBClientFactory>();
                    var configurationManager = c.Resolve<IConfigurationManager>();

                   return new MongoDBRepositoryToolkit
                   {
                       MongoClientFactory = mongoDBClientFactory,
                       LoggingFactory = loggingFactory,
                       ConfigurationManager = configurationManager
                   };
               }
               catch (Exception ex)
               {
                   loggingFactory.GetAsyncLoggerByType<DALDIModule>().Error(ex);
                   return null;
               }
           })
           .AsSelf();

            var repositoryRegistry = new RepositoryRegistery(builder);
            repositoryRegistry.Register();
        }
    }
}