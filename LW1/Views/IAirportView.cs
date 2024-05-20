using LW1.EventArgsModels;

namespace LW1.Views;

public interface IAirportView
{
    void AirportChange(object sender, AirportChangeEventArgs e);
}