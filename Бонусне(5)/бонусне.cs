using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бонусне_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3, 3, 3, 4, 5, 5 }; // Приклад масиву
            var counts = new Dictionary<int, int>();

            // Підрахунок зустрічей кожного елемента
            foreach (var item in array)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts[item] = 1;
                }
            }

            // Підрахунок елементів, що зустрічаються один раз
            int uniqueCount = 0;
            foreach (var pair in counts)
            {
                if (pair.Value == 1)
                {
                    uniqueCount++;
                }
            }

            Console.WriteLine($"Кількість унікальних елементів: {uniqueCount}");
            Console.ReadLine();
        }
    }
}
