namespace LW1.EventArgsModels;

public class AirportChangeEventArgs
{
    public int AirportId;

    public AirportChangeEventArgs(int airportId)
    {
        AirportId = airportId;
    }
}