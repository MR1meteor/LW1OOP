namespace LW1.Models.Service;

public abstract class Airport
{
    public static int ObjectsCounter = 0;
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int Code { get; set; }
    public int Runways { get; set; }
    public int IncidentsCount { get; set; }
    public virtual bool IsValid => !String.IsNullOrWhiteSpace(Name) && Code >= 0 && Runways >= 0 && IncidentsCount >= 0;

    protected Airport()
    {
        Id = 0;
        Name = string.Empty;
        Code = 0;
        Runways = 0;
        IncidentsCount = 0;
    }

    protected Airport(string name, int code, int runways = default, int incidentsCount = default)
    {
        Id = 0;
        Name = name;
        Code = code;
        Runways = runways;
        IncidentsCount = incidentsCount;
    }

    public abstract string GetAirportType();
    
    public override string ToString()
    {
        return $"{Id} | {Name} | {Code}| {Runways} | {IncidentsCount}";
    }
}