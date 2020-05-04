namespace GT.DAL.Interfaces.Configuration
{
    public interface IDbSettings
    {
         string ConnectionString { get; }
         EDAL.DatabaseTechnology DatabaseTechnology { get; }
    }
}