using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasove_obekti
{
    class Program
    {

        class Book
        {
            public string Title;
            public string Author;
            public string Publisher;
            public int Year;

            public void Input()
            {
                Console.Write("Zaglavie: ");
                Title = Console.ReadLine();
                Console.Write("Avtor: ");
                Author = Console.ReadLine();
                Console.Write("Izdatelstvo: ");
                Publisher = Console.ReadLine();
                Console.Write("Godina: ");
                Year = int.Parse(Console.ReadLine());
            }

            public void Print()
            {
                Console.WriteLine($"{Title} - {Author} - {Publisher} - {Year}");
            }
        }

        static void Main(string[] args)
        {
            Book[] books = new Book[5];
            HashSet<string> titles = new HashSet<string>();

            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new Book();
                books[i].Input();

                if (!titles.Contains(books[i].Title))
                {
                    titles.Add(books[i].Title);
                    books[i].Print();
                }
            }


        }
    }
}
