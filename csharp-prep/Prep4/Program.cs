using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        List<int> numbers = new List<int>();
        int c;

        while (number != 0)
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        };
        numbers.Remove(0);

        c = numbers.Count;
        Console.WriteLine("You wrote " + c + " numbers.");

        int sum = numbers.Sum();
        double av = numbers.Average();
        int large = numbers.Max();

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + av);
        Console.WriteLine("The largest number is: " + large);

    }
}