using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите заработную плату сотрудника:");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите выслугу лет сотрудника:");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());

        decimal bonusPercentage;

        if (yearsOfService < 5)
        {
            bonusPercentage = 0.10m;
        }
        else if (yearsOfService < 10)
        {
            bonusPercentage = 0.15m;
        }
        else if (yearsOfService < 15)
        {
            bonusPercentage = 0.25m;
        }
        else if (yearsOfService < 20)
        {
            bonusPercentage = 0.35m;
        }
        else if (yearsOfService < 25)
        {
            bonusPercentage = 0.45m;
        }
        else
        {
            bonusPercentage = 0.50m;
        }

        decimal bonus = salary * bonusPercentage;

        Console.WriteLine($"Заработная плата: {salary}");
        Console.WriteLine($"Выслуга лет: {yearsOfService}");
        Console.WriteLine($"Процент премии: {bonusPercentage * 100}%");
        Console.WriteLine($"Начисленная премия: {bonus}");
    }
}