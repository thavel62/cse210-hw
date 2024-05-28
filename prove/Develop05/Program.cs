using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User("John Doe");

        while (true)
        {
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal(user);
                    break;
                case 2:
                    RecordEvent(user);
                    break;
                case 3:
                    user.DisplayGoals();
                    break;
                case 4:
                    user.DisplayScore();
                    break;
                case 5:
                    user.SaveToFile("goals.txt");
                    break;
                case 6:
                    user.LoadFromFile("goals.txt");
                    break;
                case 7:
                    return;
            }
        }
    }

    static void CreateGoal(User user)
    {
        Console.WriteLine("Enter goal type (1: Simple, 2: Eternal, 3: Checklist):");
        int goalType = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter goal points:");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.WriteLine("Enter target count:");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points:");
                int bonusPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                break;
        }

        if (goal != null)
        {
            user.AddGoal(goal);
        }
    }

    static void RecordEvent(User user)
    {
        Console.WriteLine("Enter the goal number to record an event:");
        int goalNumber = int.Parse(Console.ReadLine());
        user.RecordGoalEvent(goalNumber - 1);
    }
}
