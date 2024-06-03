using LW1.Repositories.Interfaces;
using LW1.Views;

namespace LW1.Presenters;

public class AirportPresenter
{
    private IAirportRepository airportRepository;
    private IAirportView airportView;

    public AirportPresenter(IAirportRepository airportRepository, IAirportView airportView)
    {
        this.airportRepository = airportRepository;
        this.airportView = airportView;

        airportView.SetPresenter(this);
    }

    public void RunView()
    {
        airportView.Run();
    }

    public void SetAdding(Airport airport)
    {
        airportView.AddingAirport = airport;
    }

    public void ClearAdding()
    {
        airportView.AddingAirport = new Airport();
    }
    
    public void SetChanging(Airport airport)
    {
        airportView.ChangingAirport = airport;
    }

    public void ClearChanging()
    {
        airportView.ChangingAirport = new Airport();
    }
    
    public void AddAirport()
    {
        var adding = airportView.AddingAirport;
        airportRepository.Add(adding);
        ShowAirports();
    }

    public void ChangeAirport()
    {
        var changing = airportView.ChangingAirport;
        airportRepository.Edit(changing);
        ShowAirports();
    }

    public void RemoveAirport()
    {
        var removing = airportView.ChangingAirport;
        airportRepository.Delete(removing.Id);
        ShowAirports();
        airportView.ChangingAirport = new Airport();
    }

    public void RemoveAirport(int id)
    {
        airportRepository.Delete(id);
        ShowAirports();
        airportView.ChangingAirport = new Airport();
    }
    
    public void ShowAirports()
    {
        var airports = airportRepository.GetAll();
        airportView.ShowAirports(airports);
    }
}