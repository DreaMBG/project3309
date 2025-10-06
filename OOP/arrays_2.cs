using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Въведете броят на N елементите - > ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Елемент [{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    count++;
            }

            int[] polojitleni = new int[count];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    polojitleni[index] = arr[i];
                    index++;
                }
            }

            Console.WriteLine("\nВъвеждане на първият масив");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nВъвеждане на положителните числа");
            for (int i = 0; i < polojitleni.Length; i++)
            {
                Console.Write(polojitleni[i] + " ");
            }


            Console.ReadKey();

        }
    }
}
