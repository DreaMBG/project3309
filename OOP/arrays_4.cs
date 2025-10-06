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
            Console.Write("Въведете броя на N елементите -> ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Елемент[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
                
            }

            // Метод за принтиране на масив с foreach

            /* foreach (int item in arr)
             {
                 Console.Write(item + " ");
             }*/

            // Още един метод за принтиране на масив
            Console.WriteLine(string.Join(" ",arr));


            int sum = arr.Sum();
            double avg = arr.Average();
            int max = arr.Max();
            int min = arr.Min();

            Console.WriteLine("\nРезултати: \n");
            Console.WriteLine("Сума на елементите: " + sum);
            Console.WriteLine("Средноаритметично: " + avg);
            Console.WriteLine("Най-голям елемент: " + max);
            Console.WriteLine("Най-малък елемент: " + min);

            Console.ReadKey();

        }
    }
}
