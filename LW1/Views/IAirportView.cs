using LW1.EventArgsModels;
using LW1.Presenters;

namespace LW1.Views;

public interface IAirportView
{
    void SetPresenter(AirportPresenter airportPresenter);
    void ShowAirports(IEnumerable<Airport> airports);
    void Run();
    Airport AddingAirport { get; set; }
    Airport ChangingAirport { get; set; }
}