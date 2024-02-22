using System;
using System.Runtime.InteropServices;

public class Scripture
{
    public string Reference { get; private set;}
    private List<Word> Words { get; set;}

    Reference r = new Reference("Helaman", "12", "7", "8");

    public Scripture(string text)
    {
        Reference = r.Getreference();
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numToHide)
    {
        var random = new Random();
        var wordsToHide = random.Next(Words.Count);
        for (int i = 0; i < numToHide; i++)
        {
            int index = random.Next(Words.Count);
            while (Words[index].IsHidden) // Ensure not hiding a word already hidden
            {
                index = random.Next(Words.Count);
            }
            Words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return $"{Reference}\n\n{string.Join(" ", Words)}";
    }
}