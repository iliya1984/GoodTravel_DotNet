using GT.DAL.Interfaces;
using GT.DAL.Interfaces.Configuration;

namespace GT.DAL.Configuration
{
    public abstract class DBSettings : IDbSettings
    {
        public string ConnectionString { get; private set; }
        public EDAL.DatabaseTechnology DatabaseTechnology { get; private set; }

        protected DBSettings(string connectionString, EDAL.DatabaseTechnology technology)
        {
            ConnectionString = connectionString;
            DatabaseTechnology = technology;
        }
    }
}