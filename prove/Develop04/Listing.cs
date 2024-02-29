using System;
using System.Threading;

public class Listing : Activity
{

    private string[] _questions = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing(int durationInSeconds) : base(durationInSeconds)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Starting Listing Activity...");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Thread.Sleep(3000);
        Random rnd = new Random();
        string question = _questions[rnd.Next(_questions.Length)];
        for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(question);
                Console.Write($"Take a moment to think...  {i}");
                Thread.Sleep(1000);
                Console.Clear();
            };
        int entries = 0;
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(durationInSeconds);
        while (start < end)
        {
            Console.WriteLine(question);
            Console.ReadLine();
            entries = entries + 1;
            start = DateTime.Now;
            Console.Clear();
        }
        Console.WriteLine($"You've written {entries} entries.");
        Thread.Sleep(3000);

        Console.WriteLine("Listing Activity Completed.");
    }
}