namespace LW1.Models.Db;

public class DbTransport
{
    public int Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public string Route { get; set; }
    public int Mileage { get; set; }
}