using System.Diagnostics;
using LW1.Event;
using LW1.EventArgsModels;
using LW1.Factories;
using LW1.Models.Db;
using LW1.Models.Service;
using LW1.Services.Interfaces;

namespace LW1.Forms
{
    public partial class MainForm : Form
    {
        public delegate void EventHandle(object? sender, EventArgsModel message);
        public static event EventHandle OnEvent;
        private readonly IAirportService airportService;
        private CivilAirportFactory civilAirpors = new();
        private MilitaryAirportFactory militaryAirpors = new();
        private List<Airport> currentAirports;
        private Airport[] airportArray = new Airport[100000];
        private int selectedId;
        private EventArgsModel message = new("");
        private readonly EventListener listener;

        public MainForm(IAirportService airportService)
        {
            InitializeComponent();
            this.airportService = airportService;
            listener = new();
        }

        private void addBtnClick(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
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
            AACheckbox.Checked = false;
            ticketsTextbox.Text = "";
            incomeTextbox.Text = "";
            incidentsTextbox.Text = "";

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveBtn.Tag.ToString() == "add")
            {
                addAirport();
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
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

        private async Task returnToStartAsync()
        {
            delBtn.Show();
            airportsList.Items.Clear();
            airportsList.View = View.List;
            saveBtn.Tag = "save";
            saveBtn.Text = "Сохранить";
            await updateData();
        }

        private async void addAirport()
        {
            Airport newAirport;
            if (radioButton1.Checked)
            {
                
                if (nameTextbox.Text == "")
                {
                    nameTextbox.BackColor = Color.Coral;
                    return;
                }
                else if (codeTextbox.Text == "")
                {
                    codeTextbox.BackColor = Color.Coral;
                    return;
                }
                else if (runwaysTextbox.Text == "" || touristsTextbox.Text == "" || ticketsTextbox.Text == "" ||
                    incomeTextbox.Text == "" || incidentsTextbox.Text == "")
                {

                    newAirport = civilAirpors.CreateAirport(nameTextbox.Text, Int32.Parse(codeTextbox.Text));
                }
                else
                {

                    newAirport = (CivilAirport)civilAirpors.CreateAirport(nameTextbox.Text, checkInt(codeTextbox), checkInt(runwaysTextbox),
                        checkInt(incidentsTextbox), checkInt(ticketsTextbox), checkDouble(touristsTextbox), checkDouble(incomeTextbox));
                }
            }
            else
            {
                if (nameTextbox.Text == "")
                {
                    nameTextbox.BackColor = Color.Coral;
                    return;
                }
                else if (codeTextbox.Text == "")
                {
                    codeTextbox.BackColor = Color.Coral;
                    return;
                }
                else if (runwaysTextbox.Text == "" || touristsTextbox.Text == "" || ticketsTextbox.Text == "" ||
                    incomeTextbox.Text == "" || incidentsTextbox.Text == "")
                {

                    newAirport = (MilitaryAirport)militaryAirpors.CreateAirport(nameTextbox.Text, Int32.Parse(codeTextbox.Text));
                }
                else
                {

                    newAirport = (MilitaryAirport)militaryAirpors.CreateAirport(nameTextbox.Text, checkInt(codeTextbox), checkInt(runwaysTextbox),
                        checkInt(incidentsTextbox), ticketsTextbox.Text, AACheckbox.Checked, checkInt(incomeTextbox));
                }
            }
            message.Message = "Объект добавлен";
            OnEvent?.Invoke(this, message);
            await airportService.Add(newAirport);
            nameTextbox.BackColor = DefaultBackColor;
            codeTextbox.BackColor = DefaultBackColor;
            saveBtn.Tag = "save";
            await updateData();
            airportsList.Enabled = true;
            addBtn.Enabled = true;
            delBtn.Show();
        }

        private int checkInt(TextBox field)
        {
            return field.Text == "" ? default : Int32.Parse(field.Text);
        }

        private double checkDouble(TextBox field)
        {
            return field.Text == "" ? default : Double.Parse(field.Text);
        }

        private async void saveAirport()
        {
           /* Airport currentAirport = currentAirports[selectedId];
            if (nameTextbox.Text == "")
            {
                nameTextbox.BackColor = Color.Coral;
                return;
            }
            else if (codeTextbox.Text == "")
            {
                codeTextbox.BackColor = Color.Coral;
                return;
            }
            if (currentAirport.GetType() == typeof(CivilAirport))
            {
                currentAirport.Name = nameTextbox.Text;
                currentAirport.Code = checkInt(codeTextbox);
                currentAirport.Runways = checkInt(runwaysTextbox);
                currentAirport.SoldTickets = checkInt(ticketsTextbox);
                currentAirport.AverageVisitors = checkDouble(touristsTextbox);
                currentAirport.MonthlyIncome = checkDouble(incomeTextbox);
                currentAirport.IncidentsCount = checkInt(incidentsTextbox);
            }
            editModeBtn.Enabled = true;
            message.Message = "Объект сохранён";
            OnEvent?.Invoke(this, message);
            await airportService.Update(currentAirport);
            await updateData();*/
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
            message.Message = "Объект удалён";
            OnEvent?.Invoke(this, message);
        }

        private async Task updateData()
        {
            airportsList.Clear();
            currentAirports = await airportService.GetAll();
            foreach (Airport airport in currentAirports)
            {
                airportsList.Items.Add(airport.Name);
            }
            selectedId = currentAirports.Count - 1;
            FillDataSingle(currentAirports[selectedId]);
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
            if (airport.GetType() == typeof(CivilAirport))
            {
                civilMode();
                CivilAirport currentAirport = (CivilAirport)airport;
                ticketsTextbox.Text = currentAirport.SoldTickets.ToString();
                touristsTextbox.Text = currentAirport.AverageVisitors.ToString();
                incomeTextbox.Text = currentAirport.MonthlyIncome.ToString();
            }
            else
            {
                millitaryMode();
                MilitaryAirport currentAirport = (MilitaryAirport)airport;
                ticketsTextbox.Text = currentAirport.MilitaryDistrict.ToString();
                AACheckbox.Checked = currentAirport.HasAirDefence;
                incomeTextbox.Text = currentAirport.AircraftNumber.ToString();
            }
            incomeTextbox.Text = airport.IncidentsCount.ToString();

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
                AirportFactory factory = new MilitaryAirportFactory();
                var item = factory.CreateAirport();
                ///
                airportArray[i] = item;
                currentAirports.Add(item);
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            millitaryMode();
        }



        private void millitaryMode()
        {
            ticketsLabel.Text = "Военный округ";
            touristsLabel.Text = "Наличие ПВО";
            incomeLabel.Text = "Количество самолётов";
            AACheckbox.Show();
            touristsTextbox.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            civilMode();
        }

        private void civilMode()
        {
            ticketsLabel.Text = "Продано билетов";
            touristsLabel.Text = "Средний турпоток";
            incomeLabel.Text = "Доход за месяц";
            touristsTextbox.Show();
            AACheckbox.Hide();
        }
    }
}
