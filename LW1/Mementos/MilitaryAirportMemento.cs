namespace LW1.Mementos;

public class MilitaryAirportMemento
{
    int Id { get; }
    string Name { get; }
    int Code { get; }
    int Runways { get; }
    int IncidentsCount { get; }
    string MilitaryDistrict { get; }
    bool HasAirDefence { get; }
    int AircraftNumber { get; }

    public MilitaryAirportMemento(int id, string name, int code, int runways, int incidentsCount,
        string militaryDistrict, bool hasAirDefence, int aircraftNumber)
    {
        Id = id;
        Name = name;
        Code = code;
        Runways = runways;
        IncidentsCount = incidentsCount;
        MilitaryDistrict = militaryDistrict;
        HasAirDefence = hasAirDefence;
        AircraftNumber = aircraftNumber;
    }
}