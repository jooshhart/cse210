using System;
using System.Diagnostics;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Load load = new Load();
        Dictionary<string, double> dictionary = load.LoadDictionary();
        Console.Write("Loading documents.");
        Thread.Sleep(1000);
        Console.Write("\r\rLoading documents..");
        Thread.Sleep(1000);
        Console.Write("\r\rLoading documents...");
        Console.Clear();
        Save s = new Save();
        int pick = 0;
        while (pick != 4)
        {
            Console.WriteLine("Welcome to the budgeting Menu: \nWhat would you like to do?\n(1)Load budget\n(2)Create new budget\n(3)Save budget\n(4)Quit\n(Please pick a number between 1-4): ");
            pick = int.Parse(Console.ReadLine());
            if (pick == 1)
            {
                if (dictionary.Count > 0)
                {
                    Console.WriteLine("budgets: ");
                    foreach (string key in dictionary.Keys)
                    {
                        Console.WriteLine(key);
                    }
                    Console.WriteLine("What is the name of this budget?");
                    string name = Console.ReadLine();
                    if (!dictionary.ContainsKey(name))
                    {
                        Console.WriteLine("There is no budget under that name.");
                        Thread.Sleep(5000);
                    }
                    else
                    {
                        Console.WriteLine($"{name}: {dictionary[name]}");
                    };
                }
                else
                {
                    Console.WriteLine("You don't have any budgets. Please first create a budget.");
                    Thread.Sleep(5000);
                };
            }
            if (pick == 2)
            {
                Console.WriteLine("Please enter a name: ");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"This document is for {name}.");
                Thread.Sleep(1000);
                Console.Write("Loading resources.");
                Thread.Sleep(1000);
                Console.Write("\r\rLoading resources..");
                Thread.Sleep(1000);
                Console.Write("\r\rLoading resources...");
                Console.Clear();
                Income i = new Income();
                Console.WriteLine("Let's start with your income.");
                double income = i.Calculate();
                Expense e = new Expense();
                Console.WriteLine("Now let's write your expenses.");
                double expense = e.Calculate();
                double budget = income - expense;
                Console.WriteLine($"Income: {income}\nExpense: {expense}\nBudget: {budget}");
                if (budget < 0)
                {
                    Console.WriteLine("Looks like you need to work on your budget...");
                    Thread.Sleep(5000);
                }
                else
                {
                    Console.WriteLine("Yay! You aren't under budget!");
                    Thread.Sleep(5000);
                };
                dictionary.Add(name, budget);
            }
            if (pick == 3)
            {
                s.SaveDictionary(dictionary);
            }
            if (pick == 4)
            {
                Console.WriteLine("Shutting Down");
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("Please pick a number between 1-4");
                Thread.Sleep(5000);
            }
            Console.Clear();
        };
    }
}