using System;
using System.Collections.Generic;
using System.IO;

public class EternalQuestProgram
{
    private List<Goal> goals;
    private int score;

    public EternalQuestProgram()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            score += goal.Value;
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{goal.Progress()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current score: {score}");
    }

    public void SaveProgress(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                if (goal is ChecklistGoal checklistGoal)
            {
                outputFile.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Desc},{goal.Value},{checklistGoal.GetTargetCount()},{goal.Completed}");
            }
            else
            {
                outputFile.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Desc},{goal.Value},{goal.Completed}");
            }
            }
            outputFile.WriteLine(score);
        }
    }

    public void LoadProgress(string filename)
    {
        goals.Clear();
        using (StreamReader inputFile = new StreamReader(filename))
        {
            string line;

            while ((line = inputFile.ReadLine()) != null)
            {
                line = line.Trim();
                Console.WriteLine($"Trimmed Line: '{line}'");
                
                string[] parts = line.Split(",").Select(p => p.Trim()).ToArray();;
                if (parts.Length < 5)
                {
                    Console.WriteLine("Error: Line does not contain enough elements.");
                    continue; // Skip this line and move to the next one
                }

                string type = parts[0];
                string name = parts[1];
                string desc = parts[2];
                int value;
                if (!int.TryParse(parts[3], out value))
                {
                    Console.WriteLine("Error: Unable to parse value as integer.");
                    continue; // Skip this line and move to the next one
                }
                string progress = parts[4];

                // Debugging statement to check values
                Console.WriteLine($"Type: {type}, Name: {name}, Desc: {desc}, Value: {value}, Progress: {progress}");
            
                Goal goal;
                if (type == "SimpleGoal")
                {
                    goal = new SimpleGoal(name, desc, value);
                }
                else if (type == "EternalGoal")
                {
                    goal = new EternalGoal(name, desc, value);
                }
                else // ChecklistGoal
                {
                    int targetCount = int.Parse(parts[4]);
                    string progres = parts[5];
                    goal = new ChecklistGoal(name, desc, value, targetCount);
                }

                goals.Add(goal);

                // Record progress based on the loaded data
                if (progress == "True")
                {
                    goal.RecordEvent();
                }
            }
        }
    }

    // Additional methods for creative additions and exceeding requirements can be added here
}