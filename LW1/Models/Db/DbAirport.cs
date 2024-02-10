namespace LW1.Models.Db;

public class DbAirport
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Code { get; set; }
    public int Runways { get; set; }
    public int SoldTickets { get; set; }
    public double AverageVisitors { get; set; }
    public double MonthlyIncome { get; set; }
    public int IncidentsCount { get; set; }
}