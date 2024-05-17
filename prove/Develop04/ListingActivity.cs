using System;

public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration)
    {}

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    public void ListItems()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have {0} seconds to list as many items as you can.", durationInSeconds);

        int itemsCount = 0;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < durationInSeconds)
        {
            Console.Write("Enter an item (or press Enter to finish): ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                break;
            itemsCount++;
        }

        Console.WriteLine("You listed {0} items.", itemsCount);
    }

    public override void EndActivity()
    {
        base.EndActivity();
        Console.WriteLine("Ending Listing Activity...");
    }
}
