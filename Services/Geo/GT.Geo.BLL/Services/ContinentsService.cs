using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GT.Geo.BLL.Interfaces;
using GT.Geo.Entities.Regions;

namespace GT.Geo.BLL.Services
{
    public class ContinentsService : IContinentsService
    {
        public async Task<List<Continent>> GetAllAsync()
        {
            try
            {
                throw new Exception("temp");
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}