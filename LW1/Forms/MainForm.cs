using LW1.Models.Service;
using LW1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW1.Forms
{
    public partial class MainForm : Form
    {
        private readonly IAirportService airportService;
        private List<Airport> currentAirports;
        private int selectedId;

        public MainForm(IAirportService airportService)
        {
            InitializeComponent();
            this.airportService = airportService;
        }

        private void addBtnClick(object sender, EventArgs e)
        {
            airportsList.Enabled = false;
            saveBtn.Tag = "add";
            clearTextboxes();
            addBtn.Enabled = false;
            editModeBtn.Enabled = true;
            delBtn.Hide();
        }

        private void clearTextboxes()
        {
            nameTextbox.Text = "";
            codeTextbox.Text = "";
            runwaysTextbox.Text = "";
            touristsTextbox.Text = "";
            ticketsTextbox.Text = "";
            incomeTextbox.Text = "";
            incidentsTextbox.Text = "";
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveBtn.Tag.ToString() == "add") 
            {
                addAirport();
                airportsList.Enabled=true;
            }
            else if(saveBtn.Tag.ToString() == "save")
            {
                saveAirport();
            }
        }

        private async void addAirport()
        {
            Airport newAirport;
            if(nameTextbox.Text == "") 
            {
                nameTextbox.BackColor = Color.Coral;
                return;
            }
            else if (codeTextbox.Text == "")
            {
                newAirport = new(nameTextbox.Text);
            }
            else if(runwaysTextbox.Text == "" || touristsTextbox.Text == "" || ticketsTextbox.Text == ""||
                incomeTextbox.Text == "" || incidentsTextbox.Text == "")
            {
                newAirport = new(nameTextbox.Text, Int32.Parse(codeTextbox.Text));
            }
            else
            {

                newAirport = new(nameTextbox.Text, checkInt(codeTextbox), checkInt(runwaysTextbox),
                    checkInt(ticketsTextbox), checkDouble(touristsTextbox), checkDouble(incomeTextbox),
                    checkInt(incidentsTextbox));
            }
            await airportService.Add(newAirport);
            nameTextbox.BackColor = DefaultBackColor;
            await updateData();
        }

        private int checkInt(TextBox field)
        {
            return field.Text == "" ? default : Int32.Parse(field.Text);
        }

        private double checkDouble(TextBox field)
        {
            return field.Text == "" ? default : Double.Parse(field.Text);
        }

        private async void saveAirport() {
            Airport currentAirport = currentAirports[selectedId];
            if(nameTextbox.Text == "")
            {
                nameTextbox.BackColor = Color.Coral;
                return;
            }
            currentAirport.Name = nameTextbox.Text;
            currentAirport.Code = checkInt(codeTextbox);
            currentAirport.Runways = checkInt(runwaysTextbox);
            currentAirport.SoldTickets = checkInt(ticketsTextbox);
            currentAirport.AverageVisitors = checkDouble(touristsTextbox);
            currentAirport.MonthlyIncome = checkDouble(incomeTextbox);
            currentAirport.IncidentsCount = checkInt(incidentsTextbox);
            await airportService.Update(currentAirport);
            

        }
        private void editAirport(object sender, EventArgs e)
        {
            saveBtn.Text = "Сохранить";
            editModeBtn.Enabled = false;
            addBtn.Enabled = true;
        }

        private async void delBtn_Click(object sender, EventArgs e)
        {
            await airportService.Delete(currentAirports[selectedId].Id);
            clearTextboxes();
            await updateData();
        }

        private async Task updateData()
        {
            airportsList.Clear();
            currentAirports = await airportService.GetAll();
            foreach(Airport airport in currentAirports)
            {
                airportsList.Items.Add(airport.Name);
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await updateData();
        }

        private void SelectedItemChanged(object sender, EventArgs e)
        {
            selectedId = airportsList.Items.IndexOf(airportsList.FocusedItem);
            FillDataSingle(currentAirports[selectedId]);

        }

        private void FillDataSingle(Airport airport)
        {
            nameTextbox.Text = airport.Name;
            codeTextbox.Text = airport.Code.ToString();
            runwaysTextbox.Text = airport.Runways.ToString();
            ticketsTextbox.Text = airport.SoldTickets.ToString();
            touristsTextbox.Text = airport.AverageVisitors.ToString();
            incomeTextbox.Text = airport.MonthlyIncome.ToString();
            incomeTextbox.Text = airport.IncidentsCount.ToString();

        }
    }
}
