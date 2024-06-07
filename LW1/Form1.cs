using Random = System.Random;
using Timer = System.Threading.Timer;

namespace LW1;

public partial class OPP_LB6 : Form
{

    // Делаешь форму: 3 поля для вывода, 3 кнопки "Выполнить" под полями
    // Можешь вместо "Выполнить" другой текст запихать
    // Поля для вывода сделай многострочными

    // 1 кнопка - CalculateSum - вычисление суммы на векторе
    // Можешь рандомный массив сгенерить, функцию по генерации я тебе дал
    // Возвращает сумму в long, просто вывести

    // 2 кнопка - GetCurrentTime - получает текущее время
    // Возвращает время в DateTime, переведи в строку и выведи

    // 3 кнопка - CountToThree - через отложенные таски считает до 3 посекундно
    // Возвращает массив с посекундным временем, переведи в строку и выведи

    // Для каждого поля для вывода формат примерно такой
    // [12:20:04] Начало выполнения метода
    // [time] Конец выполнения метода
    // [time] Результат метода

    // В чём прикол - вывод о результате добавить нужно в сами функции (пометил)
    // Строки "Начало выполнения" и "Конец выполнения" выводятся в самих функциях обработки нажатия кнопки
    // Они будут раньше (скорее всего) т.к. выполнятся быстрее, а у нас асинхронка, которую мы ждать не будем
    // Все функции вызывай через Task.Run(() => Method());
    // Можно перед Task.Run() сделать await, тогда выполнение будет ожидаться (хз как нужно)

    // P.S. Формат строки делать через $"{variable}SomeText{method()}"
    // P.P.S. Получать время для [time] через DateTime.Now (статическое поле)

    public OPP_LB6()
    {
        InitializeComponent();
    }

    private List<int> GenerateRandomEnumerable(int size)
    {
        var random = new Random();
        var enumerable = new List<int>();

        for (int i = 0; i < size; i++)
        {
            enumerable.Add(random.Next());
        }

        return enumerable;
    }

    private void CalculateSum()
    {
        IEnumerable<int> vector = GenerateRandomEnumerable(10);
        long sum = 0;
        ListViewItem startText = new();
        SumCalcLogs.Items.Clear();
        SumCalcLogs.Items.Add(new ListViewItem($"[{DateTime.Now.ToString()}]1: Запуск функции суммирования элементов вектора"));
        foreach (var value in vector)
        {
            sum += value;
        }
        SumCalcLogs.Items.Add(new ListViewItem($"[{DateTime.Now.ToString()}]1: Завершение функции суммирования элементов вектора"));
        SumCalcLogs.Items.Add(new ListViewItem($"[{DateTime.Now.ToString()}]1: {sum}"));

        // Здесь форматированны вывод результата sum
    }

    private void GetCurrentTime()
    {
        SysTimeLogs.Items.Clear();
        SysTimeLogs.Items.Add($"[{DateTime.Now.ToString()}]2: Запуск функции отображения времени");
        var time = DateTime.Now;
        SysTimeLogs.Items.Add(new ListViewItem($"[{DateTime.Now.ToString()}]2: Завершение функции отображения времени"));
        SysTimeLogs.Items.Add(new ListViewItem($"[{DateTime.Now.ToString()}]2: {time}"));
        
        // Здесь форматированный вывод результата time
    }

    private void CountToThree()
    {
        CountToThreeLogs.Items.Clear();
        CountToThreeLogs.Items.Add(new ListViewItem($"[{DateTime.Now.ToString()}]3: Запуск функции счёта до 3х"));
        var times = new List<DateTime>();
        for (int i = 0; i < 3; i++)
        {
            Task.Delay(1000);
            times.Add(DateTime.Now);
        }
        CountToThreeLogs.Items.Add(new ListViewItem($"[{DateTime.Now.ToString()}]3: Завершение функции счёта до 3х"));
        foreach (var value in times) {
            CountToThreeLogs.Items.Add(new ListViewItem($"[{DateTime.Now.ToString()}]3: {value}"));
        }

        // Здесь форматированный вывод результата times через foreach
    }

    private void SumCalc_Click(object sender, EventArgs e)
    {
        CalculateSum();
    }

    private void CountThree_Click(object sender, EventArgs e)
    {
        CountToThree();
    }

    private void ShowSysTime_Click(object sender, EventArgs e)
    {
       GetCurrentTime();

    }
}