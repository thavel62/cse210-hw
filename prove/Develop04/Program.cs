using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    RunBreathingActivity();
                    break;
                case 2:
                    RunReflectionActivity();
                    break;
                case 3:
                    RunListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid Choice. Please select again. ");
                    break;
            }
        }
    }
    static void RunBreathingActivity()
    {
        // set up timer for breathing activity
        Console.WriteLine("Enter duration of breathing activity (in seconds): ");
        int duration = int.Parse(Console.ReadLine());

        BreathingActivity breathingActivity = new BreathingActivity(duration);
        breathingActivity.StartActivity();
        breathingActivity.PerformingBreathingExercise();
        breathingActivity.EndActivity();
    }

    static void RunReflectionActivity()
    {
        // no prompt for time
        ReflectionActivity reflectionActivity = new ReflectionActivity(); // no timer necessary
        reflectionActivity.StartActivity();
        reflectionActivity.PerformReflection();
        reflectionActivity.EndActivity();
    }

    static void RunListingActivity()
    {
        Console.WriteLine("Enter duration of listing activity (in seconds): ");
        int duration = int.Parse(Console.ReadLine());

        ListingActivity listingActivity = new ListingActivity(duration);
        listingActivity.StartActivity();
        listingActivity.ListItems();
        listingActivity.EndActivity();
    }
}