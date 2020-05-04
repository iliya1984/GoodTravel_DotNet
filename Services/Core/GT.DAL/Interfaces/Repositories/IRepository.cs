using GT.DAL.Interfaces.Configuration;

namespace GT.DAL.Interfaces.Repositories
{
    public interface IRepository
    {
         IDbSettings Settings { get; }
    }
}