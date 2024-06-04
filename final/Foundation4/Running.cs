public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int length, double distance)
        : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / Length) * 60;

    public override double GetPace() => Length / distance;
}
