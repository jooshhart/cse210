using System;
using System.Collections.Generic;
using System.IO;

public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, string desc, int value, int targetCount) : base(name, desc, value)
    {
        this.targetCount = targetCount;
        currentCount = 0;
    }

    public override void RecordEvent()
    {
        currentCount++;
        if (currentCount >= targetCount)
        {
            Completed = true;
            Value += 500; // Bonus points when checklist goal is completed
        }
    }

    public override string Progress()
    {
        return Completed ? "[X]" : "[ ]" + $"{Name}, {Desc}, Completed {currentCount}/{targetCount} times";
    }
    public int GetTargetCount()
    {
        return targetCount;
    }
}