using System;

public class Program
{
    public static void Main(string[] args)
    {
        var scripture = new Scripture("O how great is the nothingness of the children of men; yea, even they are less than the dust of the earth. For behold, the dust of the earth moveth hither and thither, to the dividing asunder, at the command of our great and everlasting God.");
        Console.WriteLine("Welcome to Scripture Memorizer!");

        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2);
            // Console.Clear();
        }

        Console.WriteLine("Congratulations! You have hidden all the words in the scripture.");
    }
}