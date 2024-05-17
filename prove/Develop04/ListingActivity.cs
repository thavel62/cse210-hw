using System;

public class ListingActivity : MindfulnessActivity
{
    public ListingActivity(int duration) : base(duration)
    {}
    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("Starting Listing Activity...");
    }
    public override void EndActivity()
    {
        Console.WriteLine("Ending Listing Activity...");
        base.EndActivity();
    }
    public void ListItems()
    {
        Console.WriteLine("Listing items...");
    }
    
}