using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer! (Please press \"Enter\" to continue)");
        Console.ReadLine();
        // Console.Clear();
        Reference r = new Reference("Helaman", "12", "7", "8");
        Console.WriteLine("You are reading: " + r.Getreference() + " (Please press \"Enter\" to continue)");
        Console.ReadLine();
        Scripture s = new Scripture("O how great is the nothingness of the children of men; yea, even they are less than the dust of the earth. For behold, the dust of the earth moveth hither and thither, to the dividing asunder, at the command of our great and everlasting God.");
        Word w = new Word();
        w.Hide();
        int count = 0;
        int span = s.Getscripture().Split(" ").Count();
        while (count != span)
        {
            // Console.Clear();
            Console.Write(r.Getreference());
            Console.Write(s.Getscripture());
            Console.WriteLine("(Please press \"Enter\" to continue)");
            Console.ReadLine();
            Console.WriteLine(w.Getanswer());
            count = count + 1;
            s.Setscripture();
        };
    }
}