using LW1.Controllers;
using LW1.EventArgsModels;
using LW1.Models.Service;
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
    private List<AirportsStorage> storage;

    public CustomConsole()
    {
        AirportController.Instance.RegisterView(this);
        Console.WriteLine("Start listening airports changes");
    }
    
    public void AirportChange(object sender, AirportChangeEventArgs e)
    {
        var changedAirport = AirportsStorage.Instance.Airports.FirstOrDefault(airport => airport.Id == e.AirportId);

        if (changedAirport == null)
        {
            return;
        }
        
        Console.WriteLine($"Airport {changedAirport.Name} was changed");
        Console.WriteLine($"New values: {changedAirport}");
    }
}