using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Write q = new Write();
        Read r = new Read();
        string[] file = r.reader();
        Dictionary<string, string> dict = new Dictionary<string, string>();
        foreach (string line in file)
        {
            string[] parts = line.Split(",");
            dict.Add(parts[0], parts[1]);
        }
        List <string> entries = new List<string>();

        int entry = 0;
        Console.WriteLine("Welcome to your Journal!");
        Console.WriteLine("Please enter the date. (type \"MM/DD/YYYY\")");
        string date = Console.ReadLine();
        while (entry != 5)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write Daily Entry (type \"1\")\n2. Display Daily Entries (type \"2\")\n3. Save Daily Entries (type \"3\")\n4. Load Different Day (type \"4\")\n5. Exit Journal (type \"5\")");
            entry = int.Parse(Console.ReadLine());
            if (entry is 1)
            {
                Random rand = new Random();
                int rn = rand.Next(0, 5);
                string question = "";
                if (rn == 1)
                {
                    question = "What did you like about today?";
                }
                else if (rn == 2)
                {
                    question = "What did you do differently today?";
                }
                else if (rn == 3)
                {
                    question = "What did you eat today?";
                }
                else if (rn == 4)
                {
                    question = "Could you tell me something sophisticated?";
                }
                else
                {
                    question = "How much money did you make today?";
                };
                Console.WriteLine(question);
                string statement = Console.ReadLine();
                string combine = "Q: " + question + " A: " + statement;
                if (dict.ContainsKey(date))
                {
                    List<string> result = dict[date].Split(',').ToList();
                    result.Add(combine);
                    dict[date] = string.Join( ";", result);
                }
                else
                {
                    dict.Add(date, combine);
                };
                Console.WriteLine(dict[date]);
            }
            else if (entry is 2)
            {
                if (dict.ContainsKey(date))
                {
                    Console.WriteLine(dict[date]);
                }
                else
                {
                    Console.WriteLine("This date has no entries.");
                };
            }
            else if (entry is 3)
            {
                string asString = string.Join(Environment.NewLine, dict);
                var charsToRemove = new string[] { "[", "]"};
                foreach (var c in charsToRemove)
                {
                    asString = asString.Replace(c, string.Empty);
                }
                q.ClearFile();
                using (StreamWriter outputFile = new StreamWriter("myFile.txt"))
                {
                    outputFile.WriteLine(asString);
                }
                
            }
            else if (entry is 4)
            {
                Console.WriteLine("What date would you like to load? \"MM/DD/YY\"");
                date = Console.ReadLine();
            }
            else if (entry is 5)
            {
                Console.WriteLine("Hope to see you again!");
            }
            else
            {
                Console.WriteLine("Please enter a number 1-5");
            };
            
        };
    }
}