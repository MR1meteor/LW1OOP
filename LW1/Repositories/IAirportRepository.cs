using LW1.Db;

namespace LW1.Repositories;

public interface IAirportRepository
{
    Task<DbAirport> GetById(int id);
}