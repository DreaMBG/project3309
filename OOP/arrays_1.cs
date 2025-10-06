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

            Console.Write("Въведете броя на n елементите -> ");
            int n = int.Parse(Console.ReadLine());

            double[] arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Елемент [{i}] = ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nЕлементите в прав ред");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nЕлементите в обратен ред");
            for(int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nЕлементите в четен индекс");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.WriteLine("\nЕлементите с нечетен идекс");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }


            Console.ReadLine();

        }
    }
}
