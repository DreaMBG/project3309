using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vuvedete A = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete B = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete C = ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Ne moje da se obrazuva kvadratno uravnenie (a ne moje da bude 0).");
                return;
            }

            double D = b * b - 4 * a * c;
            Console.WriteLine($"Diskriminantata D = {D:f2}");

            if (D > 0)
            {
                double x1 = ((-b + Math.Sqrt(D)) / (2 * a));
                double x2 = ((-b - Math.Sqrt(D)) / (2 * a));
                Console.WriteLine($"X1 = {x1:f2}");
                Console.WriteLine($"X2 = {x2:f2}");
            }
            else if (D == 0)
            {
                double x = -b * (2 / a);
                Console.WriteLine($"Ima edin dvoen koren X = {x:f2}");
            }
            else
            {
                Console.WriteLine("Ne moje da se obrazuva kvadratno uravnenie");
            }
            Console.ReadLine();

        }
    }
}
