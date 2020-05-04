namespace GT.Geo.DAL.Interfaces
{
    public interface IRepositoryFactory
    {
        ICityRepository CreateCityRepository();
        ICountryRepository CreateCountryRepository();
        IContinentRepository CreateContinentRepository();
    }
}