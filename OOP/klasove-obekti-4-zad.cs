using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasove_obekti
{
    class Program
    {

        static void Main(string[] args)
        {
            Copier[] copiers = new Copier[3];

            for (int i = 0; i < copiers.Length; i++)
            {
                copiers[i] = new Copier();
                copiers[i].Input();
            }

            Array.Sort(copiers, (a, b) => a.PaperFormat.CompareTo(b.PaperFormat));

            foreach (var c in copiers)
                c.Print();

            Console.ReadKey();
        }
    }

    class Copier
    {
        public string Network;
        public string PaperFormat;
        public int PagesPerMinute;
        public string Color;
        public double Price;

        public void Input()
        {
            Console.Write("Mreja: ");
            Network = Console.ReadLine();
            Console.Write("Hartien Format: ");
            PaperFormat = Console.ReadLine();
            Console.WriteLine("Stranici na minuta: ");
            PagesPerMinute = int.Parse(Console.ReadLine());
            Console.Write("Cvqt: ");
            Color = Console.ReadLine();
            Console.Write("Cena: ");
            Price = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"{Network} - {PaperFormat} - {PagesPerMinute} - {Color} - {Price}");
        }
    }
}
