using System;
using System.Threading;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Menu.\nYou have three choices of activities to choose from below.\n");
        int choice = 4;
        while (choice != 0)
        {
            Console.WriteLine("Type their respectful number to continue.\n(1) Breathing\n(2) Reflection\n(3) Listing\n(0) Exit");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();
            if (choice == 1)
            {
                Console.WriteLine("Welcome to the Breathing activity.\n\nHow long in seconds (By 10) would you like for your session?");
                Activity activity = new Breathing(int.Parse(Console.ReadLine()));
                activity.Start();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Welcome to the Reflection Activity.\n\nHow long in seconds (By 5) would you like for your session?");
                Activity activity = new Reflection(int.Parse(Console.ReadLine()));
                activity.Start();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Welcome to the Listing Activity.\n\nHow long in seconds would you like for your session?");
                Activity activity = new Listing(int.Parse(Console.ReadLine()));
                activity.Start();
            }
            else if (choice == 0)
            {
                Console.WriteLine("Thank you for your time on the Mindfulness Menu.");
            }
            else
            {
                Console.WriteLine("I'm sorry, but you need to give an answer between 1 and 3.");
            };
        };
    }
}