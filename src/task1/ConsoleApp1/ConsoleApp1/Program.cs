using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Введите число B: ");
        int B = int.Parse(Console.ReadLine());
        if (A >= B)
        {
            Console.WriteLine("Ошибка: A должно быть меньше B. ");
            return;
        }
        int sum = 0;
        Console.WriteLine($"Числа между {A} и {B}: ");
        for (int i = A + 1; i < B; i++)
        {
            sum += i;
            Console.Write(i + " ");
        }
        Console.WriteLine($"Сумма всех чисел между {A} и {B}: {sum} ");
        Console.WriteLine($"Нечетные числа между {A} и {B}: ");
        for (int i = A + 1; i < B; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}
