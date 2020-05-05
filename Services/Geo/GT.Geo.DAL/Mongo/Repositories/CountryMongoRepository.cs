using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GT.DAL.Mongo;
using GT.DAL.Repositories;
using GT.Geo.DAL.Interfaces;
using GT.Geo.DAL.Mongo.Entities;
using GT.Geo.Entities.Filters.Regions;
using GT.Geo.Entities.Regions;

namespace GT.Geo.DAL.Mongo.Repositories
{
    public class CountryMongoRepository : MongoDBRepository<DBCountry>, ICountryRepository
    {
        private const string CollectionName  = "Countries";
        

        [RepositoryRegistration(typeof(ICountryRepository))]
        public CountryMongoRepository(MongoDBRepositoryToolkit toolkit)
         : base(toolkit, CollectionName)
        {  }

        public async Task<List<Country>> GetByFilterAsync(CountryFilter filter)
        {
            try
            {
                return null;
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
                return EmptyResult<Country>();
            }
        }
    }
}