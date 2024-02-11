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

namespace LW1
{
    public partial class Form2 : Form
    {
        private Form1 sender;
        private IAirportService airportService;
        public Form2(Form1 sender, IAirportService airportService)
        {
            InitializeComponent();
            this.sender = sender;
            this.airportService = airportService;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Нажатие на кнопку "Готово"
        private void button1_Click(object sender, EventArgs e)
        {
            Airport newAirport;
            if (textBox1.Text == "")
            {
                newAirport = new Airport();
            }
            else if (textBox4.Text == "")
            {
                newAirport = new Airport(textBox1.Text);
            }
            else if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0 || numericUpDown3.Value == 0 ||
                textBox2.Text == "" || textBox3.Text == "")
            {
                newAirport = new Airport(textBox1.Text, Int32.Parse(textBox4.Text));
            }
            else
            {
                newAirport = new Airport(textBox1.Text,
                    Int32.Parse(textBox4.Text),
                    Convert.ToInt32(Math.Round(numericUpDown1.Value, 0)),
                    Convert.ToInt32(Math.Round(numericUpDown2.Value, 0)),
                    Double.Parse(textBox2.Text),
                    Double.Parse(textBox3.Text),
                    Convert.ToInt32(Math.Round(numericUpDown3.Value, 0)));
            }
            airportService.Add(newAirport);
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
