using System;
// Parent Class
public class MindfulnessActivity
{
    protected int durationInSeconds;
    public MindfulnessActivity(int duration)
    {
        durationInSeconds = duration;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine("Starting the Activity..."); // Starting message for activity
    }
    public virtual void EndActivity()
    {
        Console.WriteLine($"Activity completed in {durationInSeconds} seconds."); // Ending message
    }
    protected void PauseWithAnimation(int seconds)
    {
        Console.WriteLine($"Pausing for {seconds} seconds");
        System.Threading.Thread.Sleep(seconds*1000);
    }
}