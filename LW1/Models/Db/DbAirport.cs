namespace LW1.Db;

public class DbAirport
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Code { get; set; }
    public int Runways { get; set; }
    public int SoldTickets { get; set; }
    public double AveragePassengers { get; set; }
    public int MonthlyIncome { get; set; }
    public int IncidentsCount { get; set; }
}