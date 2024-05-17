using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration)
    {}

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3); // pause for 3 seconds before starting
    }

    public override void EndActivity()
    {
        base.EndActivity();
        Console.WriteLine("Ending Activity. Don't forget your mindful breathing throughout the day.");
        
    }
    public void PerformingBreathingExercise()
    {
        int countdown = durationInSeconds;
        while (countdown > 0)
        {
            Console.WriteLine("Breathe in..."); // breathe in prompt
            PauseWithAnimation(3); // pause for 3 seconds
            Console.WriteLine("Breathe out..."); // exhale prompt
            PauseWithAnimation(3); // pause for 3 seconds
            countdown -= 6; // total cycle time it 6
        }
    }
}
