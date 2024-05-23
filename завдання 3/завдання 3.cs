using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1.7, b = 2.3;

            for (double x = -1; x <= 1; x += 0.5)
            {
                for (double y = -2; y <= 2; y += 1)
                {
                    double z;
                    if (x * y > 0)
                    {
                        // Використовується, коли xy > 0
                        z = Math.Log(Math.Sqrt(a * Math.Pow(x, 2) + b * Math.Pow(y, 3)));
                    }
                    else if (x * y < 0)
                    {
                        // Використовується, коли xy < 0
                        z = Math.Pow(a, x) + Math.Pow(b, y);
                    }
                    else
                    {
                        // Встановлюється в 0, коли xy = 0
                        z = 0;
                    }


                    Console.WriteLine($"Для x = {x}, y = {y}, z = {z:F2}");
                
                }
                
            }
            Console.ReadLine();

        }


    }
}
