using System;
using System.Collections.Generic;
using GS.Logging.Client.Interfaces;
using GT.DAL.Mongo;
using GT.DAL.Repositories;
using GT.Geo.DAL.Interfaces;
using GT.Geo.Entities.Regions;
using MongoDB.Driver;

namespace GT.Geo.DAL.Mongo.Repositories
{
    internal class ContinentMongoDBRepository : MongoDBRepository, IContinentRepository
    {
        [RepositoryRegistration(typeof(IContinentRepository))]
        public ContinentMongoDBRepository(MongoDBRepositoryToolkit toolkit)
         : base(toolkit)
        {
            
        }

        public List<Continent> GetAll()
        {
            try
            {
                return null;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}