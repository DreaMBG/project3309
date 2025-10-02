// Програмата пресмята детерминанта само на матрици, които са 2х2 или 3х3.
// Потребителят прави своят избор, каква матрица да използва.

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
            // колони и редове въведени от потребителя

            Console.Write("Въведете редовете на матрицата: ");
            int red = int.Parse(Console.ReadLine());

            Console.Write("Въведете колоните на матрицата: ");
            int kolona = int.Parse(Console.ReadLine());

            int[,] matrix = new int[red, kolona];


            Console.WriteLine("Въведете елементите на матрицата: ");
            
            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < kolona; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    
                }
            }

            Console.WriteLine($"\nВъведената матрица е: ");
            int count = 0;
            foreach (int element in matrix)
            {
                Console.Write(element + " ");
                count++;
                if (count % kolona == 0) Console.WriteLine();
            }

            if (red == 2) {
                int determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
                Console.WriteLine($"Детерминантата на матрицата е: {determinant}");
            } else
            {
                int det3 =
                    matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                    matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                    matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
                Console.WriteLine($"Детерминантата на матрицата е: {det3}");
            }
            
            Console.ReadLine();
        }
    }
}
