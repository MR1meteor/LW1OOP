using Random = System.Random;
using Timer = System.Threading.Timer;

namespace LW1;

public partial class Form1 : Form
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
    
    public Form1()
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
    
    private void CalculateSum(IEnumerable<int> vector)
    {
        long sum = 0;
        foreach (var value in vector)
        {
            sum += value;
        }

        // Здесь форматированны вывод результата sum
    }

    private void GetCurrentTime()
    {
        var time = DateTime.Now;
        
        // Здесь форматированный вывод результата time
    }

    private void CountToThree()
    {
        var times = new List<DateTime>();
        for (int i = 0; i < 3; i++)
        {
            Task.Delay(1000);
            times.Add(DateTime.Now);
        }
        
        // Здесь форматированный вывод результата times через foreach
    }
}