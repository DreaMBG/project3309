using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasove_obekti
{
    class Program
    {
        abstract class Figura
        {
            public abstract void Input();
            public abstract void Print();
            public abstract double Area();
            public abstract double Perimeter();
        }

        class Pravougulnik : Figura
        {
            double a, b;

            public override void Input()
            {
                Console.Write("A = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("B = ");
                b = double.Parse(Console.ReadLine());
            }

            public override void Print()
            {
                Console.WriteLine($"Pravougulnik a = {a}, b = {b}");
            }

            public override double Area() => a * b;
            public override double Perimeter() => 2 * (a + b);
        }

       

        class Triugulnik : Figura
        {
            double a, b, c, ha;

            public override void Input()
            {
                Console.Write("A = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("B = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("C = ");
                c = double.Parse(Console.ReadLine());
                Console.Write("Ha = ");
                ha = double.Parse(Console.ReadLine());
            }

            public override void Print()
            {
                Console.WriteLine($"Triugulnik a = {a}, b = {b}, c = {c}, ha = {ha}");
                
            }

            public override double Area() => 0.5 * a * ha;
            public override double Perimeter() => a + b + c;  
            

        }

        class Krug : Figura
        {
            double r;

            public override void Input()
            {
                Console.Write("R = ");
                r = double.Parse(Console.ReadLine());
            }

            public override void Print()
            {
                Console.WriteLine($"Krug R = {r}");
            }

            public override double Area() => Math.PI * r * r;
            public override double Perimeter() => 2 * Math.PI * r;
        }

        static void Main(string[] args)
        {
            Figura figura = null;

            Console.WriteLine("1 - Pravougulnik");
            Console.WriteLine("2 - Krug");
            Console.WriteLine("3 - Triugulnik");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: figura = new Pravougulnik(); break;
                case 2: figura = new Krug(); break;
                case 3: figura = new Triugulnik(); break;
            }

            figura.Input();
            figura.Print();
            Console.WriteLine("Lice: " + figura.Area());
            Console.WriteLine("Perimeter: " + figura.Perimeter());
            Console.ReadKey();


        }
    }
}
