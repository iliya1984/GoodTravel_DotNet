using GT.DAL.Configuration;
using GT.DAL.Interfaces;

namespace GT.DAL.Mongo
{
    public class MongoDBSettings : DBSettings
    {
        public MongoDBSettings(string connectionString) : base(connectionString, EDAL.DatabaseTechnology.MongoDB)
        {
        }

        public string DatabaseName { get; set;}
    }
}