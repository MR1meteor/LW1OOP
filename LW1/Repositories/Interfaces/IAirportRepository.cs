using LW1.Models.Db;
using LW1.Models.Service;

namespace LW1.Repositories.Interfaces;

public interface IAirportRepository
{
    Task<List<Airport>> GetAll();
    Task<Airport> GetById(int id);
    Task<Airport> Add(DbAirport dbAirport);
    Task<Airport> Update(DbAirport dbAirport);
    Task Delete(int id);
}