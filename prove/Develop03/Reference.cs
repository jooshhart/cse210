using System;
using System.Data;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse; 
    private string _endverse;

    public Reference(string book, string chapter, string verse, string endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = endverse;
    }
    public void Setreference(string book, string chapter, string verse, string endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = endverse;
    }
    public string Getreference()
    {
        return _book + " " + _chapter + ":" + _verse + "-" + _endverse;
    }
}

