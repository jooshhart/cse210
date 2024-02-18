using System;
using System.Runtime.InteropServices;

class Scripture
{
    private string _scripture;

    public Scripture(string scripture)
    {
        _scripture = scripture;
    }
    public string Getscripture()
    {
        return _scripture;
    }
    public void Setscripture()
    {
        Word w = new Word();
        _scripture = w.Hider();
    }
}