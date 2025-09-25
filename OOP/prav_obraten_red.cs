using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prav_obraten_red
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vuvedete cqlo polojitelno chislo n = ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Vuvedete cqlo polojitelno chislo n");
            }

            Console.WriteLine("Chislata ot 1 do n");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("Chislata ot n do 1 v obraten red");
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i + " ");
            }

            Console.ReadLine();

        }
    }
}
