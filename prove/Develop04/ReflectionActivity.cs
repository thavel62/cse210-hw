using System;

public class ReflectionActivity : MindfulnessActivity
{
    // Prompts for the relection generator
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"    
    };

    public ReflectionActivity() : base(0)
    {}
    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you reflect on times in your life when you showed strength or resiliance.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    public void PerformReflection()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine(); // wait for enter key

        string selectedReflectionQuestion = reflectionQuestions[random.Next(reflectionQuestions.Length)];
        Console.WriteLine(selectedReflectionQuestion);
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine(); // wait for enter key

        Console.WriteLine("Reflection session completed.");
    }


}