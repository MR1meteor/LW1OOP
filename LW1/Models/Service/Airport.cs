public class Airport
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Code { get; set; }
    public int Runways { get; set; }
    public int SoldTickets { get; set; }
    public double AverageVisitors { get; set; }
    public double MonthlyIncome { get; set; }
    public int IncidentsCount { get; set; }

    public Airport()
    {
        Id = 0;
        Name = string.Empty;
        Code = 0;
        Runways = 0;
        SoldTickets = 0;
        AverageVisitors = 0d;
        MonthlyIncome = 0d;
        IncidentsCount = 0;
    }

    public Airport(string name)
    {
        Id = 0;
        Name = name;
        Code = 0;
        Runways = 0;
        SoldTickets = 0;
        AverageVisitors = 0d;
        MonthlyIncome = 0d;
        IncidentsCount = 0;
    }

    public Airport(string name, int code)
    {
        Id = 0;
        Name = name;
        Code = code;
        Runways = 0;
        SoldTickets = 0;
        AverageVisitors = 0d;
        MonthlyIncome = 0d;
        IncidentsCount = 0;
    }

    public Airport(int id, string name, int code, int runways, int soldTickets,
        double averageVisitors, double monthlyIncome, int incidentsCount)
    {
        Id = id;
        Name = name;
        Code = code;
        Runways = runways;
        SoldTickets = soldTickets;
        AverageVisitors = averageVisitors;
        MonthlyIncome = monthlyIncome;
        IncidentsCount = incidentsCount;
    }

    public override string ToString()
    {
        return $"{Id} | {Name} | {Code} | {Runways} | {SoldTickets} | {AverageVisitors} | {MonthlyIncome} | {IncidentsCount}";
    }
}