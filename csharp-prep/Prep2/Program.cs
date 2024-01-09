using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (No decimal)");
        string val = Console.ReadLine();
        int per = int.Parse(val);
        string letter = "";

        if (per >= 90)
        {
            letter = "Your grade is an A";
        }
        else if (per >= 80)
        {
            letter = "Your grade is a B";
        }
        else if (per >= 70)
        {
            letter = "Your grade is a C";
        }
        else if (per >= 60)
        {
            letter = "Your grade is a D";
        }
        else {letter = "Your grade is an F";};
        Console.WriteLine(letter);
        if (per >= 70) {Console.WriteLine("You have passed the class!");};
    }
}