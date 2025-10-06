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
            
                string[,] months = {
                { "Януари", "31" },
                { "Февруари", "28" },
                { "Март", "31" },
                { "Април", "30" },
                { "Май", "31" },
                { "Юни", "30" },
                { "Юли", "31" },
                { "Август", "31" },
                { "Септември", "30" },
                { "Октомври", "31" },
                { "Ноември", "30" },
                { "Декември", "31" },
            };

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{months[i, 0]} има {months[i, 1]} дни.");
            }

            Console.ReadKey();

        }
    }
}
