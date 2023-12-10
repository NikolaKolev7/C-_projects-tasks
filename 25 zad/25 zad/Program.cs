using System;

class Program
{
    static void Main()
    {
        Console.Write("Въведете начало на интервала: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Въведете край на интервала: ");
        int end = int.Parse(Console.ReadLine());

        Console.Write("Въведете магическото число: ");
        int magicNumber = int.Parse(Console.ReadLine());

        bool foundCombination = false;

        for (int i = start; i <= end; i++)
        {
            for (int j = start; j <= end; j++)
            {
                if (i + j == magicNumber)
                {
                    Console.WriteLine($"Намерена комбинация: {i} + {j} = {magicNumber}");
                    foundCombination = true;
                }
            }
        }

        if (!foundCombination)
        {
            Console.WriteLine("Не е намерена комбинация.");
        }
    }
}
