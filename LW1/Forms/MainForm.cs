using System.Diagnostics;
using LW1.Event;
using LW1.EventArgsModels;
using LW1.Presenters;
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
        private AirportPresenter airportPresenter;

        public MainForm()
        {
            InitializeComponent();
            listener = new();
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

        private async Task returnToStartAsync()
        {
            delBtn.Show();
            airportsList.Items.Clear();
            airportsList.View = View.List;
            saveBtn.Tag = "save";
            saveBtn.Text = "Сохранить";
            airportPresenter.ShowAirports();
        }

        private async void addAirport()
        {
            Airport newAirport;
                if (string.IsNullOrEmpty(nameTextbox.Text))
                {
                    nameTextbox.BackColor = Color.Coral;
                    return;
                }
                else if (string.IsNullOrEmpty(codeTextbox.Text))
                {
                    codeTextbox.BackColor = Color.Coral;
                    return;
                }
                else if (string.IsNullOrEmpty(runwaysTextbox.Text) && string.IsNullOrEmpty(touristsTextbox.Text) && string.IsNullOrEmpty(ticketsTextbox.Text) &&
                    string.IsNullOrEmpty(incomeTextbox.Text) && string.IsNullOrEmpty(incidentsTextbox.Text))
                {

                    newAirport = new Airport(nameTextbox.Text, Int32.Parse(codeTextbox.Text));
                }
                else
                {

                    newAirport = new Airport(0, nameTextbox.Text, checkInt(codeTextbox), checkInt(runwaysTextbox),
                        checkInt(ticketsTextbox), checkDouble(touristsTextbox), checkDouble(incomeTextbox), checkInt(incidentsTextbox));
                }
            message.Message = "Объект добавлен";
            OnEvent?.Invoke(this, message);
            airportPresenter.SetAdding(newAirport);
            nameTextbox.BackColor = DefaultBackColor;
            codeTextbox.BackColor = DefaultBackColor;
            saveBtn.Tag = "save";
            airportPresenter.ShowAirports();
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

        private async void saveAirport()
        {
           var currentAirport = currentAirports[selectedId];
            if (nameTextbox.Text == "")
            {
                nameTextbox.BackColor = Color.Coral;
                return;
            }
            if(codeTextbox.Text == "")
            {
                codeTextbox.BackColor= Color.Coral;
                return;
            }
            currentAirport.Name = nameTextbox.Text;
            currentAirport.Code = checkInt(codeTextbox);
            currentAirport.Runways = checkInt(runwaysTextbox);
            currentAirport.SoldTickets = checkInt(ticketsTextbox);
            currentAirport.AverageVisitors = checkDouble(touristsTextbox);
            currentAirport.MonthlyIncome = checkDouble(incomeTextbox);
            currentAirport.IncidentsCount = checkInt(incidentsTextbox);
            airportPresenter.SetChanging(currentAirport);
            airportPresenter.ChangeAirport();
            nameTextbox.BackColor = DefaultBackColor;
            codeTextbox.BackColor = DefaultBackColor;
            editModeBtn.Enabled = true;
            message.Message = "Объект сохранён";
            OnEvent?.Invoke(this, message);
            airportPresenter.ShowAirports();
        }
        private void editAirport(object sender, EventArgs e)
        {
            saveBtn.Text = "Сохранить";
            editModeBtn.Enabled = false;
            addBtn.Enabled = true;
        }

        private async void delBtn_Click(object sender, EventArgs e)
        {
            airportPresenter.RemoveAirport(currentAirports[selectedId].Id);
            clearTextboxes();
            airportPresenter.ShowAirports();
            message.Message = "Объект удалён";
            OnEvent?.Invoke(this, message);
        }

        private async Task updateData()
        {
            airportsList.Clear();
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

        private async void MainForm_Load(object sender, EventArgs e)
        {
            airportPresenter.ShowAirports();
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

        public void SetPresenter(AirportPresenter airportPresenter)
        {
            this.airportPresenter = airportPresenter;
        }
         public void Run()
         {
            Application.Run(this);
         }
         
         
        /*

        ИСПОЛЬЗУЙ ФУНКЦИИ ИЗ airportPresenter (новое поле у тебя в форме) ДЛЯ РАБОТЫ С ОБЪЕКТАМИ
        Нужно для синхры консоли и формы (возможно)
        Т.е. все добавления / изменения / удаления объектов через методы в airportPresenter делаешь
        Перед добавлением можешь присваивать значение через airportPresenter.SetAdding, также с изменением
        Но если реализуешь методы ниже это вроде бы не понадобится
        (Сам хз как эта хуйня должна работать, параша еще та)
        Всю лишнюю хуйню под снос чтобы не мешала

        */
         
        public void ShowAirports(IEnumerable<Airport> airports)
        {
            IEnumerator<Airport> airportsEnumenator = airports.GetEnumerator();
            while (airportsEnumenator.MoveNext()) { 
                currentAirports.Add(airportsEnumenator.Current);
            }
            updateData();
            // Здесь заюзай функцию, которая у тебя аэропорты показывает
            // Можешь своему списку присвоить список который пришел и потом свою функцию вызвать
            // Не смотрел как у тебя там работает
        }
        
        public Airport AddingAirport
        {
            get
            {
                return new Airport
                {
                    Id = 0,
                    Name = nameTextbox.Text, // Поле где лежит Name при добавлении т.е. label.text или чё там
                    Code = checkInt(codeTextbox), // Поле где лежит Code при добавлении
                    Runways = checkInt(runwaysTextbox), // И т.д.
                    SoldTickets = checkInt(ticketsTextbox),
                    AverageVisitors = checkDouble(touristsTextbox),
                    MonthlyIncome = checkDouble(incomeTextbox),
                    IncidentsCount = checkInt(incidentsTextbox),
                };
            }
            set
            {
                // Тут делаешь наоборот, т.е. присваиваешь этим UI полям как раз имеющиеся значения
                nameTextbox.Text = value.Name;
                codeTextbox.Text = value.Code.ToString();
                runwaysTextbox.Text = value.Runways.ToString();
                ticketsTextbox.Text = value.SoldTickets.ToString();
                touristsTextbox.Text = value.AverageVisitors.ToString();
                incomeTextbox.Text = value.MonthlyIncome.ToString();
                incidentsTextbox.Text = value.IncidentsCount.ToString();
                // Что из этого нахуй не нужно - убирай, твоя задача - подставить UI поля до '='
            }
        }

        public Airport ChangingAirport
        {
            // По аналогии с верхом делай
            get
            {
                return new Airport
                {
                    Id = selectedId, // Тут Id тоже присвой из своего списка или где там
                    Name = nameTextbox.Text,
                    Code = checkInt(codeTextbox),
                    Runways = checkInt(runwaysTextbox),
                    SoldTickets = checkInt(ticketsTextbox),
                    AverageVisitors = checkDouble(touristsTextbox),
                    MonthlyIncome = checkDouble(incomeTextbox),
                    IncidentsCount = checkInt(incidentsTextbox),
                };
            }
            set
            {
                nameTextbox.Text = value.Name;
                codeTextbox.Text = value.Code.ToString();
                runwaysTextbox.Text = value.Runways.ToString();
                ticketsTextbox.Text = value.SoldTickets.ToString();
                touristsTextbox.Text = value.AverageVisitors.ToString();
                incomeTextbox.Text = value.MonthlyIncome.ToString();
                incidentsTextbox.Text = value.IncidentsCount.ToString();
            }
        }
    }
}
