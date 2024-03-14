using System;
using System.Collections.Generic;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string desc, int value) : base(name, desc, value) { }

    public override void RecordEvent()
    {
        Completed = true;
    }

    public override string Progress()
    {
        return Completed ? "[X]" : "[ ]" + $"{Name}, {Desc}";
    }
}