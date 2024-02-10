using LW1.Models.Service;

namespace LW1.Services.Interfaces;

public interface IAirportService
{
    Task<List<Airport>> GetAll();
    Task<Airport> GetById(int id);
    Task<Airport> Add(Airport airport);
    Task<Airport> Update(Airport airport);
    Task Delete(int id);
}