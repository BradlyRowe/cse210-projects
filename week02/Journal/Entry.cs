public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }
    public string Mood { get; set; } // Enhancement
    public List<string> Tags { get; set; } = new List<string>(); // Enhancement

    public string GetDisplayText()
    {
        string tagString = Tags.Count > 0 ? $"Tags: {string.Join(", ", Tags)}" : "";
        return $"{Date} - {PromptText}\n{EntryText}\nMood: {Mood}\n{tagString}\n";
    }
}
