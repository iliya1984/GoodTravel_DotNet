using System;
using System.Collections.Generic;
using GT.Geo.DAL.Interfaces;
using GT.Geo.Entities.Regions;

namespace GT.Geo.DAL.Repositories
{
    public class ContinentRepository : IContinentRepository
    {
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