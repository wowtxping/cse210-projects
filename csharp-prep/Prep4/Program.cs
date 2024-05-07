using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        while (number !=0)
        {
            numbers.Add(number);
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int max = 0;

        foreach (int num in numbers)
        {
            sum += num;
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = (float)sum/numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");
    }
}