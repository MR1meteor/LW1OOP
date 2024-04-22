namespace LW1.Mementos;

public class CivilAirportMemento
{
    int Id { get; }
    string Name { get; }
    int Code { get; }
    int Runways { get; }
    int IncidentsCount { get; }
    public int SoldTickets { get; set; }
    public double AverageVisitors { get; set; }
    public double MonthlyIncome { get; set; }

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