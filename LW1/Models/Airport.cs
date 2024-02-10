namespace LW1
{
    public class Airport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int Runways { get; set; }
        public int SoldTickets { get; set; }
        public double AveragePassengers { get; set; }
        public double MonthlyIncome { get; set; }
        public int IncidentsCount { get; set; }

        public Airport()
        {
            Name = string.Empty;
            Code = 0;
            Runways = 0;
            SoldTickets = 0;
            AveragePassengers = 0;
            MonthlyIncome = 0;
            IncidentsCount = 0;
        }

        public Airport(string name, int code)
        {
            Name = name;
            Code = code;
            Runways = 0;
            SoldTickets = 0;
            AveragePassengers = 0;
            MonthlyIncome = 0;
            IncidentsCount = 0;
        }

        public Airport(string name, int code, int runways, int tickets, double averagePassengers,
            int monthlyIncome, int incidentsCount) 
        {
            Name = name;
            Code = code;
            Runways = runways;
            SoldTickets = tickets;
            AveragePassengers = averagePassengers;
            MonthlyIncome = monthlyIncome;
            IncidentsCount = incidentsCount;
        }

        public override string ToString()
        {
            return $"Название: {Name}, количество полос: {Runways}, количество проданных билетов: {SoldTickets}, " +
                   $"среднее количество пассажиров: {AveragePassengers}, доход за месяц: {MonthlyIncome}, количество аварий: {IncidentsCount}";
        }
    }
}
