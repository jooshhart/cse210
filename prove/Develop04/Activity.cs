using System;
using System.Threading;

public abstract class Activity
{
    protected int durationInSeconds;

    public Activity(int durationInSeconds)
    {
        this.durationInSeconds = durationInSeconds;
    }

    public abstract void Start();
}