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
        Console.WriteLine("Activity completed"); // Ending message
    }
    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds * 10; i++)
        {
            string[] animation = { "|", "/", "-", "\\" };
            Console.Write("\r" + animation[i % 4]);
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine("\r   \r");
    }
}