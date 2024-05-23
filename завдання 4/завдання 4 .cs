using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
            { 5, 3, -8, 6 },
            { 7, 1, 4, 2 },
            { 9, 6, 3, -5 },
            { 4, 7, 2, 1 }
        };

            int n = matrix.GetLength(0); // Кількість рядків в матриці
            int[] b = new int[n];

            for (int i = 0; i < n; i++) 
            {
                int min = matrix[i, 0];
                for (int j = 0; j <= i; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                b[i] = min;
            }

            // Виведення масиву b
            Console.WriteLine("Масив b:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
