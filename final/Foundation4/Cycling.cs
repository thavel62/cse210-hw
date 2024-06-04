public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int length, double speed)
        : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * Length) / 60;

    public override double GetSpeed() => speed;

    public override double GetPace() => 60 / speed;
}
