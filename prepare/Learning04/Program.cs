using System;

class Program
{
    static void Main(string[] args)
    {
        Base a = new Base("Josh Hart", "Multiplication");
        Console.WriteLine(a.GetSummary());
        Math b = new Math("Machete Rodriguez", "Fractions", "9.3", "9-17");
        Console.WriteLine(b.GetSummary());
        Console.WriteLine(b.GetHomework());
        Writing c = new Writing("Berry Smith", "World History", "The Bear Warrior of World War II");
        Console.WriteLine(c.GetSummary());
        Console.WriteLine(c.GetWriting());
    }
}