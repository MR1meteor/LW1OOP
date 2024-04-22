namespace LW1.Mementos;

public class CivilAirportMemento
{
    public int Id { get; }
    public string Name { get; }
    public int Code { get; }
    public int Runways { get; }
    public int IncidentsCount { get; }
    public int SoldTickets { get; }
    public double AverageVisitors { get; }
    public double MonthlyIncome { get; }

    public CivilAirportMemento(int id, string name, int code, int runways, int incidentsCount,
        int soldTickets, double averageVisitors, double monthlyIncome)
    {
        Id = id;
        Name = name;
        Code = code;
        Runways = runways;
        IncidentsCount = incidentsCount;
        SoldTickets = soldTickets;
        AverageVisitors = averageVisitors;
        MonthlyIncome = monthlyIncome;
    }
}