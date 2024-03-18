namespace LW1.Models.Service;

public class CivilAirport : Airport
{
    public int SoldTickets { get; set; }
    public double AverageVisitors { get; set; }
    public double MonthlyIncome { get; set; }

    public override bool IsValid => !String.IsNullOrWhiteSpace(Name) && Code >= 0 && Runways >= 0 &&
                                    IncidentsCount >= 0 && SoldTickets >= 0 && AverageVisitors >= 0 &&
                                    MonthlyIncome >= 0;

    public CivilAirport() : base()
    {
        
    }

    public CivilAirport(string name) : base(name)
    {
        SoldTickets = 0;
        AverageVisitors = 0d;
        MonthlyIncome = 0d;
    }

    public CivilAirport(string name, int code) : base(name, code)
    {
        SoldTickets = 0;
        AverageVisitors = 0d;
        MonthlyIncome = 0d;
    }

    public CivilAirport(string name, int code, int runways = default, int incidentsCount = default,
        int soldTickets = default, double averageVisitors = default, double monthlyIncome = default)
        : base(name, code, runways, incidentsCount)
    {
        SoldTickets = soldTickets;
        AverageVisitors = averageVisitors;
        MonthlyIncome = monthlyIncome;
    }
    
    public override string GetAirportType()
    {
        return "Civil";
    }

    public override string ToString()
    {
        return $"{Id} | {Name} | {Code}| {Runways} | {IncidentsCount} | {SoldTickets} | {AverageVisitors} | {MonthlyIncome}";
    }
}