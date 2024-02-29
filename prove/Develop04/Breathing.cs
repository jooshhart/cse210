using System;
using System.Threading;

public class Breathing : Activity
{
    public Breathing(int durationInSeconds) : base(durationInSeconds)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Starting Breathing Activity...");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Thread.Sleep(3000); // Pause for 3 seconds

        
        // Breathing loop
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(durationInSeconds);
        Console.Clear();
        while (DateTime.Now < end)
        {
            for (int a = 4; a > 0; a--)
            {
                Console.Write($"Breathe in... {a}");
                Thread.Sleep(1000);
                Console.Clear();
            };
            for (int b = 6; b > 0; b--)
            {
                Console.Write($"Breathe out... {b}");
                Thread.Sleep(1000);
                Console.Clear();
            };
        };

        Console.WriteLine("Breathing Activity Completed.");
    }
}