# Coding-tasks
Large projects or small tasks that I created.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Четене на две цели числа от клавиатурата
            Console.Write("Въведете първото число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Въведете второто число: ");
            int b = int.Parse(Console.ReadLine());

            // Проверка дали числата са взаимно прости
            if (AreCoprime(a, b))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                int gcd = FindGCD(a, b);
                Console.WriteLine($"No {gcd}");
            }
        }

        // Метод за намиране на НОД (най-големия общ делител)
        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Метод за проверка дали числата са взаимно прости
        static bool AreCoprime(int a, int b)
        {
            return FindGCD(a, b) == 1;
        }
    }
}
