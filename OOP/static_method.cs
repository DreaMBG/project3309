using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// figuri - triugulnik, pravougulnik, kvadrat
// da se nameri obikolkata i liceto na vsqka edna ot figurite
// kato se izpolzva za edin ot metodite statichen dostup
// metod za lice - statichen metod
namespace static_method
{
    class Program
    {
        static double LiceTriugulnik(double baseLength, double height)
        {
            return (baseLength * height) / 2;
        }

        static double ObikolkaTriugulnik(double a, double b, double c)
        {
            return a + b + c;
        }

        static void PrintTriugulnik(double a, double b, double c, double height)
        {
            Console.WriteLine("\n=== Триъгълник ===");
            Console.WriteLine("Страни: A = {0}, B = {1}, C = {2}", a, b, c);
            Console.WriteLine("Височина към А = {0}", height);
            Console.WriteLine("Лице = {0}", LiceTriugulnik(a, height));
            Console.WriteLine("Обиколка = {0}", ObikolkaTriugulnik(a, b, c));
        }

        static double PravougulnikLice (double width, double height)
        {
            return width * height;
        }

        static double PravougulnikObikolka (double width, double height)
        {
            return 2 * (width + height);
        }

        static void PrintPravougulnik(double width, double height)
        {
            Console.WriteLine("\n=== Правоъгълник ===");
            Console.WriteLine("Страни: A = {0}, B = {1}", width, height);
            Console.WriteLine("Лице = {0}", PravougulnikLice(width, height));
            Console.WriteLine("Обиколка = {0}", PravougulnikObikolka(width, height));
        }


        static void Main(string[] args)
        {
            Console.Write("Въведи страната A на триъгълника = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Въведи страната B на тригълника = ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Въведи страна C на триъгълмика = ");
            double c = Double.Parse(Console.ReadLine());
            Console.Write("Въведи височина към страната а = ");
            double h = Double.Parse(Console.ReadLine());

            PrintTriugulnik(a, b, c, h);

            Console.Write("\nВъведи страна A на правоъгълника = ");
            double width = Double.Parse(Console.ReadLine());
            Console.Write("Въведи страна B на правоъгълника = ");
            double height = Double.Parse(Console.ReadLine());

            PrintPravougulnik(width, height);

            Console.ReadKey();

        }
    }
}
