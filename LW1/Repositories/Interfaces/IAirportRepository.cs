namespace LW1.Repositories.Interfaces;

public interface IAirportRepository
{
    Airport? Add(Airport airport);
    List<Airport> GetAll();
    Airport? Get(int id);
    Airport? Edit(Airport airport);
    void Delete(int id);
}