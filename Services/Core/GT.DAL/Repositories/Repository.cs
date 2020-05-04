using GS.Logging.Client.Interfaces;
using GT.DAL.Interfaces.Configuration;
using GT.DAL.Interfaces.Repositories;

namespace GT.DAL.Repositories
{
    public abstract class Repository : IRepository
    {
        public IDbSettings Settings { get; private set;}
        protected ILoggingClient Logger {get; private set;}

        protected Repository(IConfigurationManager configurationManager, ILoggingFactory loggingFactory)
        {
             Settings = configurationManager.GetSettings();
            Logger = loggingFactory.GetAsyncLoggerByType(GetType()); 
        }
    }
}