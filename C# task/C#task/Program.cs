using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8__page_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете час на излитане (h): ");
            int h = int.Parse(Console.ReadLine());

            Console.Write("Въведете минути на излитане (m): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Въведете продължителност на полета (в минути, m1): ");
            int m1 = int.Parse(Console.ReadLine());

            // Изчисляваме общото време в минути, включително излитането и продължителността на полета
            int totalMinutes = h * 60 + m + m1;

            // Изчисляваме часа на кацането (в часове и минути)
            int landingHour = totalMinutes / 60;
            int landingMinute = totalMinutes % 60;

            Console.WriteLine($"Самолетът ще кацне в {landingHour} часа и {landingMinute} минути.");
        }
    }
}
