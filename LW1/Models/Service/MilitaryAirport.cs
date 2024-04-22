namespace LW1.Models.Service;

public class MilitaryAirport : Airport
{
    public string MilitaryDistrict { get; set; }
    public bool HasAirDefence { get; set; }
    public int AircraftNumber { get; set; }

    public override bool IsValid => base.IsValid && AircraftNumber >= 0;
    
    public MilitaryAirport() : base()
    {
        MilitaryDistrict = string.Empty;
        HasAirDefence = false;
        AircraftNumber = 0;
    }
    
    public MilitaryAirport(string name, int code, int runways = default, int incidentsCount = default,
        string militaryDistrict = "", bool hasAirDefence = default, int aircraftNumber = default)
        : base(name, code, runways, incidentsCount)
    {
        MilitaryDistrict = militaryDistrict;
        HasAirDefence = hasAirDefence;
        AircraftNumber = aircraftNumber;
    }

    public override string GetAirportType()
    {
        return "Military";
    }

    public override string ToString()
    {
        return $"{Id} | {Name} | {Code}| {Runways} | {IncidentsCount} | {MilitaryDistrict} | {HasAirDefence} | {AircraftNumber}";
    }
    
}