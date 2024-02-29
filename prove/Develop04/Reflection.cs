using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class Reflection : Activity
{
    private string[] reflections = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of the last food you ate.",
        "Think of the last game you played."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection(int durationInSeconds) : base(durationInSeconds)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Starting Reflection Activity...");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.Clear();

        Random rnd = new Random();
        string reflection = reflections[rnd.Next(reflections.Length)];
        Console.WriteLine(reflection);
        Thread.Sleep(3000);

        // Reflection loop
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(durationInSeconds);
        while (start < end)
        {
            Console.WriteLine(_questions[rnd.Next(_questions.Length)]);
            Thread.Sleep(5000);
            start = DateTime.Now;
        };

        Console.WriteLine("Reflection Activity Completed.");
    }
}