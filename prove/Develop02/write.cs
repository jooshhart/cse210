using System;
using System.Data;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Write
{
    public void ClearFile()
    {
    if (!File.Exists("myFile.txt"))
        File.Create("myFile.txt");

    TextWriter tw = new StreamWriter("myFile.txt", false);
    tw.Write(string.Empty);
    tw.Close();
    }
}