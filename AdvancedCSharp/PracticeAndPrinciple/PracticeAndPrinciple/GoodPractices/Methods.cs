using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAndPrinciple.GoodPractices
{
    internal class Methods
    {
        public List<int> RequestNumbers(int numbersCount)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Welcome to the app!");
            Console.WriteLine($"Enter {numbersCount} numbers:");
            for (int i = 0; i < numbersCount; i++)
            {
                Console.Write("Enter number:");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            return numbers;
        }
        public void PrintNumbers(List<int> numbers)
        {
            Console.Write("You entered: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public void PrintStats(List<int> numbers)
        {
            Console.WriteLine("Stats:");
            int even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"Even numbers: {even}");

            int odd = numbers.Count - even;
            Console.WriteLine($"Odd numbers: {odd}");

            int positive = numbers.Where(x => x >= 0).Count();
            Console.WriteLine($"Positive numbers: {positive}");

            int negative = numbers.Count - positive;
            Console.WriteLine($"Negative numbers: {negative}");

            int sum = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }
}

