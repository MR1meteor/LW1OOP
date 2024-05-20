namespace LW1.Models.Service;

public class AirportsStorage
{
    public List<Airport> airports;

    public Airport[] Airports
    {
        set => airports = new List<Airport>(value);
        get => airports.ToArray();
    }

    public AirportsStorage()
    {
        airports = new List<Airport>();
    }
    
    public void AddAirport(string name, int code, int runways, int soldTickets, double averageVisitors, double monthlyIncome,
        int incidentsCount)
    {
        airports.Add(new Airport
        {
            Id = airports.Max(airport => airport.Id),
            Name = name,
            Code = code,
            Runways = runways,
            SoldTickets = soldTickets,
            AverageVisitors = averageVisitors,
            MonthlyIncome = monthlyIncome,
            IncidentsCount = incidentsCount
        });
    }

    public void RemoveAirport(int id)
    {
        var deletion = airports.FirstOrDefault(airport => airport.Id == id);
        
        if (deletion == null)
        {
            return;
        }

        airports.Remove(deletion);
    }

    public void UpdateAirport(Airport newAirport)
    {
        var existedAirport = airports.FirstOrDefault(airport => airport.Id == airport.Id);

        if (existedAirport != null)
        {
            airports.Remove(existedAirport);
        }

        newAirport.Id = airports.Max(airport => airport.Id);
        airports.Add(newAirport);
    }
    
    private static AirportsStorage instance;
    public static AirportsStorage Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new AirportsStorage();
            }

            return instance;
        }
    }
}