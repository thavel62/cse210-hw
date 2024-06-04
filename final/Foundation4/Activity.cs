using System;

public abstract class Activity
{
    private DateTime date;
    private int length; // length of activity in minutes

    protected Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public int Length => length;

    public virtual double GetDistance() => 0.0;
    public virtual double GetSpeed() => 0.0;
    public virtual double GetPace() => 0.0;

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {this.GetType().Name} ({length} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
