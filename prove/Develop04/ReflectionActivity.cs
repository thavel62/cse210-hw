public class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity(int duration) : base(duration)
    {}
    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("Starting Reflection activity...");
    }

    public override void EndActivity()
    {
        Console.WriteLine("Ending Reflection Activity...");
        base.EndActivity();
    }
    public void ReflectOnExperience()
    {
        Console.WriteLine("Reflecting on experience...");
    }
}