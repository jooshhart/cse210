using System;
using System.IO;



public class Read
{
    public string[] reader()
    {
        string filename = "myfile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        return lines;
    }
}

