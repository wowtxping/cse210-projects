using System;
using System.Globalization;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        choice = int.Parse(Console.ReadLine());
        
        if (choice == 1)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string prompt = PromptGenerator.GetRandomprompt();
            Console.WriteLine(prompt);
            Console.WriteLine("Your entry: ");
            string text = Console.ReadLine();
            Entry entry = new Entry {_date=date, _promptText = prompt, _entryText = text};
            Journal.AddEntry(Entry entry);
        }

        if (choice == 2)
        {
            Journal.DisplayAll();

        }

        if (choice == 3)
        {
            Journal.SaveToFile("journal.txt");
        }

        if (choice == 4)
        {
            Journal.LoadFromFile("journal.txt");

        }

        if (choice == 5)
        {
            Environment.Exit(0);
        }

        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();
    }
}