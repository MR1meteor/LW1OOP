using LW1.Models.Service;

namespace LW1.Factories;

public abstract class AirportFactory
{
    public abstract Airport CreateAirport();
    public abstract Airport CreateAirport(string name, int code);
    public abstract Airport CreateAirport(string name, int code, int runways = default, int incidentsCount = default);
}