using LW1.Repositories.Interfaces;

namespace LW1.Repositories;

public class AirportRepository : IAirportRepository
{
    private List<Airport> airports = new();
    private int idCounter = 0;

    public Airport? Add(Airport airport)
    {
        airport.Id = ++idCounter;
        airports.Add(airport);
        return airports.FirstOrDefault(a => a.Id == idCounter);
    }

    public List<Airport> GetAll()
    {
        return airports;
    }

    public Airport? Get(int id)
    {
        return airports.FirstOrDefault(airport => airport.Id == id);
    }

    public Airport? Edit(Airport airport)
    {
        var editable = airports.FirstOrDefault(a => a.Id == airport.Id);
        if (editable == null)
        {
            return null;
        }
        
        var count = airports.IndexOf(editable);
        airports[count].Name = airport.Name;
        airports[count].Code = airport.Code;
        airports[count].Runways = airport.Runways;
        airports[count].SoldTickets = airport.SoldTickets;
        airports[count].AverageVisitors = airport.AverageVisitors;
        airports[count].MonthlyIncome = airport.MonthlyIncome;
        airports[count].IncidentsCount = airport.IncidentsCount;

        return airports[count];
    }

    public void Delete(int id)
    {
        var deletion = airports.FirstOrDefault(a => a.Id == id);
        if (deletion == null)
        {
            return;
        }
            
        airports.Remove(deletion);
    }
}