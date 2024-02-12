using LW1.Models.Service;
using LW1.Services.Interfaces;

namespace LW1;

public partial class Form1 : Form
{
    private IAirportService airportService;
    private Airport selectedAirport;

    public Form1(IAirportService airportService)
    {
        InitializeComponent();
        this.airportService = airportService;
    }

    public async void UpdateData()
    {
        var airportsCount = await airportService.GetCount();
        Airport.ObjectsCounter = airportsCount;
        var airports = airportService.GetAll().Result;
        
        if (airports.Count > 0)
        {
            selectedAirport = airports[0];
            showLabels();
            button1.Location = new Point(690, 13);
            button1.Width = 100;
            button1.Height = 60;
            for (int i = 0; i < airports.Count; i++)
            {
                Label label = new Label
                {
                    Text = airports[i].Id.ToString()
                };
                label.MouseClick += ClickHandler;
                label.Tag = "removable";
                label.Location = new Point(690, 100 + (i + 1) * 30);
                this.Controls.Add(label);
            }
        }
        else
        {
            button1.Location = new Point(302, 209);
            button1.Width = 202;
            button1.Height = 29;
            hideLabels();
        }
    }

    private void showLabels()
    {
        foreach (var element in this.Controls)
        {
            if (element is Label)
            {
                Label item = element as Label;
                if (item.Tag == "based")
                {
                    item.Show();
                    label1.Text = selectedAirport.Name;
                    label2.Text = selectedAirport.Code.ToString();
                    label3.Text = selectedAirport.Runways.ToString();
                    label4.Text = selectedAirport.SoldTickets.ToString();
                    label5.Text = selectedAirport.AverageVisitors.ToString();
                    label6.Text = selectedAirport.MonthlyIncome.ToString();
                    label7.Text = selectedAirport.IncidentsCount.ToString();
                }
            }
            else if (element is Button)
            {
                Button item = element as Button;
                if (item.Tag is not null)
                {
                    if (item.Tag.ToString() == "based")
                    {
                        item.Show();
                    }
                }
            }
        }
    }
    private void hideLabels()
    {
        foreach (var element in this.Controls)
        {
            if (element is Label)
            {
                Label item = element as Label;
                if (item.Tag.ToString() == "removable")
                {
                    this.Controls.Remove(item);
                }
                else if (item.Tag.ToString() == "based")
                {
                    item.Hide();
                }
            }
            else if (element is Button)
            {
                Button item = element as Button;
                if (item.Tag is not null)
                {
                    if (item.Tag.ToString() == "based")
                    {
                        item.Hide();
                    }
                }
            }
        }
    }

    private void ClickHandler(object sender, EventArgs e)
    {
        Label item = sender as Label;
        if (item != null)
        {
            selectedAirport = airportService.GetById(Int32.Parse(item.Text)).Result;
            showLabels();
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        MessageBox.Show("22ВП3 Новосельцев Сафронов \n Аэропорты", "Лабораторная работа №1");
        this.CenterToScreen();
        UpdateData();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form2 form2 = new(this, airportService);
        hideLabels();
        this.Hide();
        form2.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        foreach (var element in this.Controls)
        {
            if (element is Label)
            {
                Label item = element as Label;
                if (item.Text == selectedAirport.Id.ToString())
                {
                    this.Controls.Remove(item);
                }
            }
        }
        airportService.Delete(selectedAirport.Id);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Form2 form2 = new(this, airportService, selectedAirport);
        hideLabels();
        this.Hide();
        form2.Show();
    }
}