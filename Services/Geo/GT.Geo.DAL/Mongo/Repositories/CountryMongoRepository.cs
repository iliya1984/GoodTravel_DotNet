using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GS.Core.DAL.Entities.Results;
using GS.Core.DAL.Mongo;
using GS.Core.DAL.Repositories;
using GT.Geo.DAL.Interfaces;
using GT.Geo.DAL.Mongo.Entities;
using GT.Geo.Entities.Filters.Regions;
using GT.Geo.Entities.Regions;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GT.Geo.DAL.Mongo.Repositories
{
    [RepositoryRegistration(typeof(ICountryRepository))]
    internal class CountryMongoRepository : MongoDBRepository<DbCountry>, ICountryRepository
    {
        private const string CollectionName  = "Countries";
      
        public CountryMongoRepository(MongoDBRepositoryToolkit toolkit)
         : base(toolkit, CollectionName)
        {  }

        public async Task<DataGetResult<Country>> GetByFilterAsync(CountryFilter filter)
        {
            try
            {
                var bson = new BsonDocument
                {
                    { "ContinentId", new ObjectId(filter.ContinentId.ToString()) }
                };

                var dbCountries  = await Collection.FindAsync(bson);

                if(dbCountries == null || false == dbCountries.Any())
                {
                    return new DataGetResult<Country>();
                }

                var entities = dbCountries
                    .ToEnumerable()
                    .AsQueryable()
                    .Select(c => mapToEntity(c))
                    .ToList();

                return new DataGetResult<Country>(entities);
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
               return new DataGetResult<Country>(ex);
            }
        }

        private Country mapToEntity(DbCountry dbCountry)
        {
            var country = new Country(dbCountry.Id);
            country.Name = dbCountry.Name;
            country.Code = dbCountry.Code;
            country.ContinentId = dbCountry.ContinentId;
            return country;
        }

    }
}