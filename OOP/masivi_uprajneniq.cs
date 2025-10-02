using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете броя на елементите n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Въведете елементите на масива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"myNum[{i + 1}]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nПрав ред");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nОбратен ред");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }



            Console.ReadLine();
        }
    }
}
