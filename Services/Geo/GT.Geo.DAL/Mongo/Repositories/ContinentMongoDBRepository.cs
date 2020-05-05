using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GS.Logging.Client.Interfaces;
using GT.DAL.Mongo;
using GT.DAL.Repositories;
using GT.Geo.DAL.Interfaces;
using GT.Geo.DAL.Mongo.Entities;
using GT.Geo.Entities.Regions;
using MongoDB.Driver;

namespace GT.Geo.DAL.Mongo.Repositories
{
    internal class ContinentMongoDBRepository : MongoDBRepository<DbContinent>, IContinentRepository
    {
        private const string CollectionName  = "Continents";
        

        [RepositoryRegistration(typeof(IContinentRepository))]
        public ContinentMongoDBRepository(MongoDBRepositoryToolkit toolkit)
         : base(toolkit, CollectionName)
        {  }

        public async Task<List<Continent>> GetAllAsync()
        {
            try
            {
                var dbContinents = await Collection.FindAsync(f => true);
                
                if(dbContinents == null || false == dbContinents.Any())
                {
                    return EmptyResult<Continent>();
                }

                return dbContinents.ToEnumerable().Select(c => mapToEntity(c)).ToList();
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
                return EmptyResult<Continent>();
            }
        }

        private Continent mapToEntity(DbContinent dbContinent)
        {
            var continent = new Continent();
            continent.Id  = dbContinent.Id;
            continent.Name = dbContinent.Name;
            continent.Code = dbContinent.Code;
            return continent;
        }
    }
}