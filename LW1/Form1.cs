using LW1.Models.Service;
using LW1.Services.Interfaces;

namespace LW1;

public partial class Form1 : Form
{
    private ITransportService transportService;
    private List<Transport> transports = new();
    private int selectedTransport = 0;

    public Form1(ITransportService transportService)
    {
        InitializeComponent();
        this.transportService = transportService;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        MessageBox.Show("Курсовая работа Новосельцев А.А. 22ВП3", "Приветственное окно");
    }


    private void updateData()
    {


    }

    private void ItemSelected(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void ItemEdit(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void AddNewTransport_Click(object sender, EventArgs e)
    {

    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}