using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW1
{
    internal class Airport
    {
        static public List<Airport> airports = new List<Airport>();
        static int selectedAirport = 0;
        string name;
        int code;
        int runwaysNum;
        int soldTickets;
        double averagePassenger;
        int monthlyIncome;
        int incidentCount;

        public Airport()
        {
            this.name = "AirportName";
            this.code = 0;
            this.runwaysNum = 0;
            this.soldTickets = 0;
            this.averagePassenger = 0;
            this.monthlyIncome = 0;
            this.incidentCount = 0;
        }

        public Airport(string nameValue, int codeValue)
        {
            this.name = nameValue;
            this.code = codeValue;
            this.runwaysNum = 0;
            this.soldTickets = 0;
            this.averagePassenger = 0;
            this.monthlyIncome = 0;
            this.incidentCount = 0;
        }

        public Airport(string nameValue, int codeValue, int runwaysValue, int ticketsValue, double passengersValue,
            int incomeValue, int incidentValue) 
        {
            this.name = nameValue;
            this.code = codeValue;
            this.runwaysNum = runwaysValue;
            this.soldTickets = ticketsValue;
            this.averagePassenger = passengersValue;
            this.monthlyIncome = incomeValue;
            this.incidentCount = incidentValue;
        }

        public override string ToString()
        {
            return this.name + " " + this.code.ToString() + "\nКоличество полос:" + this.runwaysNum.ToString() +
                "\nКоличество проданных билетов:" + this.soldTickets.ToString() + "\nСреднее количество пассажиров:"+
                this.averagePassenger.ToString() + "\nДоход за месяц:" + this.monthlyIncome.ToString() +
                "\nКоличество аварий:" + this.incidentCount.ToString();
        }

        public string getName() 
        {
            return this.name;
        }
    }
}
