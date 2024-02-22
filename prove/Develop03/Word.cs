using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Threading.Tasks.Dataflow;

public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Reveal()
    {
        IsHidden = false;
    }

    public override string ToString()
    {
        return IsHidden ? "______" : Text;
    }
}