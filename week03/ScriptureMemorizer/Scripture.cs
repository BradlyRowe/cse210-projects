using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ')
                    .Select(w => new Word(w))
                    .ToList();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = words.Where(w => !w.IsHidden()).ToList();
        var random = new Random();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", words.Select(w => w.GetDisplayText()));
        return $"{reference.GetDisplayText()}\n{scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return words.All(w => w.IsHidden());
    }
}
