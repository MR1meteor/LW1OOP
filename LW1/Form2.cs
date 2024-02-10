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
        private Form initilazer;
        public Form2()
        {
            InitializeComponent();
        }

        public void LaunchWindow(Form window) {
            initilazer = window;
            Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            initilazer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Airport newAirport;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                newAirport = new Airport();
            }
            else if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||
                textBox6.Text == "" || textBox7.Text == "") 
            {
                newAirport = new Airport(textBox1.Text, Int32.Parse(textBox2.Text));
            }
            else
            {
                newAirport = new Airport(textBox1.Text, Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text),
                    Int32.Parse(textBox4.Text), Double.Parse(textBox5.Text), Int32.Parse(textBox6.Text),
                    Int32.Parse(textBox7.Text));
            }
            
            Airport.airports.Add(newAirport);
            Hide();
            initilazer.Show();
        }
    }
}
