using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration)
    {}
    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("Starting Breathing Activity...");
    }

    public override void EndActivity()
    {
        Console.WriteLine("Ending Breathing Activity...");
        base.EndActivity();
    }
    public void PerformingBreathingExercise()
    {
        Console.WriteLine("Performing breathing exercise...");
    }
}
