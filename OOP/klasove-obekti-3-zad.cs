using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasove_obekti
{
    class Program
    {
        
        class MobilePhone
        {
            public string OS;
            public string brand;
            public string model;
            public double price;

            public void Input()
            {
                Console.Write("OS: ");
                OS = Console.ReadLine();
                Console.Write("Brand: ");
                brand = Console.ReadLine();
                Console.Write("Model: ");
                model = Console.ReadLine();
                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine());
            }

            public void Print()
            {
                Console.WriteLine($"{brand} {model} - {OS} - {price}");
            }
        }

        static void Main(string[] args)
        {
            MobilePhone[] phones = new MobilePhone[3];
            for (int i = 0; i < phones.Length; i++)
            {
                phones[i] = new MobilePhone();
                phones[i].Input();
            }

            Array.Sort(phones, (a, b) => a.OS.CompareTo(b.OS));

            foreach (var p in phones)
                p.Print();

            Console.ReadKey();
            
           
        }
    }
}
