using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число n:");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Сумма чисел от 1 до {n} равна {sum}");
    }
}