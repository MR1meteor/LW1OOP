using LW1.EventArgsModels;
using LW1.Views;

namespace LW1.Controllers;

public class AirportController
{
    private static AirportController instance;

    public static AirportController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new AirportController();
            }

            return instance;
        }
    }

    public delegate void AirportChangeDelegate(object sender, AirportChangeEventArgs e);
    public event AirportChangeDelegate AirportChangeEvent;

    public void RegisterView(IAirportView view)
    {
        AirportChangeEvent += new AirportChangeDelegate(view.AirportChange);
    }

    public void UnregisterView(IAirportView view)
    {
        AirportChangeEvent -= new AirportChangeDelegate(view.AirportChange);
    }

    public void RaiseAirportChange(object sender, AirportChangeEventArgs e)
    {
        AirportChangeEvent(sender, e);
    }
}