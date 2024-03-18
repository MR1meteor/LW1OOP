using LW1.Models.Service;

namespace LW1.Factories;

public class MilitaryAirportFactory : AirportFactory
{
    public override Airport CreateAirport()
    {
        return new MilitaryAirport();
    }

    public override Airport CreateAirport(string name, int code)
    {
        return new MilitaryAirport(name, code);
    }

    public override Airport CreateAirport(string name, int code, int runways = default, int incidentsCount = default)
    {
        return new MilitaryAirport(name, code, runways, incidentsCount);
    }

    public Airport CreateAirport(string name, int code, int runways = default, int incidentsCount = default,
        string militaryDistrict = "", bool hasAirDefence = default, int aircraftNumber = default)
    {
        return new MilitaryAirport(name, code, runways, incidentsCount, militaryDistrict, hasAirDefence, aircraftNumber);
    }
}