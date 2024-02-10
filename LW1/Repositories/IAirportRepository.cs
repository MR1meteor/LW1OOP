using LW1.Db;

namespace LW1.Repositories;

public interface IAirportRepository
{
    Task<List<DbAirport>> GetAll();
    Task<DbAirport> GetById(int id);
}