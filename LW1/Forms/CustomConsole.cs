using LW1.Presenters;
using LW1.Views;

namespace LW1.Forms;

public partial class NativeMethods
{
    [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "AllocConsole")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
    public static extern bool AllocConsole();
}

public class CustomConsole : IAirportView
{
    private AirportPresenter airportPresenter;

    private delegate void listener();
    private event listener listenerEvent;

    public void SetPresenter(AirportPresenter airportPresenter)
    {
        this.airportPresenter = airportPresenter;
    }

    public void ShowAirports(IEnumerable<Airport> airports)
    {
        foreach (var airport in airports)
        {
            Console.WriteLine(airport);
        }

        if (airports.Count() == 0)
        {
            Console.WriteLine("Аэропортов нет");
        }
    }

    public void Run()
    {
        NativeMethods.AllocConsole();
        listenerEvent += () =>
        {
            Console.WriteLine("Список команд:");
            Console.WriteLine("1. Показать список аэропортов");
            Console.WriteLine("2. Добавить аэропорт");
            Console.WriteLine("3. Изменить аэропорт");
            Console.WriteLine("4. Удалить аэропорт");

            var command = Console.ReadLine();
            switch (command)
            {
                case "1":
                    airportPresenter.ShowAirports();
                    break;
                case "2":
                    airportPresenter.AddAirport();
                    break;
                case "3":
                    airportPresenter.ChangeAirport();
                    break;
                case "4":
                    Console.WriteLine("Введите id удаляемого аэропорта");
                    airportPresenter.RemoveAirport(Int32.Parse(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Введите номер команды из списка");
                    listenerEvent.Invoke();
                    break;
            }
        };
        listenerEvent.Invoke();
    }

    public Airport AddingAirport {
        get
        {
            var airport = new Airport();
            
            Console.WriteLine("Введите название аэропорта");
            airport.Name = Console.ReadLine();
            Console.WriteLine("Введите код аэропорта");
            airport.Code = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество полос аэропорта");
            airport.Runways = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество проданных билетов в аэропорте");
            airport.SoldTickets = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите среднее количество посетителей аэропорта");
            airport.AverageVisitors = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ежемесячную прибыль аэропорта");
            airport.MonthlyIncome = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество инцидетов в аэропорте");
            airport.IncidentsCount = Int32.Parse(Console.ReadLine());

            return airport;
        }
        set
        {
            Console.WriteLine(value);
            listenerEvent.Invoke();
        }
    }
    public Airport ChangingAirport { 
        get
        {
            var airport = new Airport();
            
            Console.WriteLine("Введите название аэропорта");
            airport.Name = Console.ReadLine();
            Console.WriteLine("Введите код аэропорта");
            airport.Code = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество полос аэропорта");
            airport.Runways = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество проданных билетов в аэропорте");
            airport.SoldTickets = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите среднее количество посетителей аэропорта");
            airport.AverageVisitors = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ежемесячную прибыль аэропорта");
            airport.MonthlyIncome = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество инцидетов в аэропорте");
            airport.IncidentsCount = Int32.Parse(Console.ReadLine());

            return airport;
        }
        set
        {
            Console.WriteLine(value);
            listenerEvent.Invoke();
        }
    }
}