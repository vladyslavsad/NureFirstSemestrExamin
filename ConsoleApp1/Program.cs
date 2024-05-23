using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть натуральне число:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть цифру 'a' для перевірки:");
        int digitToCheck = Convert.ToInt32(Console.ReadLine());

        bool isDigitAbsent = IsDigitAbsent(number, digitToCheck);
        string result = isDigitAbsent ? "Цифра відсутня" : "Цифра присутня";

        Console.WriteLine(result);
    }

    static bool IsDigitAbsent(int number, int digit)
    {
        while (number > 0)
        {
            if (number % 10 == digit)
            {
                return false;
            }
            number /= 10;
        }
        return true;
    }
}