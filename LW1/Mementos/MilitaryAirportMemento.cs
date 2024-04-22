namespace LW1.Mementos;

public class MilitaryAirportMemento
{
    public int Id { get; }
    public string Name { get; }
    public int Code { get; }
    public int Runways { get; }
    public int IncidentsCount { get; }
    public string MilitaryDistrict { get; }
    public bool HasAirDefence { get; }
    public int AircraftNumber { get; }

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