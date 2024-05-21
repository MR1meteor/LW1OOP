using System.Diagnostics;
using LW1.Controllers;
using LW1.Event;
using LW1.EventArgsModels;
using LW1.Models.Service;
using LW1.Views;

namespace LW1.Forms
{
    public partial class MainForm : Form, IAirportView
    {
        public delegate void EventHandle(object? sender, EventArgsModel message);
        public static event EventHandle OnEvent;
        private List<Airport> currentAirports;
        private Airport[] airportArray = new Airport[100000];
        private int selectedId;
        private EventArgsModel message = new("");
        private readonly EventListener listener;

        public MainForm()
        {
            InitializeComponent();
            listener = new();
            AirportController.Instance.RegisterView(this);
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
            }
            else if (saveBtn.Tag.ToString() == "save")
            {
                saveAirport();
            }
            else if (saveBtn.Tag.ToString() == "back")
            {
                returnToStartAsync();
            }
        }

        private void returnToStartAsync()
        {
            delBtn.Show();
            airportsList.Items.Clear();
            airportsList.View = View.List;
            saveBtn.Tag = "save";
            saveBtn.Text = "Сохранить";
            updateData();
        }

        private void addAirport()
        {
            AirportsStorage.Instance.AddAirport(nameTextbox.Text, checkInt(codeTextbox), checkInt(runwaysTextbox),
            checkInt(ticketsTextbox), checkDouble(touristsTextbox), checkDouble(incomeTextbox), checkInt(incidentsTextbox));
            message.Message = "Объект добавлен";
            OnEvent?.Invoke(this, message);
            nameTextbox.BackColor = DefaultBackColor;
            codeTextbox.BackColor = DefaultBackColor;
            saveBtn.Tag = "save";
            updateData();
            airportsList.Enabled = true;
            addBtn.Enabled = true;
            delBtn.Show();
        }

        private int checkInt(TextBox field)
        {
            return string.IsNullOrEmpty(field.Text) ? default : Int32.Parse(field.Text);
        }

        private double checkDouble(TextBox field)
        {
            return string.IsNullOrEmpty(field.Text) ? default : Double.Parse(field.Text);
        }

        private void saveAirport()
        {
           var currentAirport = currentAirports[selectedId];
            if (nameTextbox.Text == "")
            {
                nameTextbox.BackColor = Color.Coral;
                return;
            }
            /* Мой вариант как тебе передавать, если заинтересует - подгони под это
             * AirportsStorage.Instance.UpdateAirport(currentAirport, nameTextbox.Text, checkInt(codeTextbox), checkInt(runwaysTextbox),
            checkInt(ticketsTextbox), checkDouble(touristsTextbox), checkDouble(incomeTextbox), checkInt(incidentsTextbox));
             */
            currentAirport.Name = nameTextbox.Text;
            currentAirport.Code = checkInt(codeTextbox);
            currentAirport.AverageVisitors = checkDouble(touristsTextbox);
            currentAirport.SoldTickets = checkInt(ticketsTextbox);
            currentAirport.Runways = checkInt(runwaysTextbox);
            currentAirport.IncidentsCount = checkInt(incidentsTextbox);
            currentAirport.MonthlyIncome = checkDouble(incomeTextbox);
            AirportsStorage.Instance.UpdateAirport(currentAirport);
            editModeBtn.Enabled = true;
            message.Message = "Объект сохранён";
            OnEvent?.Invoke(this, message);
            updateData();
        }
        private void editAirport(object sender, EventArgs e)
        {
            saveBtn.Text = "Сохранить";
            editModeBtn.Enabled = false;
            addBtn.Enabled = true;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            // await airportService.Delete(currentAirports[selectedId].Id);
            AirportsStorage.Instance.RemoveAirport(currentAirports[selectedId].Id);
            clearTextboxes();
            updateData();
            message.Message = "Объект удалён";
            OnEvent?.Invoke(this, message);
        }

        private void updateData()
        {
            airportsList.Clear();
            currentAirports = AirportsStorage.Instance.airports;
            foreach (var airport in currentAirports)
            {
                airportsList.Items.Add(airport.Name);
            }
            selectedId = currentAirports.Count - 1;
            if (selectedId > 0)
            {
                FillDataSingle(currentAirports[selectedId]);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateData();
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
            
            incidentsTextbox.Text = airport.IncidentsCount.ToString();

        }
        private void CompareArList_Click(object sender, EventArgs e)
        {
            saveBtn.Tag = "back";
            delBtn.Hide();
            saveBtn.Text = "Назад";
            airportsList.Items.Clear();
            airportsList.View = View.Details;
            airportsList.Columns.Add("Контейнер", 100, HorizontalAlignment.Center);
            airportsList.Columns.Add("Тип выборки", 170, HorizontalAlignment.Center);
            airportsList.Columns.Add("Время", 100, HorizontalAlignment.Center);
            currentAirports.Clear();
            Array.Clear(airportArray);
            for (int i = 0; i < 100000; i++)
            {
                // Ну хуй знает, ебись сам, вот пример создания
                // AirportFactory factory = new MilitaryAirportFactory();
                // var item = factory.CreateAirport();
                ///
                // airportArray[i] = item;
                // currentAirports.Add(item);
            }

            var sw = new Stopwatch();
            sw.Start();
            IterateCollection(airportArray);
            sw.Stop();
            showResult("Array", "Последовательно", sw.Elapsed.TotalMilliseconds);

            sw.Restart();
            IterateCollection(currentAirports);
            sw.Stop();
            showResult("List", "Последовательно", sw.Elapsed.TotalMilliseconds);

            sw.Restart();
            IterateCollectionRandom(airportArray);
            sw.Stop();
            showResult("Array", "Рандомно", sw.Elapsed.TotalMilliseconds);

            sw.Restart();
            IterateCollectionRandom(currentAirports);
            sw.Stop();
            showResult("List", "Рандомно", sw.Elapsed.TotalMilliseconds);
        }

        private void IterateCollection(IEnumerable<Airport> collection)
        {
            Airport current;

            foreach (var item in collection)
            {
                current = item;
            }
        }

        private void IterateCollectionRandom(IEnumerable<Airport> collection)
        {
            Airport current;
            var random = new Random();

            for (int i = 0; i < collection.Count(); i++)
            {
                current = collection.ElementAt(random.Next(0, collection.Count()));
            }
        }

        //Функция для отображения результата замера
        private void showResult(string container, string type, double time)
        {
            string[] item = { container, type, time.ToString() };
            var listViewItem = new ListViewItem(item);
            airportsList.Items.Add(listViewItem);
        }

        public void AirportChange(object sender, AirportChangeEventArgs e)
        {
            // Тут апдейтить список (наверное..)
        }
    }
}
