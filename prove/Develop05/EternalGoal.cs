using System;
using System.Collections.Generic;
using System.IO;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int value) : base(name, desc, value) { }

    public override void RecordEvent()
    {
        // Eternal goals are never completed
    }

    public override string Progress()
    {
        return "[ ]" + $"{Name}, {Desc}";
    }
}