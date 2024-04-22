using LW1.Models.Service;

namespace LW1.Factories;

public class AirportFlyweightFactory
{
    private Dictionary<string, Airport> flyweights = new();

    public Airport GetAirport(string name, int code, int runways, int incidentsCount, string type)
    {
        string key = $"{name}_{code}_{type}";

        if (flyweights.ContainsKey(key))
        {
            return flyweights[key];
        }
        else
        {
            Airport flyweight;

            if (type == "Civil")
            {
                flyweight = new CivilAirport(name, code, runways, incidentsCount);
            }
            else if (type == "Military")
            {
                flyweight = new MilitaryAirport(name, code, runways, incidentsCount);
            }
            else
            {
                throw new ArgumentException("Invalid airport type");
            }

            flyweights.Add(key, flyweight);
            return flyweight;
        }
    }
}