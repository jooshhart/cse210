using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());
        Fraction w = new Fraction(6);
        Console.WriteLine(w.GetFractionString());
        Console.WriteLine(w.GetDecimalValue());
        Fraction d = new Fraction(6, 7);
        Console.WriteLine(d.GetFractionString());
        Console.WriteLine(d.GetDecimalValue());
        Fraction a = new Fraction(3, 4);
        Console.WriteLine(a.GetFractionString());
        Console.WriteLine(a.GetDecimalValue());
        Fraction b = new Fraction(1, 3);
        Console.WriteLine(b.GetFractionString());
        Console.WriteLine(b.GetDecimalValue());
    }
}