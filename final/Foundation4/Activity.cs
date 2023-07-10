using System;
using System.Collections.Generic;
public abstract class Activity
{
    private DateTime date;
    public int minutes;
    protected double distance;
    protected double speed;
    protected double pace;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public int Minutes
    {
        get { return minutes; }
        set { minutes = value; }
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return string.Format(
            "{0} ({1} min)\nDistance: {2}, Speed: {3}, Pace: {4}",
            Date,
            minutes,
            GetDistance(),
            GetSpeed(),
            GetPace());
    }
}