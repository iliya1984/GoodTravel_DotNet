using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GS.Logging.Client.Interfaces;
using GS.Core.DAL.Mongo;
using GS.Core.DAL.Repositories;
using GT.Geo.DAL.Interfaces;
using GT.Geo.DAL.Mongo.Entities;
using GT.Geo.Entities.Regions;
using MongoDB.Driver;
using GS.Core.DAL.Entities.Results;

namespace GT.Geo.DAL.Mongo.Repositories
{
     [RepositoryRegistration(typeof(IContinentRepository))]
    internal class ContinentMongoRepository : MongoDBRepository<DbContinent>, IContinentRepository
    {
        private const string CollectionName  = "Continents";
        
        public ContinentMongoRepository(MongoDBRepositoryToolkit toolkit)
         : base(toolkit, CollectionName)
        {  }

        public async Task<DataGetResult<Continent>> GetAllAsync()
        {
            try
            {
                var dbContinents = await Collection.FindAsync(f => true);
                
                if(dbContinents == null || false == dbContinents.Any())
                {
                    return new DataGetResult<Continent>();
                }

                var entities = dbContinents.ToEnumerable().Select(c => mapToEntity(c));
                return new DataGetResult<Continent>(entities);

            }
            catch(Exception ex)
            {
                Logger.Error(ex);
                return new DataGetResult<Continent>(ex);
            }
        }

        private Continent mapToEntity(DbContinent dbContinent)
        {
            var continent = new Continent(dbContinent.Id);
            continent.Name = dbContinent.Name;
            continent.Code = dbContinent.Code;
            return continent;
        }
    }
}