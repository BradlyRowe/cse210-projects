// Enhancements:
// - Added mood and tags to each journal entry.
// - Created PromptGenerator class to encapsulate prompt logic.
// - Created FileManager class to abstract file I/O.
// - Entries are saved in a pipe-delimited format with tag support.
// - These changes exceed the core requirements for creativity and abstraction.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");

                    Entry newEntry = new Entry();
                    newEntry.Date = DateTime.Now.ToShortDateString();
                    newEntry.PromptText = prompt;

                    Console.Write("Your entry: ");
                    newEntry.EntryText = Console.ReadLine();

                    Console.Write("Mood (e.g., happy, stressed, grateful): ");
                    newEntry.Mood = Console.ReadLine();

                    Console.Write("Tags (comma-separated): ");
                    string tagInput = Console.ReadLine();
                    newEntry.Tags = new List<string>(tagInput.Split(','));

                    myJournal.AddEntry(newEntry);
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter the filename to load: ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    break;

                case "4":
                    Console.Write("Enter the filename to save: ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;

                case "5":
                    Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    break;
            }
        }
    }
}
