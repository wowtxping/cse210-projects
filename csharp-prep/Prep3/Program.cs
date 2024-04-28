using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGerator = new Random();
        int magicNumber = randomGerator.Next(1,101);
        Console.Write("What's your guess? ");
        int guessNumber = int.Parse(Console.ReadLine());
        while (guessNumber != magicNumber)
        {
            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
                Console.Write("What's your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
            }

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What's your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("you guessed it!");
    }
}