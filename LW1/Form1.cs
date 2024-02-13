using LW1.Models.Service;
using LW1.Services.Interfaces;

namespace LW1;

public partial class Form1 : Form
{
    private IAirportService airportService;
    private Airport selectedAirport;
    private List<Label> addedAirports = new List<Label>();


    public Form1(IAirportService airportService)
    {
        InitializeComponent();
        this.airportService = airportService;
    }

    public async void UpdateData()
    {
        var airports = airportService.GetAll().Result;
        hideLabels();
        if (airports.Count > 0)
        {
            selectedAirport = airports[0];
            button2.Enabled = true;
            button3.Enabled = true;
            showLabels();
            for (int i = 0; i < airports.Count; i++)
            {
                Label label = new()
                {
                    Text = airports[i].Id.ToString()
                };
                label.MouseClick += ClickHandler;
                label.Tag = "removable";
                label.TextAlign = ContentAlignment.TopCenter;
                label.MouseEnter += EnterHandler;
                label.MouseLeave += LeaveHandler;
                label.Location = new Point(690, 100 + (i + 1) * 30);
                addedAirports.Add(label);
                this.Controls.Add(label);
            }
        }
        else
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }

    private void EnterHandler(object sender, EventArgs e)
    {
        var item = sender as Label;
        item.BackColor = Color.FromArgb(30, Color.Black);
        this.Cursor = Cursors.Hand;
    }

    private void LeaveHandler(object sender, EventArgs e)
    {
        var item = sender as Label;
        item.BackColor = Color.Transparent;
        this.Cursor = Cursors.Default;
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
                }
            }
            label1.Text = selectedAirport.Name;
                    label2.Text = selectedAirport.Code.ToString();
                    label3.Text = selectedAirport.Runways.ToString();
                    label4.Text = selectedAirport.SoldTickets.ToString();
                    label5.Text = selectedAirport.AverageVisitors.ToString();
                    label6.Text = selectedAirport.MonthlyIncome.ToString();
                    label7.Text = Convert.ToString(selectedAirport.IncidentsCount, 16);
        }
    }
    private void hideLabels()
    {
        while (addedAirports.Count > 0)
        {
            Label item = addedAirports.Last();
            this.Controls.Remove(item);
            addedAirports.Remove(item);
        }
        foreach (var element in this.Controls)
        {
            if (element is Label)
            {
                Label item = element as Label;
                if (item.Tag.ToString() == "based")
                {
                    item.Hide();
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
        hideLabels();
        //foreach (var element in this.Controls)
        //{
        //    if (element is Label)
        //    {
        //        Label item = element as Label;
        //        if (item.Text == selectedAirport.Id.ToString())
        //        {
        //            this.Controls.Remove(item);
        //        }
        //    }
        //}
        airportService.Delete(selectedAirport.Id);
        UpdateData();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Form2 form2 = new(this, airportService, selectedAirport);
        hideLabels();
        this.Hide();
        form2.Show();
    }
}