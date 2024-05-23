using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть значення n:");
           
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (i * (i + 1));
            }

            Console.WriteLine($"Сума ряду: {sum}");
            Console.ReadLine();

        }
    }
 }
 
