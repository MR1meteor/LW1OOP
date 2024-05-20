namespace LW1.Models.Service;

public class AirportsStorage
{
    public List<Airport> Airports { get; set; } = new List<Airport>();

    public void AddAirport(string name, int code, int runways, int soldTickets, double averageVisitors, double monthlyIncome,
        int incidentsCount)
    {
        Airports.Add(new Airport
        {
            Id = Airports.Max(airport => airport.Id),
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
        var deletion = Airports.FirstOrDefault(airport => airport.Id == id);
        
        if (deletion == null)
        {
            return;
        }

        Airports.Remove(deletion);
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