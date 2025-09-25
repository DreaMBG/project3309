using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Zadachi_25_09_2025_Mehret
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vid na triugulnik");

            Console.WriteLine("Vuvedete strana A = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete strana B = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete strana C = ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Triugulnikut e pravougulen.");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Triugulnikut e ravnobedren.");
                else
                    Console.WriteLine("Triugulnikut e raznostranen");
            }
            else
            {
                Console.WriteLine("Ne moje da se napravi triugulnik s tezi strani.");
            }
            Console.ReadLine();
        }
    }
}
