using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!!!");
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"Your favorite color is: {color}");
    }
}