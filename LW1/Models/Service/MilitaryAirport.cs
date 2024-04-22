using LW1.Mementos;

namespace LW1.Models.Service;

public class MilitaryAirport : Airport, ICloneable
{
    public string MilitaryDistrict { get; set; }
    public bool HasAirDefence { get; set; }
    public int AircraftNumber { get; set; }

    public override bool IsValid => !String.IsNullOrWhiteSpace(Name) && Code >= 0 && Runways >= 0 &&
                                    IncidentsCount >= 0 && AircraftNumber >= 0;
    
    public MilitaryAirport() : base()
    {
        MilitaryDistrict = string.Empty;
        HasAirDefence = false;
        AircraftNumber = 0;
    }

    public MilitaryAirport(string name) : base(name)
    {
        MilitaryDistrict = string.Empty;
        HasAirDefence = false;
        AircraftNumber = 0;
    }

    public MilitaryAirport(string name, int code) : base(name, code)
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

    public MilitaryAirportMemento SaveStateToMemento()
    {
        return new MilitaryAirportMemento(Id, Name, Code, Runways, IncidentsCount, MilitaryDistrict, HasAirDefence, AircraftNumber);
    }

    public void GetStateFromMemento(MilitaryAirportMemento memento)
    {
        Id = memento.Id;
        Name = memento.Name;
        Code = memento.Code;
        Runways = memento.Runways;
        IncidentsCount = memento.IncidentsCount;
        MilitaryDistrict = memento.MilitaryDistrict;
        HasAirDefence = memento.HasAirDefence;
        AircraftNumber = memento.AircraftNumber;
    }
    
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}