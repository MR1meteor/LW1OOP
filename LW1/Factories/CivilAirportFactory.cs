using LW1.Models.Service;

namespace LW1.Factories;

public class CivilAirportFactory : AirportFactory
{
    public override Airport CreateAirport()
    {
        return new CivilAirport();
    }

    public override Airport CreateAirport(string name, int code)
    {
        return new CivilAirport(name, code);
    }

    public override Airport CreateAirport(string name, int code, int runways = default, int incidentsCount = default)
    {
        return new CivilAirport(name, code, runways, incidentsCount);
    }

    public Airport CreateAirport(string name, int code, int runways = default, int incidentsCount = default,
        int soldTickets = default, double averageVisitors = default, double monthlyIncome = default)
    {
        return new CivilAirport(name, code, runways, incidentsCount, soldTickets, averageVisitors, monthlyIncome);
    }
}