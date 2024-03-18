using LW1.Exceptions;
using LW1.Mapping;
using LW1.Models.Db;
using LW1.Models.Service;
using LW1.Repositories.Interfaces;
using LW1.Services.Interfaces;

namespace LW1.Services;

public class AirportService : IAirportService
{
    private IAirportRepository airportRepository;

    public AirportService(IAirportRepository airportRepository)
    {
        this.airportRepository = airportRepository;
    }
    
    public async Task<List<Airport>> GetAll()
    {
        return (await airportRepository.GetAll()).ToList();
    }

    public async Task<int> GetCount()
    {
        return await airportRepository.GetCount();
    }
    
    public async Task<Airport> GetById(int id)
    {
        return await airportRepository.GetById(id);
    }
    
    public async Task<Airport> Add(Airport airport)
    {
        if (!airport.IsValid)
        {
            throw new InvalidValidationException<Airport>(airport, "Invalid validation");
        }

        var dbAirport = GetResolvedDbAirport(airport);
        return await airportRepository.Add(dbAirport);
    }

    public async Task<Airport> Update(Airport airport)
    {
        if (!airport.IsValid)
        {
            throw new InvalidValidationException<Airport>(airport, "Invalid validation");
        }

        var dbAirport = GetResolvedDbAirport(airport);
        return await airportRepository.Update(dbAirport);
    }

    public async Task Delete(int id)
    {
        await airportRepository.Delete(id);
    }

    private DbAirport GetResolvedDbAirport(Airport airport)
    {
        switch (airport.GetAirportType())
        {
            case "Civil":
                return ((CivilAirport)airport).MapToDb();
            case "Military":
                return ((MilitaryAirport)airport).MapToDb();
            default:
                return new DbAirport();
        }
    }
}