using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_завдання
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0; // Лічильник для збереження кількості відповідних чисел

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введіть число:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > 0 && number % 5 != 0) // Перевірка, чи число додатне і чи ділиться на 5 з залишком
                {
                    count++;
                }
            }

            Console.WriteLine($"Кількість додатних чисел, що діляться на 5 з залишком: {count}");
            Console.ReadLine();
        }
    }
}
