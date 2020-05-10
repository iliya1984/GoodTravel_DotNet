using System.Collections.Generic;
using System.Threading.Tasks;
using GT.Geo.Entities.Regions;

namespace GT.Geo.BLL.Interfaces
{
    public interface IContinentsService
    {
        Task<List<Continent>> GetAllAsync();
    }
}