using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите b");
        int    b = int.Parse(Console.ReadLine());
        Console.WriteLine("Среднее арифметическое: " + (double)((a + b) / 2));
        Console.WriteLine("Среднее геометрическое: " + (double)(a * b));
    }
}