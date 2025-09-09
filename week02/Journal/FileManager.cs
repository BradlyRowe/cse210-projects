using System;
using System.Collections.Generic;
using System.IO;

public static class FileManager
{
    public static void SaveEntries(string filename, List<Entry> entries)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                string tags = string.Join(",", entry.Tags);
                writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}|{entry.Mood}|{tags}");
            }
        }
    }

    public static List<Entry> LoadEntries(string filename)
    {
        List<Entry> entries = new List<Entry>();
        foreach (string line in File.ReadLines(filename))
        {
            string[] parts = line.Split('|');
            if (parts.Length >= 5)
            {
                entries.Add(new Entry
                {
                    Date = parts[0],
                    PromptText = parts[1],
                    EntryText = parts[2],
                    Mood = parts[3],
                    Tags = new List<string>(parts[4].Split(','))
                });
            }
        }
        return entries;
    }
}
