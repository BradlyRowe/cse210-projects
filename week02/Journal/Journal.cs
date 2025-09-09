using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetDisplayText());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                string tags = string.Join(",", entry.Tags);
                writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}|{entry.Mood}|{tags}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        foreach (string line in File.ReadLines(filename))
        {
            string[] parts = line.Split('|');
            if (parts.Length >= 5)
            {
                Entry entry = new Entry
                {
                    Date = parts[0],
                    PromptText = parts[1],
                    EntryText = parts[2],
                    Mood = parts[3],
                    Tags = new List<string>(parts[4].Split(','))
                };
                _entries.Add(entry);
            }
        }
    }
}
