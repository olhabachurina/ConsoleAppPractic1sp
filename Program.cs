using System;
using System.Threading;
using System.Linq;
namespace ConsoleApp17;

class Program
{
    //static void Main()
    //{
    //Задание 1
    //Создайте консольное приложение, порождающее
    //поток.Этот поток должен отображать в консоль числа
    //от 0 до 50.
    // Thread thread = new Thread(DisplayNumbers);
    // thread.Start();
    //}
    //static void DisplayNumbers()
    //{
    //    for (int i = 0; i <=50; i++)
    //    {
    //        Console.WriteLine(i);
    //        Thread.Sleep(100);
    //    } 
    //Задание 2
    //Добавьте в первое задание возможность передачи
    //начала и конца диапазона чисел.Границы определяет
    //пользователь
    //Console.Write("Введите начало диапазона: ");
    //int start = int.Parse(Console.ReadLine() ?? "2"); // Если ввод пустой, используем значение 2
    //Console.Write("Введите конец диапазона: ");
    //int end = int.Parse(Console.ReadLine() ?? "50"); // Если ввод пустой, используем значение 50
    //// Создание потока, передача в него метода и диапазона чисел через лямбда-выражение
    //Thread displayThread = new Thread(() => DisplayNumbers(start, end));
    //displayThread.Start();
    //Console.ReadKey();
    //}
    //static void DisplayNumbers(int start, int end)
    //{
    //for (int i = start; i <= end; i++)
    //{
    //Console.WriteLine(i);
    //Thread.Sleep(100);
    //}
    //Console.WriteLine($"Поток вывода чисел от {start} до {end} завершён.");
    //}
    //Задание 3
    //Добавьте к первому заданию возможность определения
    //пользователем количества потоков.Границы диапазона
    //чисел также выбираются пользователем.
    //Console.Write("Введите начало диапазона: ");
    //int start = int.Parse(Console.ReadLine() ?? "2");
    //Console.Write("Введите конец диапазона: ");
    //int end = int.Parse(Console.ReadLine() ?? "50");
    //Console.Write("Введите количество потоков: ");
    //int numberOfThreads = int.Parse(Console.ReadLine() ?? "1");
    //// Рассчитываем размер порции для каждого потока
    //int range = end - start + 1;
    //int rangePerThread = range / numberOfThreads;
    //var threads = new List<Thread>();
    //for (int i = 0; i < numberOfThreads; i++)
    //{
    //int rangeStart = start + (i * rangePerThread);
    //int rangeEnd = (i == numberOfThreads - 1) ? end : rangeStart + rangePerThread - 1;
    //Thread thread = new Thread(() => DisplayNumbers(rangeStart, rangeEnd));
    //threads.Add(thread);
    //thread.Start();
    //}
    //Console.WriteLine("Главный поток завершён.");
    //Console.ReadKey();
    //// Дождемся завершения всех потоков
    //foreach (var thread in threads)
    //{
    // thread.Join();
    //}
    //Console.WriteLine("Все потоки завершили вывод чисел.");
    //}
    //static void DisplayNumbers(int start, int end)
    //{
    //for (int i = start; i <= end; i++)
    //{
    //Console.WriteLine(i);
    //Thread.Sleep(100);
    //}
    //Задание 4
    //Консольное приложение генерирует набор чисел,
    //состоящий из 10000 элементов.С помощью механизма
    //потоков нужно найти максимум, минимум, среднее в этом
    //наборе.
    //Для каждой из задач выделите поток
    //static int[] numbers = new int[10000];
    //static double average;
    //static int min;
    //static int max;
    //static void Main(string[] args)
    //{
    //Random random = new Random();
    //for (int i = 0; i < numbers.Length; i++)
    //{
    //numbers[i] = random.Next(10000);
    //}
    //// Создаем и запускаем потоки для вычисления максимума, минимума и среднего
    //Thread maxThread = new Thread(() => {
    //Console.WriteLine("Поток для поиска максимума начал работу...");
    //FindMax();
    //Console.WriteLine($"Максимальное значение: {max}");
    //Console.WriteLine("Поток для поиска максимума завершил работу.");
    //});
    //hread minThread = new Thread(() => {
    //Console.WriteLine("Поток для поиска минимума начал работу...");
    //FindMin();
    //Console.WriteLine($"Минимальное значение: {min}");
    //Console.WriteLine("Поток для поиска минимума завершил работу.");
    //});
    //Thread averageThread = new Thread(() => {
    //Console.WriteLine("Поток для вычисления среднего начал работу...");
    //FindAverage();
    //Console.WriteLine($"Среднее значение: {average}");
    //Console.WriteLine("Поток для вычисления среднего завершил работу.");
    //});
    //maxThread.Start();
    //minThread.Start();
    //averageThread.Start();
    //// Ожидаем завершения всех потоков
    //maxThread.Join();
    //minThread.Join();
    //averageThread.Join();
    //Console.WriteLine($"Максимальное значение: {max}");
    //Console.WriteLine($"Минимальное значение: {min}");
    //Console.WriteLine($"Среднее значение: {average}");
    //Console.ReadKey();
    //}
    //static void FindMax()
    //{
    //max = numbers.Max();
    //}
    //static void FindMin()
    //{
    //min = numbers.Min();
    //}
    //static void FindAverage()
    //{
    //average = numbers.Average();
    //}
    //Задание 5
    //К четвертому заданию добавьте поток, выводящий
    //набор чисел и результаты вычислений в файл.
    //static int[] numbers = new int[10000];
    //static double average;
    //static int min;
    //static int max;
    //static string filePath = "results.txt"; // Путь к файлу, в который будут записаны результаты
    //static void Main(string[] args)
    //{
    //Random random = new Random();
    //for (int i = 0; i < numbers.Length; i++)
    //{
    //numbers[i] = random.Next(10000);
    //}
    //Thread maxThread = new Thread(() => {
    //Console.WriteLine("Поток для поиска максимума начал работу...");
    //FindMax();
    //Console.WriteLine($"Максимальное значение: {max}");
    //Console.WriteLine("Поток для поиска максимума завершил работу.");
    //});
    //Thread minThread = new Thread(() => {
    //Console.WriteLine("Поток для поиска минимума начал работу...");
    //FindMin();
    //Console.WriteLine($"Минимальное значение: {min}");
    //Console.WriteLine("Поток для поиска минимума завершил работу.");
    //});
    //Thread averageThread = new Thread(() => {
    //Console.WriteLine("Поток для вычисления среднего начал работу...");
    //FindAverage();
    //Console.WriteLine($"Среднее значение: {average}");
    //Console.WriteLine("Поток для вычисления среднего завершил работу.");
    //});
    //Thread fileOutputThread = new Thread(WriteResultsToFile);
    //maxThread.Start();
    //minThread.Start();
    //averageThread.Start();
    //// Дожидаемся завершения вычислительных потоков перед записью в файл
    //maxThread.Join();
    //minThread.Join();
    //averageThread.Join();
    //// Запускаем поток для записи в файл
    //fileOutputThread.Start();
    //fileOutputThread.Join();
    //Console.WriteLine("Все потоки завершили свою работу.");
    //Console.ReadKey();
    //}
    //static void FindMax()
    //{
    //max = numbers.Max();
    //}
    //static void FindMin()
    //{
    //min = numbers.Min();
    //}
    //static void FindAverage()
    //{
    //average = numbers.Average();
    //}
    //static void WriteResultsToFile()
    //{
    //using (StreamWriter writer = new StreamWriter(filePath))
    //{
    //writer.WriteLine("Набор чисел:");
    //foreach (var number in numbers)
    //{
    //writer.Write(number + " ");
    //}
    //writer.WriteLine();
    //// Записываем результатов вычислений
    //writer.WriteLine($"Максимальное значение: {max}")//writer.WriteLine($"Минимальное значение: {min}");
    //writer.WriteLine($"Среднее значение: {average}");
    //}
    //Console.WriteLine("Результаты записаны в файл.");
    //}
    //}
}



    














    

