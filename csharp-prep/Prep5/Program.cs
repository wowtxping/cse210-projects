using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int Squared = number * number;
            return Squared;
        }

        static void DisplayResult(string name, int SquaredNumber)
        {
            Console.WriteLine($"{name}, the squre of your number is {SquaredNumber}");
        }

        static void main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int squred = SquareNumber(number);
            DisplayResult(name, squred);
        }

        main();
    }
}