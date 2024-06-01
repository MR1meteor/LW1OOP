namespace LW1.Models.Service;

public class Transport
{
    public static int ObjectsCounter = 0;
    
    public int Id { get; set; }
    public string Model { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public string Route { get; set; }
    public int Mileage { get; set; }

    public Transport()
    {
        Id = 0;
        Model = string.Empty;
        Name = string.Empty;
        Surname = string.Empty;
        Patronymic = string.Empty;
        Route = string.Empty;
        Mileage = 0;
    }

    public Transport(string model, int mileage)
    {
        Id = 0;
        Model = model;
        Name = string.Empty;
        Surname = string.Empty;
        Patronymic = string.Empty;
        Route = string.Empty;
        Mileage = mileage;
    }

    public Transport(int id, string model, string name, string surname, string patronymic,
        string route, int mileage)
    {
        Id = id;
        Model = model;
        Name = name;
        Surname = surname;
        Patronymic = patronymic;
        Route = route;
        Mileage = mileage;
    }

    public override string ToString()
    {
        return $"{Id} | {Name} | {Model}| {Name} | {Surname} | {Patronymic} | {Route} | {Mileage} ";
    }
}