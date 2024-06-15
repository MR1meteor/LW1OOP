using LW1.Presenters;
using LW1.Views;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace LW1.Forms;

public static class WinConsole
{
    public static void Initialize(bool alwaysCreateNewConsole = true)
    {
        bool consoleAttached = true;
        if (alwaysCreateNewConsole
            || (AttachConsole(ATTACH_PARRENT) == 0
            && Marshal.GetLastWin32Error() != ERROR_ACCESS_DENIED))
        {
            consoleAttached = AllocConsole() != 0;
        }

        if (consoleAttached)
        {
            InitializeOutStream();
            InitializeInStream();
        }
    }

    private static void InitializeOutStream()
    {
        var fs = CreateFileStream("CONOUT$", GENERIC_WRITE, FILE_SHARE_WRITE, FileAccess.Write);
        if (fs != null)
        {
            var writer = new StreamWriter(fs) { AutoFlush = true };
            Console.SetOut(writer);
            Console.SetError(writer);
        }
    }

    private static void InitializeInStream()
    {
        var fs = CreateFileStream("CONIN$", GENERIC_READ, FILE_SHARE_READ, FileAccess.Read);
        if (fs != null)
        {
            Console.SetIn(new StreamReader(fs));
        }
    }

    private static FileStream CreateFileStream(string name, uint win32DesiredAccess, uint win32ShareMode,
                            FileAccess dotNetFileAccess)
    {
        var file = new SafeFileHandle(CreateFileW(name, win32DesiredAccess, win32ShareMode, IntPtr.Zero, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, IntPtr.Zero), true);
        if (!file.IsInvalid)
        {
            var fs = new FileStream(file, dotNetFileAccess);
            return fs;
        }
        return null;
    }

    #region Win API Functions and Constants
    [DllImport("kernel32.dll",
        EntryPoint = "AllocConsole",
        SetLastError = true,
        CharSet = CharSet.Auto,
        CallingConvention = CallingConvention.StdCall)]
    private static extern int AllocConsole();

    [DllImport("kernel32.dll",
        EntryPoint = "AttachConsole",
        SetLastError = true,
        CharSet = CharSet.Auto,
        CallingConvention = CallingConvention.StdCall)]
    private static extern UInt32 AttachConsole(UInt32 dwProcessId);

    [DllImport("kernel32.dll",
        EntryPoint = "CreateFileW",
        SetLastError = true,
        CharSet = CharSet.Auto,
        CallingConvention = CallingConvention.StdCall)]
    private static extern IntPtr CreateFileW(
          string lpFileName,
          UInt32 dwDesiredAccess,
          UInt32 dwShareMode,
          IntPtr lpSecurityAttributes,
          UInt32 dwCreationDisposition,
          UInt32 dwFlagsAndAttributes,
          IntPtr hTemplateFile
        );

    private const UInt32 GENERIC_WRITE = 0x40000000;
    private const UInt32 GENERIC_READ = 0x80000000;
    private const UInt32 FILE_SHARE_READ = 0x00000001;
    private const UInt32 FILE_SHARE_WRITE = 0x00000002;
    private const UInt32 OPEN_EXISTING = 0x00000003;
    private const UInt32 FILE_ATTRIBUTE_NORMAL = 0x80;
    private const UInt32 ERROR_ACCESS_DENIED = 5;

    private const UInt32 ATTACH_PARRENT = 0xFFFFFFFF;

    #endregion
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
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("-----");
        Console.WriteLine("Список аэропортов:");
        foreach (var airport in airports)
        {
            Console.WriteLine(airport);
        }

        if (airports.Count() == 0)
        {
            Console.WriteLine("Нет аэропортов");
        }

        Console.WriteLine("-----");
        listenerEvent.Invoke();
    }

    public void Run()
    {
        WinConsole.Initialize();
        listenerEvent += () =>
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Список команд:");
            Console.WriteLine("1. Посмотреть аэропорты");
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
                    Console.WriteLine("Введите id аэропорта");
                    airportPresenter.RemoveAirport(Int32.Parse(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Введите номер команды из списка ниже");
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
            var input = "";

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите название аэропорта");
            airport.Name = Console.ReadLine();
            Console.WriteLine("Введите код аэропорта");
            input = Console.ReadLine();
            airport.Code = Int32.TryParse(input, out var _) ? Int32.Parse(input) : 0;
            Console.WriteLine("Введите количество полос аэропорта");
            input = Console.ReadLine();
            airport.Runways = Int32.TryParse(input, out var _) ? Int32.Parse(input) : 0;
            Console.WriteLine("Введите количество проданых билетов в аэропорте");
            input = Console.ReadLine();
            airport.SoldTickets = Int32.TryParse(input, out var _) ? Int32.Parse(input) : 0;
            Console.WriteLine("Введите средний турпоток аэропорта");
            input = Console.ReadLine();
            airport.AverageVisitors = Double.TryParse(input, out var _) ? Convert.ToDouble(input) : 0;
            Console.WriteLine("Введите среднемесячный доход аэропорта");
            input = Console.ReadLine();
            airport.MonthlyIncome = Double.TryParse(input, out var _) ? Convert.ToDouble(input) : 0;
            Console.WriteLine("Введите количество инцидентов в аэропорте");
            input = Console.ReadLine();
            airport.IncidentsCount = Int32.TryParse(input, out var _) ? Int32.Parse(input) : 0;

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
            var input = "";
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите название аэропорта");
            airport.Name = Console.ReadLine();
            Console.WriteLine("Введите код аэропорта");
            input = Console.ReadLine();
            airport.Code = Int32.TryParse(input, out var _) ? Int32.Parse(input) : 0;
            Console.WriteLine("Введите количество полос аэропорта");
            input = Console.ReadLine();
            airport.Runways = Int32.TryParse(input, out var _) ? Int32.Parse(input) : 0;
            Console.WriteLine("Введите количество проданых билетов в аэропорте");
            input = Console.ReadLine();
            airport.SoldTickets = Int32.TryParse(input, out var _) ? Int32.Parse(input) : 0;
            Console.WriteLine("Введите средний турпоток аэропорта");
            input = Console.ReadLine();
            airport.AverageVisitors = Double.TryParse(input, out var _) ? Convert.ToDouble(input) : 0;
            Console.WriteLine("Введите среднемесячный доход аэропорта");
            input = Console.ReadLine();
            airport.MonthlyIncome = Double.TryParse(input, out var _) ? Convert.ToDouble(input) : 0;
            Console.WriteLine("Введите количество инцидентов в аэропорте");
            input = Console.ReadLine();
            airport.IncidentsCount = Int32.TryParse(input, out var _) ? Int32.Parse(input) : 0;

            return airport;
        }
        set
        {
            Console.WriteLine(value);
            listenerEvent.Invoke();
        }
    }
}