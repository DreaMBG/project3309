using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson18_Sep_25_Mehret
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.Read(); // prochita 'a'
            // Console.ReadLine(); // chete niz
            // Console.Write(); // printira suobshtenie
            // Console.WriteLine(); // printira suobshteni + "\ln"

            // int a = int.Parse(Console.ReadLine());
            // int b = int.Parse(Console.ReadLine());
            // int c = int.Parse(Console.ReadLine());
            // string name = Console.ReadLine();


            // Console.WriteLine(name);
            // Console.WriteLine("A = ", a);
            // Console.WriteLine($"B = {b}");
            // Console.WriteLine($"C = {0}" + c);

            // Ima 3 varianta za printirane.

            // ZAD 1
            //int a = 10;
            //int b = 5;
            //Console.WriteLine(a + (--b));
            //Console.WriteLine(a + (++b));
            //Console.WriteLine(a + (b--));
            //Console.ReadLine();
            // 14, 15, 15

            //ZAD2
            //int num = 5;
            //for(int i = num - 1; i < 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            // NOTHING

            //ZAD 3
            //int size = Console.ReadLine(); // greshkata e v (Console.ReadLine());
            //Console.Write(size);

            //ZAD 4
            //int r = int.Parse(Console.ReadLine());
            //double area = Math.PI * r * r;
            //Console.WriteLine("area = "); // nqma izvejdane na double area

            //ZAD 5
            //string niz = "Six" + 5 + 5; // pri niz (string) ne mojesh da dobavqsh chisla
            //Console.WriteLine(niz);


            // GLAVNI ZADACHI

            /*Console.WriteLine("A = ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("B = ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("C = ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("R = ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("H = ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Ha = ");
            double ha = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;

            //kvadrat
            Double skvadrat = Math.Pow(a, 2);
            Console.WriteLine("S (Kvadrat) = " + skvadrat);

            //pravougulnik
            Double sprav = a * b;
            Console.WriteLine("S (Pravougulnik) = " + sprav);

            //krug
            Double skrug = Math.PI * r * r;
            Console.WriteLine("S (Krug) = " + skrug);

            //triugulnik
            Double stri = (a * h) / 2;
            Console.WriteLine("S (Triugulnik) = ", stri);

            //usporednik
            Double susp = (a * ha);
            Console.WriteLine("S (Usporednik) = " + susp);

            //trapec
            Double strap = (a * ha);
            Console.WriteLine($"S (Trapec) = {strap:f2}");

            //lice 3 strani triugulnik
            Double tristrani = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"S (Tri strani triugulnik) = {tristrani:f2}"); */

            Console.WriteLine(" --- Konvertori --- ");
            Console.WriteLine("1. Milimeter -> Meter");
            Console.WriteLine("2. Kilogram -> Ton");
            Console.WriteLine("3. Vek -> Godini");
            Console.WriteLine("4. Minuti -> Chasove");
            Console.WriteLine("5. Celzii -> Farenheit");
            Console.WriteLine("6. Fahrenheit -> Kelvin");

            int izbor = int.Parse(Console.ReadLine());

            switch (izbor)
            {
                case 1:
                    Console.WriteLine("Vuvedete milimetri: ");
                    Double mm = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{mm} mm = {mm / 1000} m");
                    break;

                case 2:
                    Console.WriteLine("Vuvedete kilogrami: ");
                    Double kg = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{kg} kg = {kg / 1000} t");
                    break;

                case 3:
                    Console.WriteLine("Vuvedete vekove: ");
                    int vek = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{vek} vek = {vek * 100} godini");
                    break;

                case 4:
                    Console.WriteLine("Vuvedete minuti: ");
                    double min = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{min} min = {min / 60} chasa");
                    break;

                case 5:
                    Console.WriteLine("Vuvedete *C: ");
                    double c = double.Parse(Console.ReadLine());
                    double f = (c * 9 / 5) + 32;
                    Console.WriteLine($"{c} *C = {f} *F");
                    break;

                case 6:
                    Console.WriteLine("Vuvedete *F: ");
                    double f2 = double.Parse(Console.ReadLine());
                    double k = (f2 - 32) * 5 / 9 + 273.15;
                    Console.WriteLine($"{f2} *F = {k} K");
                    break;

                default:
                    Console.WriteLine("Nevaliden izbor!");
                    break;
            }

            Console.WriteLine("Natisni Enter za da izlezesh.....");
            Console.ReadLine();


        }
    }
}
