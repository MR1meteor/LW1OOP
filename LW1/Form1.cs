using LW1.Models.Service;
using LW1.Services.Interfaces;

namespace LW1;

public partial class Form1 : Form
{
    private IAirportService airportService;
    
    public Form1(IAirportService airportService)
    {
        InitializeComponent();
        this.airportService = airportService;
    }
    
    
}