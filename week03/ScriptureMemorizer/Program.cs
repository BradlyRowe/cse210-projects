using System;

class Program
{
    static void Main(string[] args)
    {
        // Load scriptures from the plain-text file. Format per line:
        // book|chapter|verse|endVerse(optional)|text
        var scripturesPath = "scriptures.txt";
        var lines = System.IO.File.Exists(scripturesPath)
            ? System.IO.File.ReadAllLines(scripturesPath)
            : new string[0];

        var entries = new System.Collections.Generic.List<(Reference reference, string text)>();

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            // Split into at most 5 parts to preserve '|' inside text if any.
            var parts = line.Split(new char[] {'|'}, 5);
            if (parts.Length < 5) continue; // skip malformed lines

            var book = parts[0].Trim();
            if (!int.TryParse(parts[1], out int chapter)) continue;
            if (!int.TryParse(parts[2], out int verse)) continue;

            int endVerse = -1;
            if (!string.IsNullOrWhiteSpace(parts[3]))
            {
                int.TryParse(parts[3], out endVerse);
            }

            var text = parts[4].Trim();
            var reference = new Reference(book, chapter, verse, endVerse);
            entries.Add((reference, text));
        }

        // If we found any scriptures in the file use one at random, otherwise fall back to the hard-coded one.
        Reference chosenRef;
        string chosenText;

        if (entries.Count > 0)
        {
            var rnd = new Random();
            var pick = entries[rnd.Next(entries.Count)];
            chosenRef = pick.reference;
            chosenText = pick.text;
        }
        else
        {
            chosenRef = new Reference("Proverbs", 3, 5, 6);
            chosenText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        }

        Scripture scripture = new Scripture(chosenRef, chosenText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) && input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine("All words hidden. Great job!");
    }
}
