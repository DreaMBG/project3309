using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicheski_pobitovi_operatori
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Aritmetichni operatori\n");
            int a = 10; int b = 3;
            Console.WriteLine($"(a + b) = {a + b}");
            Console.WriteLine($"(a - b) = {a - b}");
            Console.WriteLine($"(a * b) = {a * b}");
            Console.WriteLine($"(a / b) = {a / b}");
            Console.WriteLine($"(a % b) = {a % b}\n");

            Console.WriteLine("Logicheski operatori\n");
            bool x = true, y = false;
            Console.WriteLine($"x && y = {x && y}");
            Console.WriteLine($"x || y = {x || y}");
            Console.WriteLine($"!x = {!x}");

            Console.WriteLine("Pobitovi operatori\n");
            int m = 7, n = 3;
            Console.WriteLine($"m | n = {m | n}");
            Console.WriteLine($"m & n = {m & n}");
            Console.WriteLine($"m >> n = {m >> n}");
            Console.WriteLine($"m << n = {m << n}");
            Console.WriteLine($"m ^ n = {m ^ n}");

            Console.ReadLine();


        }
    }
}

