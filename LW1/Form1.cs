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

    public void UpdateData()
    {
        var airports = airportService.GetAll().Result;
        /*
        Label newlbl = new Label();
        newlbl.Location = new Point(300, 300);
        newlbl.Text = "dadas";
        this.Controls.Add(newlbl);
        */
        if (airports.Count > 0)
        {
            button1.Location = new Point(500, 100);
            button1.Width = 100;
            button1.Height = 60;
            TextBox name = new TextBox();
            name.Text = airports[0].Name;
            this.Controls.Add(name);
            foreach (var airport in airports)
            {
                Label label = new Label
                {
                    Text = airport.Id.ToString()
                };
                MouseClick += ClickHandler;
                Console.WriteLine(airport.ToString());
                this.Controls.Add(label);
            }
        }
    }

    private void ClickHandler(object sender, EventArgs e)
    {
        Label item = sender as Label;
        var current_Airport = airportService.GetById(Int32.Parse(item.Name));
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        MessageBox.Show("22??3 ??????????? ???????? \n ?????????", "???????????? ?1");
        this.CenterToScreen();
        UpdateData();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2(this, airportService);
        this.Hide();
        form2.Show();
    }
}