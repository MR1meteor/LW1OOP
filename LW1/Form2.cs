using LW1.Exceptions;
using LW1.External;
using LW1.Models.Service;
using LW1.Services.Interfaces;

namespace LW1
{
    public partial class Form2 : Form
    {
        private Form1 sender;
        private IAirportService airportService;
        private Airport selectedAirport;
        private bool isUpdate;
        public Form2(Form1 sender, IAirportService airportService)
        {
            InitializeComponent();
            this.sender = sender;
            this.airportService = airportService;
            isUpdate = false;
        }

        public Form2(Form1 sender, IAirportService airportService, Airport airport)
        {
            InitializeComponent();
            this.sender = sender;
            this.airportService = airportService;
            selectedAirport = airport;
            textBox1.Text = airport.Name;
            textBox4.Text = airport.Code.ToString();
            numericUpDown1.Value = airport.Runways;
            numericUpDown2.Value = airport.SoldTickets;
            textBox2.Text = airport.AverageVisitors.ToString();
            textBox3.Text = airport.MonthlyIncome.ToString();
            numericUpDown3.Value = airport.IncidentsCount;
            isUpdate = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Нажатие на кнопку "Готово"
        private async void button1_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                Airport newAirport;
                if (textBox1.Text == "")
                {
                    try
                    {
                        newAirport = new Airport();
                    }
                    catch (FormatException)
                    {
                        throw new CustomInvalidCastException("Invalid cast when create Airport obj (Add)");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else if (textBox4.Text == "")
                {
                    try
                    {
                        newAirport = new Airport(textBox1.Text);
                    }
                    catch (FormatException)
                    {
                        throw new CustomInvalidCastException("Invalid cast when create Airport obj (Add)");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    
                }
                else if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0 || numericUpDown3.Value == 0 ||
                    textBox2.Text == "" || textBox3.Text == "")
                {
                    try
                    {
                        newAirport = new Airport(textBox1.Text, Int32.Parse(textBox4.Text));
                    }
                    catch (FormatException)
                    {
                        throw new CustomInvalidCastException("Invalid cast when create Airport obj (Add)");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    try
                    {
                        newAirport = new Airport(textBox1.Text,
                            Int32.Parse(textBox4.Text),
                            Convert.ToInt32(Math.Round(numericUpDown1.Value, 0)),
                            Convert.ToInt32(Math.Round(numericUpDown2.Value, 0)),
                            Double.Parse(textBox2.Text),
                            Double.Parse(textBox3.Text),
                            Convert.ToInt32(Math.Round(numericUpDown3.Value, 0)));
                    }
                    catch (FormatException)
                    {
                        throw new CustomInvalidCastException("Invalid cast when create Airport obj (Add)");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                
                await airportService.Add(newAirport);
            }
            else
            {
                try
                {
                    selectedAirport.Name = textBox1.Text;
                    selectedAirport.Code = Int32.Parse(textBox4.Text);
                    selectedAirport.Runways = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                    selectedAirport.SoldTickets = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
                    selectedAirport.AverageVisitors = Double.Parse(textBox2.Text);
                    selectedAirport.MonthlyIncome = Convert.ToInt32(textBox3.Text);
                    selectedAirport.IncidentsCount = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));

                    await airportService.Update(selectedAirport);
                }
                catch (FormatException)
                {
                    throw new CustomInvalidCastException("Invalid cast when create Airport obj (Update)");
                }
                catch (Exception)
                {
                    throw;
                }
            }
            button2_Click(sender, e);
        }

        //Нажатие на кнопку "Отмена"
        private void button2_Click(object sender, EventArgs e)
        {
            this.sender.UpdateData();
            this.sender.Show();
            this.Close();
        }
    }
}
