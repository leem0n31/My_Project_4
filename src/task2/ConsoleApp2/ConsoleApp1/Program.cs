using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Квадраты чисел от 10 до 20:");
        for (int i = 10; i <= 20; i++)
        {
            int square = i * i;
            Console.WriteLine($"Квадрат числа {i} равен {square}");
        }
    }
}

