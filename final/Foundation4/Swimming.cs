public class Swimming : Activity
{
    private int laps;
    private const double LapLengthInMeters = 50;
    private const double MetersToMiles = 0.000621371;

    public Swimming(DateTime date, int length, int laps)
        : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * LapLengthInMeters) * MetersToMiles;

    public override double GetSpeed() => (GetDistance() / Length) * 60;

    public override double GetPace() => Length / GetDistance();
}
