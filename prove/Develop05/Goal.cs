using System;
using System.Collections.Generic;
using System.IO;

// Base class for goals
public abstract class Goal
{
    public string Name { get; protected set; }
    public string Desc { get; protected set; }
    public int Value { get; protected set; }
    public bool Completed { get; protected set; }

    public Goal(string name, string desc, int value)
    {
        Name = name;
        Desc = desc;
        Value = value;
        Completed = false;
    }

    public abstract void RecordEvent();
    public abstract string Progress();
}