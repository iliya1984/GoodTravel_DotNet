using System;
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
     [RepositoryRegistration(typeof(ICityRepository))]
    internal class CityMongoRepository : MongoDBRepository<DbCity>, ICityRepository
    {
        private const string CollectionName  = "Cities";

        public CityMongoRepository(MongoDBRepositoryToolkit toolkit) : base(toolkit, CollectionName)
        {
            
        }

        public async Task<DataGetResult<City>> GetByFilterAsync(CityFIlter filter)
        {
             try
            {
                var bson = new BsonDocument
                {
                    { "CountryId", new ObjectId(filter.CountryId.ToString()) }
                };

                var dbCities  = await Collection.FindAsync(bson);

                if(dbCities == null || false == dbCities.Any())
                {
                    return new DataGetResult<City>();
                }

                var entities = dbCities
                    .ToEnumerable()
                    .AsQueryable()
                    .Select(c => mapToEntity(c))
                    .ToList();

                return new DataGetResult<City>(entities);
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
               return new DataGetResult<City>(ex);
            }
        }

        private City mapToEntity(DbCity dbCity)
        {
            var city = new City(dbCity.Id);
            city.Name = dbCity.Name;
            city.Code = dbCity.Code;
            city.CountryId = dbCity.CountryId;
            return city;
        }
    }
}