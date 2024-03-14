using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int select = 0;
        EternalQuestProgram program = new EternalQuestProgram();
        
        while (select != 6)
        {
            //Console.Clear();
            program.DisplayScore();
            Console.WriteLine("Menu:\n     1. Create New Goal\n     2. List Goals\n     3. Save Goals\n     4. Load Goals\n     5. Record Event\n     6. Quit\nSelect a choice by entering the equivalent numbers 1-6: ");
            select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.Clear();
                int end = 0;
                while (end != 1)
                {
                    Console.WriteLine("Which goal would you like to create?\n     1. Simple Goal\n     2. Eternal Goal\n     3. Checklist Goal\nPlease pick the corresponding numbers 1-3: ");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("What type of goal would you like to create?");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is the name of the goal?");
                        string description = Console.ReadLine();
                        Console.WriteLine("How many points is this goal worth?");
                        int points = int.Parse(Console.ReadLine());
                        Goal goal = new SimpleGoal(name, description, points);
                        program.AddGoal(goal);
                        end = 1;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("What type of goal would you like to create?");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is the name of the goal?");
                        string description = Console.ReadLine();
                        Console.WriteLine("How many points is this goal worth?");
                        int points = int.Parse(Console.ReadLine());
                        Goal goal = new EternalGoal(name, description, points);
                        program.AddGoal(goal);
                        end = 1;
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("What is the name of your goal?");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is the description of the goal?");
                        string description = Console.ReadLine();
                        Console.WriteLine("How many points is this goal worth?");
                        int points = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many times would you like to accomplish this goal to get a bonus?");
                        int times = int.Parse(Console.ReadLine());
                        Goal goal = new ChecklistGoal(name, description, points, times);
                        program.AddGoal(goal);
                        end = 1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please Select a number between 1-3: ");
                        Thread.Sleep(3000);
                    };
                    Console.Clear();
                };
            }
            else if (select == 2)
            {
                Console.Clear();
                program.DisplayGoals();
                Console.WriteLine("Press \"Enter\" when you are ready to continue.");
                Console.ReadLine();
            }
            else if (select == 3)
            {
                Console.Clear();
                program.SaveProgress("progress.txt");
                Console.WriteLine("Saving Progress...");
                Thread.Sleep(3000);
            }
            else if (select == 4)
            {
                Console.Clear();
                program.LoadProgress("progress.txt");
                Console.WriteLine("Loading progress...\nPress \"Enter\" when you are ready to continue: ");
                Console.ReadLine();
                
            }
            else if (select == 5)
            {
                Console.Clear();
                Console.WriteLine("Which goal would you like to accomplish?");
                program.RecordEvent(Console.ReadLine());
            }
            else if (select == 6)
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the Eternal Quest Program.");
                Thread.Sleep(3000);
            }
            else if (select == 7)
            {
                try
                {
                    using (StreamReader sr = new StreamReader("progress.txt"))
                    {
                        string line;
                        int lineNumber = 1;
                        while ((line = sr.ReadLine()) != null)
                        {
                            // Print out the line and its length
                            Console.WriteLine($"Line {lineNumber}: '{line}' (Length: {line.Length})");
                            lineNumber++;
                        }
                    }
                }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please select a number between 1 and 6:");
                Thread.Sleep(3000);
            };
        };
        Console.WriteLine("Shutting Down");
    }
}